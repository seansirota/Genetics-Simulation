# Genetics Simulation

## Overview

This project simulates genetic evolution over multiple generations. It models the process of reproduction, mutation, recombination, and emigration within a population. The simulation is highly configurable, allowing for various parameters to be adjusted to observe different evolutionary outcomes.

## Features

- **Initial Population Generation**: Generates an initial population with configurable size and characteristics.
- **Generational Simulation**: Simulates multiple generations, including breeding, mutation, and recombination events.
- **Region-Based Simulation**: Supports multiple regions with configurable desirability biases and emigration chances.
- **Inbreeding Control**: Configurable inbreeding rules to simulate different genetic diversity scenarios.
- **Logging**: Logs important events and statistics throughout the simulation.
- **JSON Export**: Optionally exports simulation data to JSON files.

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
2. **Run Simulation**: Call the `Simulation.RunSimulation()` method to start the simulation.
3. **Monitor Logs**: Observe the logs for real-time updates on the simulation progress.
4. **Export Data**: If enabled, check the JSON export path for simulation data.

## Example
## Requirements

- .NET 9
- C# 13.0

## License

This project is licensed under the MIT License.
