using System;
using System.Collections.Generic;

// The System.Linq namespace provides classes and interfaces that support 
// queries that use Language-Integrated Query (LINQ).
using System.Linq;

namespace GenticAlgorithm
{
    class Population
    {
        int populationSize = 10;
        float fitnessPercentage = 0.05f;
        List<Organism> organisms = new List<Organism>();

        // Population constructor       
        public Population(int size = 10, float percent = 0.05f)
        {
            Console.WriteLine("Generating a population of size " + size + ".");

            // Generate a population of organisms given a population size
            for (int i = 0; i < size; i++)
            {
                organisms.Add(new Organism());
            }
            fitnessPercentage = percent;
        }

        // Ages a population according to an epoch
        // Each epoch will produce a new generation of organisms 
        public void age(int epoch)
        {
            Console.WriteLine("Agining population " + epoch + " generatons.");

            // Generate through successive generations
            for (int i = 1; i <= epoch; i++)
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
            Console.WriteLine("Done"); // testing

        }
    }
}