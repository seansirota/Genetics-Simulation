using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetics_Simulation
{
    public partial class TableDataForm : Form
    {
        private DataGridView _dataGrid;
        private Dictionary<string, PropertyInfo> _propertyCache = new Dictionary<string, PropertyInfo>();
        private static List<Person> _population = new List<Person>();

        public TableDataForm(List<Person> population)
        {
            InitializeComponent();
            _population = population ?? new List<Person>();

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
            _dataGrid.CellValueNeeded += DataGrid_CellValueNeeded;
            _dataGrid.ColumnHeaderMouseClick += DataGrid_ColumnHeaderMouseClick;

            ConfigureColumns();

            _dataGrid.RowCount = _population.Count;
            Controls.Add(_dataGrid);

            Load += (s, e) => ResizeFormToFitGrid();
        }

        private void DataGrid_CellValueNeeded(object? sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _population.Count)
            {
                Person person = _population[e.RowIndex];
                string columnName = _dataGrid.Columns[e.ColumnIndex].DataPropertyName;

                if (!_propertyCache.TryGetValue(columnName, out PropertyInfo? property))
                {
                    property = typeof(Person).GetProperty(columnName);
                    if (property != null)
                    {
                        _propertyCache[columnName] = property;
                    }
                }

                if (property != null)
                {
                    object? value = property.GetValue(person);
                    if (columnName == "Region" && value is KeyValuePair<string, int> region)
                    {
                        e.Value = region.Key;
                    }
                    else
                    {
                        e.Value = value;
                    }
                }
            }
        }

        private void DataGrid_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = _dataGrid.Columns[e.ColumnIndex].DataPropertyName;
            bool ascending = _dataGrid.Columns[e.ColumnIndex].Tag as bool? ?? true;
            _dataGrid.Columns[e.ColumnIndex].Tag = !ascending;

            PropertyInfo? property = typeof(Person).GetProperty(columnName);
            if (property != null)
            {
                _population.Sort((p1, p2) => Comparer<object>.Default.Compare(property.GetValue(p1), property.GetValue(p2)) * (ascending ? 1 : -1));
            }

            _dataGrid.Invalidate();
        }

        private void ConfigureColumns()
        {
            _dataGrid.AutoGenerateColumns = false;
            (string PropertyName, string HeaderText)[] _columns = new (string PropertyName, string HeaderText)[]
            {
                    ("ID", "Person ID"),
                    ("Gender", "Gender"),
                    ("Generation", "Generation"),
                    ("Region", "Region"),
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

        public void RefreshPersonList()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshPersonList));
                return;
            }
            _dataGrid.RowCount = _population.Count;
            _dataGrid.Invalidate();
            _dataGrid.Refresh();
            ResizeFormToFitGrid();
        }

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
                    else
                    {
                        MessageBox.Show("Parent not found in population.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Person person = _population[e.RowIndex];
                ChromosomePainterForm painter = new ChromosomePainterForm(person);
                painter.Show();
            }
        }

        private void ResizeFormToFitGrid()
        {
            int totalColumnWidth = _dataGrid.Columns.Cast<DataGridViewColumn>().Sum(c => c.Width);
            int formPadding = 20;
            int minHeight = 300;
            ClientSize = new Size(totalColumnWidth + formPadding, Math.Max(minHeight, ClientSize.Height));
        }

        private void TableDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();
        }
    }
}
