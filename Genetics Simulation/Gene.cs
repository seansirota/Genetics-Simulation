using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    //The gene class which is the most foundation unit of genetic information in the simulation. Each gene contains a trait, a chromosome position, a gene position, a hex color, and a desirability value.
    public class Gene
    {
        public string Trait { get; set; }
        public int CPos { get; set; }
        public int GPos { get; set; }
        public string HexColor { get; set; }
        public int Desirability { get; set; }
        public bool MutationEvent { get; set; }

        //Unused default constructor for the gene class.
        public Gene()
        {
            Trait = string.Empty;
            CPos = 0;
            GPos = 0;
            HexColor = string.Empty;
            Desirability = 0;
        }

        //Constructor for the gene class used during the initial population generation. Generates a gene based on the chromosome position, gene position, and a hex color string.
        public Gene(int cPos, int gPos, string hexColor)
        {
            Trait = GUID.GenerateGUID("t", 6);
            CPos = cPos;
            GPos = gPos;
            HexColor = hexColor;
            Desirability = Simulation.Random.Next(Simulation.MinimumDesirability, Simulation.MaximumDesirability + 1);
        }

        //Constructor for the gene class used during the reproduction process. Generates a gene based on an existing gene object.
        public Gene(Gene g)
        {
            Trait = g.Trait;
            CPos = g.CPos;
            GPos = g.GPos;
            HexColor = g.HexColor;
            Desirability = g.Desirability;
        }
    }
}
