namespace Genetics_Simulation
{
    // Test form to test the basic functionalities of the program.
    public partial class TestForm : Form
    {
        private readonly Random random = new Random();

        // Constructor for the test form. Creates a new person object and displays the person's information.
        public TestForm()
        {
            InitializeComponent();
            Person person = new Person(50, 1, new KeyValuePair<string, int>("r-00", 0));
            AppendColoredText("Person ID: " + person.ID + "\n", "#000000");
            AppendColoredText("Region ID: " + person.Region + "\n", "#000000");
            AppendColoredText("Gender: " + person.Gender + "\n", "#000000");
            AppendColoredText("Desirability: " + person.Desirability + "\n\n", "#000000");

            foreach (Chromosome chromosome in person.Genome)
            {
                AppendColoredText("Chromosome ID: " + chromosome.ID + "\n", "#000000");
                AppendColoredText("Male Chromatid\n", "#000000");

                foreach (Gene g in chromosome.MChromatid)
                {
                    string geneInfo = $"Trait ID: {g.Trait}, Chrom Pos: {g.CPos}, Gene Pos: {g.GPos}, Color: {g.HexColor}, Desirability: {g.Desirability}\n";
                    AppendColoredText(geneInfo, g.HexColor);
                }

                AppendColoredText("Female Chromatid\n", "#000000");
                foreach (Gene g in chromosome.FChromatid)
                {
                    string geneInfo = $"Trait ID: {g.Trait}, Chrom Pos: {g.CPos}, Gene Pos: {g.GPos}, Color: {g.HexColor}, Desirability: {g.Desirability}\n";
                    AppendColoredText(geneInfo, g.HexColor);
                }

                AppendColoredText("\n", "#000000");
            }
        }

        // Appends colored text to the rich text box.
        private void AppendColoredText(string text, string hexColor)
        {
            Color color = ColorTranslator.FromHtml(hexColor);
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text);
            richTextBox1.SelectionColor = Color.Black;
        }
    }
}
