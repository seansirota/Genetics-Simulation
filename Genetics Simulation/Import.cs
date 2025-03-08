using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;

namespace Genetics_Simulation
{
    public static class Import
    {
        public static async Task<List<Person>> ImportData(string filePath)
        {
            if (!File.Exists(filePath)) return new List<Person>();

            try
            {
                string json = await File.ReadAllTextAsync(filePath);
                List<Person>? importedPopulation = JsonSerializer.Deserialize<List<Person>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    IncludeFields = true,
                    WriteIndented = true
                });

                return importedPopulation ?? new List<Person>();
            }
            catch (Exception ex)
            {
                Simulation.Log($"Error importing population from JSON: {ex.Message}");
                return new List<Person>();
            }
        }
    }
}
