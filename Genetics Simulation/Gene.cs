using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    public class Gene
    {
        public string ID { get; set; }
        public string Trait { get; set; }
        public int CPos { get; set; }
        public int GPos { get; set; }
        public string HexColor { get; set; }
        public int Desirability { get; set; }
        public bool MutationEvent { get; set; }

        public Gene()
        {
            ID = string.Empty;
            Trait = string.Empty;
            CPos = 0;
            GPos = 0;
            HexColor = string.Empty;
            Desirability = 0;
        }

        public Gene(int cPos, int gPos, string hexColor)
        {
            ID = GUID.GenerateGUID("g", 16);
            Trait = GUID.GenerateGUID("t", 6);
            CPos = cPos;
            GPos = gPos;
            HexColor = hexColor;
            Desirability = Simulation.Random.Next(Simulation.MinimumDesirability, Simulation.MaximumDesirability + 1);
        }

        public Gene(Gene g)
        {
            ID = GUID.GenerateGUID("g", 16);
            Trait = g.Trait;
            CPos = g.CPos;
            GPos = g.GPos;
            HexColor = g.HexColor;
            Desirability = g.Desirability;
        }
    }
}
