using System;
using System.Collections.Generic;

// The System.Linq namespace provides classes and interfaces that support 
// queries that use Language-Integrated Query (LINQ).
using System.Linq;

namespace GenticAlgorithm
{
    class Population
    {
        int populationSize = 20;
        float fitnessPercentage = 0.2f;
        List<Organism> organisms = new List<Organism>();

        // Population constructor       
        public Population(int size = 10, float percent = 0.2f)
        {
            Console.WriteLine("Generating a population of size " + size + ".");

            // Generate a population of organisms given a population size
            for (int i = 0; i < size; i++)
            {
                organisms.Add(new Organism());
            }
            populationSize = size;
            fitnessPercentage = percent;
        }

        // Ages a population according to the number of generations
        public void age(int generations)
        {
            Console.WriteLine("Agining population " + generations + " generatons.");

            // Generate through successive generations
            for (int i = 1; i <= generations; i++)
            {
                Console.WriteLine("Population age: " + i);
                this.getFittest();
            }
        }

        // Return an array containing a percent of the fittest individuals
        // from the population
        protected void getFittest()
        {
            // Use fitnessPercentage to determine number of organisms to 
            // return as being the fittest
            double fittestCount = Math.Ceiling(populationSize * fitnessPercentage);
            Console.WriteLine("Calculating the fittest " + (fitnessPercentage * 100) + "% of the population.");

            // Determine the fitness of each organism
            organisms.ForEach(o => o.DetermineFitness());

            // Sort organisms based on object values using LINQ
            // Here we use the list OrderBy method to sort the list
            Console.WriteLine("Sorting the population by fittest.");
            List<Organism> sortedOrganisms = organisms.OrderByDescending(o => o.getFitness()).ToList();

            // Select the top n fittest determined by fittest count
            Console.WriteLine("Selecting the top " + fittestCount + " organisms from the population");
            Console.WriteLine("Done"); // testing

        }
    }
}