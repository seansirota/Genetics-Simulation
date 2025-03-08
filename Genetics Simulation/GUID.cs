using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    public class GUID
    {
        private static HashSet<string> _usedGUIDs = new HashSet<string>();
        private static List<string> _usedColors = new List<string>();
        private static readonly int _colorVariation = 0;

        public static string GenerateGUID(string prefix, int length)
        {
            string newGUID;

            do
            {
                newGUID = $"{prefix}-{Guid.NewGuid().ToString("N").Substring(0, length).ToUpper()}";
            } while (_usedGUIDs.Contains(newGUID));

            _usedGUIDs.Add(newGUID);
            return newGUID;
        }

        public static string GenerateHexColor(int rMid, int gMid, int bMid)
        {
            string hexColor;

            do
            {
                int r = Math.Clamp(Simulation.Random.Next(rMid - _colorVariation, rMid + _colorVariation + 1), 0, 255);
                int g = Math.Clamp(Simulation.Random.Next(gMid - _colorVariation, gMid + _colorVariation + 1), 0, 255);
                int b = Math.Clamp(Simulation.Random.Next(bMid - _colorVariation, bMid + _colorVariation + 1), 0, 255);
                hexColor = $"#{r:X2}{g:X2}{b:X2}";
            } while (_usedColors.Contains(hexColor));

            _usedColors.Add(hexColor);
            return hexColor;
        }

        public static void ClearUsedGUIDs()
        {
            _usedGUIDs.Clear();
            _usedColors.Clear();
        }
    }
}
