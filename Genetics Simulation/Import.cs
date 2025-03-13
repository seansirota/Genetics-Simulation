using System.Text.Json;

namespace Genetics_Simulation
{
    // Import class to import population data from a JSON file.
    public static class Import
    {
        // This method imports population data from a JSON file, ensuring unique gene references.
        public static async Task<List<Person>> ImportData(string filePath)
        {
            if (!File.Exists(filePath)) return new List<Person>();

            try
            {
                Dictionary<string, Gene> uniqueGenes = new Dictionary<string, Gene>();
                List<Person> importedPopulation = new List<Person>();

                using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                await foreach (Person? person in JsonSerializer.DeserializeAsyncEnumerable<Person>(fs, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    IncludeFields = true
                }))
                {
                    if (person != null)
                    {
                        foreach (Chromosome chromosome in person.Genome)
                        {
                            for (int i = 0; i < chromosome.MChromatid.Count; i++) chromosome.MChromatid[i] = GetOrCreateGene(chromosome.MChromatid[i], uniqueGenes);
                            for (int i = 0; i < chromosome.FChromatid.Count; i++) chromosome.FChromatid[i] = GetOrCreateGene(chromosome.FChromatid[i], uniqueGenes);
                        }

                        importedPopulation.Add(person);
                    }
                }

                return importedPopulation;
            }
            catch (Exception ex)
            {
                Simulation.Log($"Error importing population from JSON: {ex.Message}");
                return new List<Person>();
            }
        }

        // This method retrieves a gene object if it already exists or creates a new one.
        private static Gene GetOrCreateGene(Gene gene, Dictionary<string, Gene> uniqueGenes)
        {
            if (uniqueGenes.TryGetValue(gene.Trait, out Gene? existingGene)) return existingGene;
            else
            {
                uniqueGenes[gene.Trait] = gene;
                return gene;
            }
        }
    }
}
