using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    static public class Simulation
    {
        private static readonly int _initialPopulationDefault = 100;
        private static readonly int _totalGenerationsDefault = 5;
        private static readonly int _recombinationChanceDefault = 25;
        private static readonly int _mutationChanceDefault = 1;
        private static readonly int _genderRatioDefault = 50;
        private static readonly int _totalRegionsDefault = 2;
        private static readonly int _emigrationChanceDefault = 5;
        private static readonly int _biasVarianceChanceDefault = 0;
        private static readonly int _minimumDesirabilityDefault = 60;
        private static readonly int _maximumDesirabilityDefault = 100;
        private static readonly int _minimumChildrenDefault = 1;
        private static readonly int _maximumChildrenDefault = 5;
        private static readonly int _mutationVarianceChanceDefault = 0;
        private static readonly bool _crossRegionBreedingDefault = false;
        private static readonly bool _sameGenderBreedingDefault = false;
        private static readonly bool _enableJSONExportDefault = false;
        private static readonly string _jsonExportPath = string.Concat(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents"), "\\Genetics Simulation\\");
        private static readonly List<string> _enableInbreedingDefault = new List<string> { "No", "Up to cousins", "Up to siblings" };
        private static int _currentGeneration = 0;
        private static List<Person> _remainingPopulation = new List<Person>();

        public static event Action<string>? OnLogEvent;
        public static readonly Random Random = new Random();
        public static List<Person> Population = new List<Person>();
        public static Dictionary<string, int> RegionList = new Dictionary<string, int>();
        public static int TotalEmigrations;
        public static int InitialPopulation { get; set; }
        public static int TotalGenerations { get; set; }
        public static int RecombinationChance { get; set; }
        public static int MutationChance { get; set; }
        public static int GenderRatio { get; set; }
        public static int TotalRegions { get; set; }
        public static int EmigrationChance { get; set; }
        public static int BiasVarianceChance { get; set; }
        public static int MinimumDesirability { get; set; }
        public static int MaximumDesirability { get; set; }
        public static int MinimumChildren { get; set; }
        public static int MaximumChildren { get; set; }
        public static int MutationVarianceChance { get; set; }
        public static bool CrossRegionBreeding { get; set; }
        public static bool SameGenderBreeding { get; set; }
        public static bool EnableJSONExport { get; set; }
        public static string? JSONExportPath { get; set; }
        public static string? Inbreeding { get; set; }
        public static string? SimulationName { get; set; }

        public static void RunSimulation()
        {
            SimulationName = GUID.GenerateGUID(string.Empty, 8);
            Log($"Simulation{SimulationName} started.");
            GenerateInitialRound();
            Log("Initial population generated.");
            _remainingPopulation = new List<Person>(Population);

            for (; _currentGeneration < TotalGenerations; _currentGeneration++)
            {
                if (_remainingPopulation.Count(p => p.Generation == _currentGeneration) <= 1) break;
                Log($"Generation {_currentGeneration + 1} started.");
                while (_remainingPopulation.Count > 0)
                {
                    BreedNewPerson(_currentGeneration);
                }

                Log($"Generation {_currentGeneration + 1} completed.");
                _remainingPopulation = new List<Person>(Population);
            }

            Log($"Simulation{SimulationName} completed.");
            Log("Total population: " + Population.Count + ".");
            Log("Total generations: " + TotalGenerations + ".");
            Log("Total mutations: " + Chromosome.TotalMutations + ".");
            Log("Total recombinations: " + Chromosome.TotalRecombinations + ".");
            Log("Total emigrations: " + TotalEmigrations + ".");
        }

        private static void GenerateInitialRound()
        {
            KeyValuePair<string, int> region;
            string regionID;
            _currentGeneration = 1;

            for (int i = 0; i < TotalRegions; i++)
            {
                do
                {
                    regionID = GUID.GenerateGUID("r", 2);
                } while (RegionList.ContainsKey(regionID));

                RegionList.Add(regionID, Random.Next(0 - BiasVarianceChance, 0 + BiasVarianceChance + 1));
            }

            for (int i = 0; i < InitialPopulation; i++)
            {
                region = RegionList.ElementAt(Random.Next(0, TotalRegions));

                Person person = new Person(GenderRatio, _currentGeneration, region);
                Population.Add(person);
                Log($"Person #{person.Number} {person.ID} generated. Generation: {person.Generation}, Gender: {person.Gender}, Region: {person.Region.Key}, Desirability: {person.Desirability}.");
            }
        }

        private static void BreedNewPerson(int generation)
        {
            Person? person1;
            Person? person2;
            List<Person> children;
            Tuple<Person?, List<Person>> removePersons;
            List<Person> totalRemovePersons = new List<Person>();

            _remainingPopulation = _remainingPopulation.Where(p => p.Generation == generation).ToList();
            List<Person> originalPopulation = new List<Person>(_remainingPopulation);

            removePersons = ChooseValidPerson();
            person1 = removePersons.Item1;
            totalRemovePersons.AddRange(removePersons.Item2);

            if (person1 == null)
            {
                RemovePersons(originalPopulation, totalRemovePersons);
                return;
            }

            _remainingPopulation = _remainingPopulation.Where(p => p.ID != person1.ID).ToList();
            if (!SameGenderBreeding) _remainingPopulation = _remainingPopulation.Where(p => p.Gender != person1.Gender).ToList();
            if (!CrossRegionBreeding) _remainingPopulation = _remainingPopulation.Where(p => p.Region.Key == person1.Region.Key).ToList();
            if (Inbreeding == "No" && generation > 1) _remainingPopulation = _remainingPopulation.Where(p => p.FatherID != person1.ID && p.MotherID != person1.ID).ToList();
            if ((Inbreeding == "No" || Inbreeding == "Up to siblings") && generation > 1) _remainingPopulation = _remainingPopulation.Where(p => p.FatherID != person1.FatherID || p.MotherID != person1.MotherID).ToList();

            removePersons = ChooseValidPerson();
            person2 = removePersons.Item1;
            totalRemovePersons.AddRange(removePersons.Item2);

            if (person2 == null)
            {
                originalPopulation.Remove(person1);
                RemovePersons(originalPopulation, totalRemovePersons);
                return;
            }

            children = CombineGenomes(person1, person2, generation);

            foreach (Person child in children)
            {
                Population.Add(child);
            }

            originalPopulation.Remove(person1);
            originalPopulation.Remove(person2);

            RemovePersons(originalPopulation, totalRemovePersons);
        }

        private static void RemovePersons(List<Person> originalPopulation, List<Person> totalRemovePersons)
        {
            if (originalPopulation.Count > 1)
            {
                foreach (Person removePerson in totalRemovePersons)
                {
                    originalPopulation.Remove(removePerson);
                }
            }
            else originalPopulation.Clear();

            _remainingPopulation = new List<Person>(originalPopulation);
        }

        private static List<Person> CombineGenomes(Person person1, Person person2, int generation)
        {
            KeyValuePair<string, int> region = new KeyValuePair<string, int>();
            bool emigrationEvent = false;
            Tuple<KeyValuePair<string, int> , bool> regionResult;
            int maleChromatidIndex;
            int femaleChromatidIndex;
            int totalChildren = Random.Next(MinimumChildren, MaximumChildren + 1);
            List<Gene> maleChromatid;
            List<Gene> femaleChromatid;
            Chromosome fatherChromosome;
            Chromosome motherChromosome;
            Chromosome childChromosome;
            List<Person> children = new List<Person>();
            Person child;
            Tuple<Person, Person> parents;

            for (int i = 0; i < totalChildren; i++)
            {
                List<Chromosome> childGenome = new List<Chromosome>();
                parents = GetParents(person1, person2);
                regionResult = GetRegion(person1, person2);
                region = regionResult.Item1;
                emigrationEvent = regionResult.Item2;

                foreach (KeyValuePair<int, int> chromosomeNumber in Chromosome.ChromosomeStructure)
                {
                    maleChromatidIndex = Random.Next(0, 2);
                    femaleChromatidIndex = Random.Next(0, 2);

                    fatherChromosome = person1.Genome[chromosomeNumber.Key - 1];
                    motherChromosome = person2.Genome[chromosomeNumber.Key - 1];

                    if (maleChromatidIndex == 0) maleChromatid = fatherChromosome.MChromatid;
                    else maleChromatid = fatherChromosome.FChromatid;

                    if (femaleChromatidIndex == 0) femaleChromatid = motherChromosome.MChromatid;
                    else femaleChromatid = motherChromosome.FChromatid;

                    childChromosome = new Chromosome(new List<Gene>(maleChromatid), new List<Gene>(femaleChromatid));
                    childGenome.Add(childChromosome);
                }

                child = new Person(childGenome, parents.Item1.ID, parents.Item2.ID, generation + 1, GenderRatio, region);
                child.EmigrationEvent = emigrationEvent;
                if (emigrationEvent) Log($"Emigration event occurred by Person {child.ID} to Region {region.Key}!");
                Log($"Person #{child.Number} {child.ID} generated. Generation: {child.Generation}, Gender: {child.Gender}, Region: {child.Region.Key}, Desirability: {child.Desirability}.");
                children.Add(child);
            }
            
            return children;
        }

        private static Tuple<KeyValuePair<string, int>, bool> GetRegion(Person person1, Person person2)
        {
            int emigrationThreshold = Random.Next(1, 101);
            bool EmigrationEvent = false;
            string randomRegionKey;

            if (emigrationThreshold <= EmigrationChance && TotalRegions > 1)
            {
                if (CrossRegionBreeding && TotalRegions == 2) return Tuple.Create(Random.Next(0, 101) < 50 ? person1.Region : person2.Region, EmigrationEvent);
                do
                {
                    randomRegionKey = RegionList.ElementAt(Random.Next(0, TotalRegions)).Key;
                } while (randomRegionKey == person1.Region.Key || randomRegionKey == person2.Region.Key);

                EmigrationEvent = true;
                TotalEmigrations++;
                return Tuple.Create(new KeyValuePair<string, int>(randomRegionKey, RegionList[randomRegionKey]), EmigrationEvent);
            }

            return Tuple.Create(Random.Next(0, 101) < 50 ? person1.Region : person2.Region, EmigrationEvent);
        }


        private static Tuple<Person, Person> GetParents(Person person1, Person person2)
        {
            if (person1.Gender == "Male" && person2.Gender == "Female") return Tuple.Create(person1, person2);
            else if (person1.Gender == "Female" && person2.Gender == "Male") return Tuple.Create(person2, person1);
            else return Tuple.Create(person1, person2);
        }

        private static Tuple<Person?, List<Person>> ChooseValidPerson()
        {
            int desirabilityThreshold;
            int randomPersonIndex;
            Person? randomPerson = null;
            List<Person> removePersons = new List<Person>();
            bool personChosen = false;

            while (!personChosen)
            {
                if (_remainingPopulation.Count > 0)
                {
                    desirabilityThreshold = Random.Next(1, 101);
                    randomPersonIndex = Random.Next(0, _remainingPopulation.Count);
                    randomPerson = _remainingPopulation[randomPersonIndex];

                    if (desirabilityThreshold <= randomPerson.Desirability) personChosen = true;
                    else
                    {
                        removePersons.Add(randomPerson);
                        _remainingPopulation.Remove(randomPerson);
                    }
                }
                else return Tuple.Create<Person?, List<Person>>(null, removePersons);
            }

            return Tuple.Create(randomPerson, removePersons);
        }

        public static void Log(string message)
        {
            OnLogEvent?.Invoke($"{DateTime.Now}: {message}");
        }

        public static int GetInitialPopulationDefault()
        {
            return _initialPopulationDefault;
        }

        public static int GetTotalGenerationsDefault()
        {
            return _totalGenerationsDefault;
        }

        public static int GetRecombinationChanceDefault()
        {
            return _recombinationChanceDefault;
        }

        public static int GetMutationChanceDefault()
        {
            return _mutationChanceDefault;
        }

        public static int GetGenderRatioDefault()
        {
            return _genderRatioDefault;
        }

        public static List<string> GetEnableInbreedingDefault()
        {
            return _enableInbreedingDefault;
        }

        public static int GetTotalRegionsDefault()
        {
            return _totalRegionsDefault;
        }

        public static int GetEmigrationChanceDefault()
        {
            return _emigrationChanceDefault;
        }

        public static int GetBiasVarianceChanceDefault()
        {
            return _biasVarianceChanceDefault;
        }

        public static bool GetCrossRegionBreedingDefault()
        {
            return _crossRegionBreedingDefault;
        }

        public static bool GetSameGenderBreedingDefault()
        {
            return _sameGenderBreedingDefault;
        }

        public static int GetMinimumDesirabilityDefault()
        {
            return _minimumDesirabilityDefault;
        }

        public static int GetMaximumDesirabilityDefault()
        {
            return _maximumDesirabilityDefault;
        }

        public static int GetMinimumChildrenDefault()
        {
            return _minimumChildrenDefault;
        }

        public static int GetMaximumChildrenDefault()
        {
            return _maximumChildrenDefault;
        }

        public static int GetMutationVarianceChanceDefault()
        {
            return _mutationVarianceChanceDefault;
        }

        public static bool GetEnableJSONExportDefault()
        {
            return _enableJSONExportDefault;
        }

        public static string GetJSONExportPathDefault()
        {
            return _jsonExportPath;
        }
    }
}