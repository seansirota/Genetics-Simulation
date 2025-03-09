using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    //This is the person class, which is the main object type and represents people with their own properties and genomes.
    public class Person
    {
        public static int PersonCount;
        public string ID { get; set; }
        public int Number { get; set; }
        public string Gender { get; set; }
        public KeyValuePair<string, int> Region { get; set; }
        public string HexColor { get; set; }
        public int Desirability { get; set; }
        public int Generation { get; set; }
        public string FatherID { get; set; }
        public string MotherID { get; set; }
        public bool EmigrationEvent { get; set; }
        public List<Chromosome> Genome = new List<Chromosome>();

        //Default constructor for the person class. Initializes the properties to default values.
        public Person()
        {
            ID = string.Empty;
            Gender = string.Empty;
            Region = new KeyValuePair<string, int>();
            HexColor = string.Empty;
            Desirability = 0;
            Generation = 0;
            FatherID = string.Empty;
            MotherID = string.Empty;
        }

        //Constructor for a person object used during the initial population generation.
        public Person(int genderRatio, int generation, KeyValuePair<string, int> region)
        {
            ID = GUID.GenerateGUID("p", 16);
            Number = ++PersonCount;
            Region = region;
            HexColor = GUID.GenerateHexColor();
            GenerateGenome(HexColor);
            Desirability = CalculateDesirability(region.Value);
            Generation = generation;

            int genderRoll = Simulation.Random.Next(1, 101);
            if (genderRoll <= genderRatio) Gender = "Male";
            else if (genderRoll > genderRatio) Gender = "Female";
            else Gender = string.Empty;

            FatherID = "None";
            MotherID = "None";
        }

        //Constructor for a person object used during the reproduction process.
        public Person(List<Chromosome> childGenome, string parent1ID, string parent2ID, int generation, int genderRatio, KeyValuePair<string, int> region)
        {
            Genome = childGenome;
            ID = GUID.GenerateGUID("p", 16);
            Number = ++PersonCount;
            Region = region;
            HexColor = "None";
            Desirability = CalculateDesirability(region.Value);
            Generation = generation;

            int genderRoll = Simulation.Random.Next(1, 101);
            if (genderRoll <= genderRatio) Gender = "Male";
            else if (genderRoll > genderRatio) Gender = "Female";
            else Gender = string.Empty;

            FatherID = parent1ID;
            MotherID = parent2ID;
        }

        //Generates the genome for a person object based on a hex color string. Used only for the initial population generation.
        private void GenerateGenome(string hexColor)
        {
            Chromosome chromosome;

            for (int cPos = Chromosome.ChromosomeStructure.Keys.First(); cPos <= Chromosome.ChromosomeStructure.Keys.LastOrDefault(); cPos++)
            {
                chromosome = new Chromosome(cPos, hexColor);
                Genome.Add(chromosome);
            }
        }

        //Calculates the desirability of a person object and is influenced by the regional desirability bias.
        private int CalculateDesirability(int desirabilityBias)
        {
            double totalDesirability = 0;
            int totalGenes = 0;
            int desirability = 0;

            foreach (Chromosome chromosome in Genome)
            {
                foreach (Gene gene in chromosome.MChromatid)
                {
                    totalDesirability += gene.Desirability;
                    totalGenes++;
                }

                foreach (Gene gene in chromosome.FChromatid)
                {
                    totalDesirability += gene.Desirability;
                    totalGenes++;
                }
            }

            desirability = (int)Math.Round(totalDesirability / totalGenes) + desirabilityBias;
            if (desirability < 0) desirability = 0;
            else if (desirability > 100) desirability = 100;

            return desirability;
        }
    }
}
