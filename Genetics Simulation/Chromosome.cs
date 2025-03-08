using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    public class Chromosome
    {
        public string ID { get; set; }
        public bool RecombinationEvent { get; set; }
        public List<Gene> MChromatid = new List<Gene>();
        public List<Gene> FChromatid = new List<Gene>();
        public static int TotalMutations = 0;
        public static int TotalRecombinations = 0;
        public static readonly Dictionary<int, int> ChromosomeStructure = new Dictionary<int, int>
        {
            {1, 12 },
            {2, 10 },
            {3, 8 },
            {4, 6 },
            {5, 4 }
        };

        public Chromosome()
        {
            ID = string.Empty;
        }

        public Chromosome(int cPos, string hexColor)
        {
            ID = GUID.GenerateGUID("c", 16);
            GenerateGenes("Male", cPos, hexColor);
            GenerateGenes("Female", cPos, hexColor);
        }

        public Chromosome(List<Gene> mChromatid, List<Gene> fChromatid)
        {
            ID = GUID.GenerateGUID("c", 16);
            GenerateGenes("Male", mChromatid);
            GenerateGenes("Female", fChromatid);
            Recombination();
        }

        private void Recombination()
        {
            int recombinationThreshold = Simulation.Random.Next(1, 101);

            if (recombinationThreshold <= Simulation.RecombinationChance)
            {
                int recombinationPoint = Simulation.Random.Next(1, MChromatid.Count);
                int recombinationDirection = Simulation.Random.Next(1, 3);
                List<Gene> newMChromatid = new List<Gene>();
                List<Gene> newFChromatid = new List<Gene>();

                if (recombinationDirection == 1)
                {
                    for (int i = 0; i < recombinationPoint; i++)
                    {
                        newMChromatid.Add(new Gene(FChromatid[i]));
                        newFChromatid.Add(new Gene(MChromatid[i]));
                    }

                    for (int i = recombinationPoint; i < MChromatid.Count; i++)
                    {
                        newMChromatid.Add(new Gene(MChromatid[i]));
                        newFChromatid.Add(new Gene(FChromatid[i]));
                    }
                }
                else
                {
                    for (int i = MChromatid.Count - 1; i >= recombinationPoint; i--)
                    {
                        newMChromatid.Insert(0, new Gene(FChromatid[i]));
                        newFChromatid.Insert(0, new Gene(MChromatid[i]));
                    }

                    for (int i = recombinationPoint - 1; i >= 0; i--)
                    {
                        newMChromatid.Insert(0, new Gene(MChromatid[i]));
                        newFChromatid.Insert(0, new Gene(FChromatid[i]));
                    }
                }

                MChromatid = newMChromatid;
                FChromatid = newFChromatid;
                RecombinationEvent = true;
                Simulation.Log($"Recombination event occurred on chromosome {ID}!");
                TotalRecombinations++;
            }
        }

        private void GenerateGenes(string gender, int cPos, string hexColor)
        {
            Gene gene;

            for (int gPos = 0; gPos < ChromosomeStructure[cPos]; gPos++)
            {
                gene = new Gene(cPos, gPos + 1, hexColor);
                if (gender == "Male") MChromatid.Add(gene);
                else if (gender == "Female") FChromatid.Add(gene);
            }
        }

        private void GenerateGenes(string gender, List<Gene> chromatid)
        {
            Gene gene;
            int desirability;

            foreach (Gene g in chromatid)
            {
                int mutationThreshold = Simulation.Random.Next(1, 101);
                if (mutationThreshold <= Simulation.MutationChance)
                {
                    gene = new Gene(g.CPos, g.GPos, GUID.GenerateHexColor(Simulation.Random.Next(0, 255), Simulation.Random.Next(0, 255), Simulation.Random.Next(0, 255)));
                    
                    desirability = gene.Desirability + Simulation.Random.Next(0 - Simulation.MutationVarianceChance, 0 + Simulation.MutationVarianceChance);
                    if (desirability < 0) desirability = 0;
                    else if (desirability > 100) desirability = 100;

                    gene.Desirability = desirability;
                    gene.MutationEvent = true;
                    
                    Simulation.Log($"Mutation event occurred on gene {gene.ID}!");
                    TotalMutations++;
                }
                else gene = new Gene(g);
                if (gender == "Male") MChromatid.Add(gene);
                else if (gender == "Female") FChromatid.Add(gene);
            }
        }
    }
}
