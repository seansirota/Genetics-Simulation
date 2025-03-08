using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetics_Simulation
{
    public partial class ChromosomePainterForm: Form
    {
        public ChromosomePainterForm()
        {
            InitializeComponent();

            Person person = new Person(50, 1, new KeyValuePair<string, int>("r-00", 0), Simulation.Random.Next(0, 255), Simulation.Random.Next(0, 255), Simulation.Random.Next(0, 255));
            ChromosomePainterPanel painter = new ChromosomePainterPanel(person);

            ClientSize = painter.GetRequiredSize();
            painter.Dock = DockStyle.Fill;
            painter.AutoScroll = true;
            Controls.Add(painter);
        }

        public ChromosomePainterForm(Person person)
        {
            InitializeComponent();
            ChromosomePainterPanel painter = new ChromosomePainterPanel(person);
            ClientSize = painter.GetRequiredSize();
            painter.Dock = DockStyle.Fill;
            painter.AutoScroll = true;
            Controls.Add(painter);
        }

        private void ChromosomePainterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();
        }
    }

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

        public ChromosomePainterPanel()
        {
            _person = new Person();
            _chromosomes = new List<Chromosome>();
            DoubleBuffered = true;
            AutoScroll = true;
        }

        public ChromosomePainterPanel(Person person)
        {
            _person = person;
            _chromosomes = person.Genome;
            DoubleBuffered = true;
            AutoScroll = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawChromosomes(e.Graphics);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            Invalidate();
        }

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

        private void DrawGene(Gene gene, int x, int y, Graphics g)
        {
            Color geneColor = ColorTranslator.FromHtml(gene.HexColor);
            Brush geneBrush = new SolidBrush(geneColor);
            Brush textBrush = Brushes.White;
            Font font = new Font("Arial", 9, FontStyle.Bold);

            g.FillRectangle(geneBrush, x, y, _geneWidth, _geneHeight);
            g.DrawRectangle(Pens.Black, x, y, _geneWidth, _geneHeight);

            string text = gene.Trait;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    g.DrawString(text, font, Brushes.Black, x + 8 + dx, y + 14 + dy);
                }
            }

            g.DrawString(text, font, textBrush, x + 8, y + 14);
        }

        private Size CalculateRequiredSize()
        {
            int maxGenesPerChromosome = _chromosomes.Max(c => Math.Max(c.MChromatid.Count, c.FChromatid.Count));
            int requiredWidth = _startX + (maxGenesPerChromosome * (_geneWidth + _geneSpacing)) + _startX;
            int requiredHeight = (_chromosomes.Count * (_geneHeight * 2 + _chromatidSpacing + _chromosomeSpacing));

            requiredWidth = Math.Max(requiredWidth, 300);
            requiredHeight = Math.Max(requiredHeight, 300);

            return new Size(requiredWidth, requiredHeight);
        }

        public Size GetRequiredSize()
        {
            return CalculateRequiredSize();
        }
    }
}
