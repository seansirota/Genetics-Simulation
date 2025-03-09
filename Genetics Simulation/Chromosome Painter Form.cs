using System.Data;

namespace Genetics_Simulation
{
    //The Chromosome Painter Form is a class for the form to display the chromosomes of a person object. It displays some general info for the person at the top as well as showing each chromosome by the gene.
    public partial class ChromosomePainterForm: Form
    {
        //Constructor for the Chromosome Painter Form. Creates a new person object with default values and displays the chromosomes.
        public ChromosomePainterForm()
        {
            InitializeComponent();

            Person person = new Person(50, 1, new KeyValuePair<string, int>("r-00", 0));
            ChromosomePainterPanel painter = new ChromosomePainterPanel(person);

            ClientSize = painter.GetRequiredSize();
            painter.Dock = DockStyle.Fill;
            painter.AutoScroll = true;
            Controls.Add(painter);
        }

        //Constructor for the Chromosome Painter Form. Creates a new person object with the given person object and displays the chromosomes. This gets accessed from the table form.
        public ChromosomePainterForm(Person person)
        {
            InitializeComponent();
            ChromosomePainterPanel painter = new ChromosomePainterPanel(person);
            ClientSize = painter.GetRequiredSize();
            painter.Dock = DockStyle.Fill;
            painter.AutoScroll = true;
            Controls.Add(painter);
        }

        //Event handler for when the form is closed. Disposes of the form.
        private void ChromosomePainterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();
        }
    }

    //This is the class that draws the chromosomes of a person object. It is a panel that displays the chromosomes by gene.
    public class ChromosomePainterPanel : Panel
    {
        private Person _person;
        private List<Chromosome> _chromosomes;
        private int _startX = 20;
        private int _startY = 20;
        private int _geneWidth = 72;
        private int _geneHeight = 42;
        private int _geneSpacing = 5;
        private int _chromatidSpacing = 5;
        private int _chromosomeSpacing = 30;

        //Default constructor for the Chromosome Painter Panel. Unused but creates a blank new person object.
        public ChromosomePainterPanel()
        {
            _person = new Person();
            _chromosomes = new List<Chromosome>();
            DoubleBuffered = true;
            AutoScroll = true;
        }

        //Used by the application to create a new Chromosome Painter Panel with the given person object.
        public ChromosomePainterPanel(Person person)
        {
            _person = person;
            _chromosomes = person.Genome;
            DoubleBuffered = true;
            AutoScroll = true;
        }

        //Draws the chromosomes on the panel.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawChromosomes(e.Graphics);
        }

        //Event handler for when the panel is scrolled. Invalidates the panel to redraw the chromosomes.
        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            Invalidate();
        }

        //Draws the chromosomes and genes dynamically given their properties.
        private void DrawChromosomes(Graphics g)
        {
            int startY = _startY;
            int x = _startX;
            int y = startY;

            g.DrawString($"Person {_person.ID}, {_person.Gender}, Generation {_person.Generation}, {_person.Region.Key}, Father: {_person.FatherID}, Mother: {_person.MotherID}", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, x, y - 20);

            foreach (Chromosome chromosome in _chromosomes)
            {
                x = _startX;

                g.DrawString($"Chromosome {chromosome.ID}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, x, y);

                y += 20;

                foreach (Gene gene in chromosome.MChromatid.OrderBy(gene => gene.GPos))
                {
                    DrawGene(gene, x, y, g);
                    x += _geneWidth + _geneSpacing;
                }

                x = _startX;
                y += _geneHeight + _chromatidSpacing;

                foreach (Gene gene in chromosome.FChromatid.OrderBy(gene => gene.GPos))
                {
                    DrawGene(gene, x, y, g);
                    x += _geneWidth + _geneSpacing;
                }

                y += _geneHeight + _chromatidSpacing;
            }
        }

        //Draws individual genes on the panel. Displays the gene color, trait ID, and desirability.
        private void DrawGene(Gene gene, int x, int y, Graphics g)
        {
            Color geneColor = ColorTranslator.FromHtml(gene.HexColor);
            Brush geneBrush = new SolidBrush(geneColor);
            Brush textBrush = Brushes.White;
            Font font = new Font("Arial", 9, FontStyle.Bold);

            g.FillRectangle(geneBrush, x, y, _geneWidth, _geneHeight);
            g.DrawRectangle(Pens.Black, x, y, _geneWidth, _geneHeight);

            string trait = gene.Trait;
            string desirability = gene.Desirability.ToString();

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    g.DrawString(trait, font, Brushes.Black, x + 8 + dx, y + 6 + dy);
                    g.DrawString(desirability, font, Brushes.Black, x + 28 + dx, y + 22 + dy);
                }
            }

            g.DrawString(trait, font, textBrush, x + 8, y + 6);
            g.DrawString(desirability, font, textBrush, x + 28, y + 22);
        }

        //Calculates the required size of the panel based on the number of chromosomes and genes.
        private Size CalculateRequiredSize()
        {
            int maxGenesPerChromosome = _chromosomes.Max(c => Math.Max(c.MChromatid.Count, c.FChromatid.Count));
            int requiredWidth = _startX + (maxGenesPerChromosome * (_geneWidth + _geneSpacing)) + _startX;
            int requiredHeight = (_chromosomes.Count * (_geneHeight * 2 + _chromatidSpacing + _chromosomeSpacing));

            requiredWidth = Math.Max(requiredWidth, 300);
            requiredHeight = Math.Max(requiredHeight, 300);

            return new Size(requiredWidth, requiredHeight);
        }

        //Returns the required size of the panel. Public method used to set the size of the panel.
        public Size GetRequiredSize()
        {
            return CalculateRequiredSize();
        }
    }
}
