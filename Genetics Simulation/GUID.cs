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

        public static string GenerateGUID(string prefix, int length)
        {
            string newGUID;
            int attempts = 0;

            do
            {
                newGUID = $"{prefix}-{Guid.NewGuid().ToString("N").Substring(0, length).ToUpper()}";
                attempts++;
                if (attempts > 1000) throw new Exception($"GUID generation failed after 1000 attempts for prefix {prefix}.");
            } while (_usedGUIDs.Contains(newGUID));

            _usedGUIDs.Add(newGUID);
            return newGUID;
        }

        public static string GenerateHexColor()
        {
            string hexColor;
            int attempts = 0;

            do
            {
                int r = Simulation.Random.Next(0, 255);
                int g = Simulation.Random.Next(0, 255);
                int b = Simulation.Random.Next(0, 255);
                hexColor = $"#{r:X2}{g:X2}{b:X2}";
                attempts++;
                if (attempts > 1000) throw new Exception($"Color generation failed after 1000 attempts for color {hexColor}.");
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
