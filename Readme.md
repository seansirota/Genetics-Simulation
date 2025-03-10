# Genetics Simulation

## Overview

This project simulates genetic evolution over multiple generations. It models the process of reproduction, mutation, recombination, and emigration within a population. The simulation is highly configurable, allowing for various parameters to be adjusted to observe different evolutionary outcomes.

## Features

- **Configurable Parameters**: Adjust various parameters to observe different evolutionary outcomes.
- **Simulation Reproduction**: Models the process of reproduction and simulates chance events like gene mutations, chromosome recombinations, and emigrations between regions to allow occasional insemination of traits between physical distance boundaries.
- **Tabular Data Viewer**: Displays the population data in a tabular format for easy monitoring.
- **Chromosome Painter**: Visualizes the chromosomes of the population in a graphical format.
- **Logging**: Logs important events and statistics throughout the simulation.
- **Data Export**: Optionally exports simulation data and logs to a directory of your choosing.
- **Data Import**: You can also import previously completed simulation data and interact with it using this tool.

## Configuration Parameters

- `InitialPopulation`: The size of the initial population.
- `TotalGenerations`: The number of generations to simulate.
- `RecombinationChance`: The chance of recombination events during reproduction.
- `MutationChance`: The chance of mutation events during reproduction.
- `GenderRatio`: The ratio of males to females in the population.
- `TotalRegions`: The number of regions in the simulation.
- `EmigrationChance`: The chance of emigration events.
- `BiasVarianceChance`: The variance in regional desirability bias.
- `MinimumDesirability`: The minimum desirability threshold for breeding.
- `MaximumDesirability`: The maximum desirability threshold for breeding.
- `MinimumChildren`: The minimum number of children per breeding pair.
- `MaximumChildren`: The maximum number of children per breeding pair.
- `MutationVarianceChance`: The variance in mutation chance.
- `CrossRegionBreeding`: Whether breeding across regions is allowed.
- `SameGenderBreeding`: Whether same-gender breeding is allowed.
- `EnableJSONExport`: Whether to export simulation data to JSON.
- `JSONExportPath`: The path to export JSON files.
- `Inbreeding`: The level of inbreeding allowed.

## Usage

1. **Initialize Parameters**: Set the desired parameters for the simulation.
   - Set various parameters such as the initial population size, the number of generations to simulate, the chance of recombination and mutation events, and so on.
   - Set or release restrictions on the simulation, including enabling or disabling inbreeding, cross-region breeding, and same-gender breeding.
   - Configure minimum and maximum desirability thresholds, the number of potential children between parents, and regional/mutation desirability biases.
   - Optionally enable the export of population data as a JSON file and log data as a text file and set the export path.
2. **Run Simulation**: Click the "Run Simulation" button to start the simulation. The form remains accessible and can be interacted with while the simulation is running.
3. **Monitor Logs**: Observe the logs for real-time updates on the simulation progress.
4. **View Data**: Use the tabular data viewer to view the population data.
   - The table displays all the population data, with each row representing a person object. The table shows properties such as a person's generated number, ID, gender, generation, region, desirability, and father and mother IDs.
   - Double-click a cell in the row of a person object to view their chromosome data.
   - Double-clicking the Father ID or Mother ID cells for a particular person will display the chromosome data for the respective parent.
   - Clicking on the header of a column will sort the table based on that column, alternating between ascending and descending order.
   - A search bar is available to filter the data by Person ID based on the entered text.
5. **Visualize Chromosomes**: Use the chromosome painter to visualize the chromosomes of the population.
   - The chromosome painter displays the chromosomes of the population in a graphical format.
   - You can view a person's chromosome painter by double-clicking a cell in their row in the tabular data viewer.
   - The chromosome painter shows general properties for this person, including their ID, gender, generation, region, father ID, and mother ID.
   - Below the general properties, the chromosome painter displays the person's chromosome data in a graphical format. The chromosomes are represented as colored bars, with each color representing a different gene.
   - The color of the trait tells you which original person from the initial population the gene came from.
   - A different color from the rest of the genome can also indicate a mutation event.
   - In addition to the color, each gene in the chromosome shows its trait ID and the desirability of the gene.
6. **Data Import/Export**: This tool gives you the ability to interact with data in and outside of the application.
   - Enabling data export in the configuration form allows you to export simulation data to a directory of your choice.
   - During the simulation, logs are constantly being streamed to the directory you specified.
   - Once the simulation is completed, the population data is exported as a JSON file to the same directory.
   - You can also select the "Import Data" option from the menu to import previously completed simulation data.
   - The data export feature allows you to analyze the simulation data in more detail outside of the application.
   - The data import feature allows you to load previously generated data, whether by yourself or by someone else who used this application.

## Requirements

- .NET 9
- C# 13.0

## Credits
This application and the logo was designed by me, Sean Sirota. Any unauthorized use or credit of this application without my consent would be considered an act of plagiarism and theft.

© 2025 Sean Sirota