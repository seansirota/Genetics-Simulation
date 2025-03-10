using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace Genetics_Simulation
{
    // Form for displaying a table of person data.
    public partial class TableDataForm : Form
    {
        private DataGridView _dataGrid;
        private TextBox _searchTextBox;
        private Button _searchButton;
        private Dictionary<string, PropertyInfo> _propertyCache = new Dictionary<string, PropertyInfo>();
        private static List<Person> _population = new List<Person>();
        private BindingSource _bindingSource;

        //Constructor for the table data form, search bar, and search button. Sets properties upon instantiation and handling double-click, sort, and scroll events.
        public TableDataForm(List<Person> population)
        {
            InitializeComponent();
            _population = population ?? new List<Person>();
            _bindingSource = new BindingSource();

            _searchTextBox = new TextBox() { Dock = DockStyle.Top, PlaceholderText = "Enter Person ID" };
            _searchButton = new Button() { Dock = DockStyle.Top, Text = "Search" };
            _searchButton.Click += SearchButton_Click;

            _dataGrid = new DataGridView()
            {
                Dock = DockStyle.Fill,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowHeadersVisible = false,
                AllowUserToResizeColumns = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                MultiSelect = false,
                VirtualMode = true
            };

            _dataGrid.CellDoubleClick += DataGrid_CellDoubleClick;

            ConfigureColumns();

            _bindingSource.DataSource = new SortableBindingList<Person>(_population);
            _dataGrid.DataSource = _bindingSource;

            Controls.Add(_dataGrid);
            Controls.Add(_searchButton);
            Controls.Add(_searchTextBox);

            Load += (s, e) => ResizeFormToFitGrid();
        }

        //Configures the columns of the table data form to display.
        private void ConfigureColumns()
        {
            _dataGrid.AutoGenerateColumns = false;
            (string PropertyName, string HeaderText)[] _columns = new (string PropertyName, string HeaderText)[]
            {
                ("Number", "#"),
                ("ID", "Person ID"),
                ("Gender", "Gender"),
                ("Generation", "Generation"),
                ("RegionKey", "Region"),
                ("Desirability", "Desirability"),
                ("FatherID", "Father ID"),
                ("MotherID", "Mother ID")
            };

            foreach ((string property, string header) in _columns)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property,
                    HeaderText = header,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                _dataGrid.Columns.Add(column);
            }
        }

        //Refreshes the person list in the table data form and redraws the table form.
        public void RefreshPersonList()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshPersonList));
                return;
            }

            _bindingSource.ResetBindings(false);
            ResizeFormToFitGrid();
        }

        //Event handler for when a cell is double-clicked. Opens a new chromosome painter form for the person.
        private void DataGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = _dataGrid.Columns[e.ColumnIndex].DataPropertyName;

            if (columnName == "FatherID" || columnName == "MotherID")
            {
                if (_dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is string parentID)
                {
                    Person? parent = _population.FirstOrDefault(p => p.ID == parentID);

                    if (parent != null)
                    {
                        ChromosomePainterForm painter = new ChromosomePainterForm(parent);
                        painter.Show();
                    }
                    else MessageBox.Show("Parent not found in population.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Person person = _population[e.RowIndex];
                ChromosomePainterForm painter = new ChromosomePainterForm(person);
                painter.Show();
            }
        }

        //Event handler for search button click.
        private void SearchButton_Click(object? sender, EventArgs e)
        {
            string searchID = _searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchID))
            {
                List<Person> filteredPopulation = _population.Where(p => p.ID.Contains(searchID, StringComparison.OrdinalIgnoreCase)).ToList();

                if (filteredPopulation.Any()) _bindingSource.DataSource = new SortableBindingList<Person>(filteredPopulation);
                else
                {
                    MessageBox.Show("Person ID not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _bindingSource.DataSource = new SortableBindingList<Person>(_population);
                }
            }
            else _bindingSource.DataSource = new SortableBindingList<Person>(_population);

            _dataGrid.DataSource = _bindingSource;
        }


        //Event handler for Enter key press in search text box.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SearchButton_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Resizes the form to fit the grid based on the widths of the person objects properties being displayed.
        private void ResizeFormToFitGrid()
        {
            int totalColumnWidth = _dataGrid.Columns.Cast<DataGridViewColumn>().Sum(c => c.Width);
            int formPadding = 20;
            int minHeight = 400;
            ClientSize = new Size(totalColumnWidth + formPadding, Math.Max(minHeight, ClientSize.Height));
        }

        //Event handler for when the form is closed. Disposes of the form.
        private void TableDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();
        }
    }

    //Sortable binding list class for sorting.
    public class SortableBindingList<T> : BindingList<T>
    {
        private ListSortDirection _sortDirection;
        private PropertyDescriptor? _sortProperty;

        public SortableBindingList() : base() { }

        public SortableBindingList(IList<T> list) : base(list) { }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _sortProperty != null;
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        protected override PropertyDescriptor? SortPropertyCore => _sortProperty;

        //Applies the sort to the list.
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            if (prop == null) return;

            List<T>? items = Items as List<T>;
            if (items == null) return;

            items.Sort((x, y) =>
            {
                object? xValue = prop.GetValue(x);
                object? yValue = prop.GetValue(y);
                return direction == ListSortDirection.Ascending ? Comparer<object>.Default.Compare(xValue, yValue) : Comparer<object>.Default.Compare(yValue, xValue);
            });

            _sortProperty = prop;
            _sortDirection = direction;
            ResetBindings();
        }
    }
}