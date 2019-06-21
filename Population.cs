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
                // Display the population age (in generations)
                Console.WriteLine("Population age: " + i);

                // Get the fittest organisms from the population
                List<Organism> fittestOrganisms = this.getFittest();

                // Generate a new population by having the organisms mate
                List<Organism> crossoverOrganisms = this.crossover(fittestOrganisms);

                // Apply a random genetic mutation to the organisms
                List<Organism> mutatedOrganisms = this.mutation(crossoverOrganisms);

                // Replace the old generation with the new one
                // TODO Experiment with how much of the generation to replace
                this.organisms = crossoverOrganisms;
            }
        }

        // Return an array containing a percent of the fittest individuals
        // from the population
        // TODO Explore making this method a delegate so that we can have a 
        // dynamic fitness method that can be passed in
        protected List<Organism> getFittest()
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
            List<Organism> sortedOrganisms = organisms.OrderByDescending(o => o.fitness).ToList();

            // Select the top n fittest determined by fittest count by iterating
            // over the sorted list of organisms and adding them to a new list
            Console.WriteLine("Selecting the top " + fittestCount + " organisms from the population");
            List<Organism> fittestOrganisms = new List<Organism>();
            for (int i = 0; i < fittestCount; i++)
            {
                fittestOrganisms.Add(sortedOrganisms[i]);
            }

            return fittestOrganisms;
        }

        // Mate pairs of the fittest organisms to produce a new population
        // We can experiment with more advanced cross over patterns in the future
        // but for now lets start with simply taking half from both organisms
        protected List<Organism> crossover(List<Organism> organisms)
        {
            Console.WriteLine("Mating selected organisms.");

            // We need an even number of organisms for mating
            // Duplicate the first organsism to the end of the list if there
            // are an even number of organisms
            if (organisms.Count % 2 != 0)
            {
                organisms.Add(organisms[0]);
            }

            // Define our new list of mated organisms to return
            List<Organism> crossoverOrganisms = new List<Organism>();

            // Iterate over our list of organsisms, mate them, and add the 
            // new offspring to the crossover list of organisms
           

            // Take the organisms count before iterating over organisms 
            // because the count of organisms will be modified within the loop
            int organismCount = organisms.Count;

            // Iterate over pairs of organisms and mate them
            // After they have been mated, replace the parents with the 
            // new offspring
            for (int i = 0; i < organismCount; i+=2 ){

                 Organism offspring = new Organism();                     

                 // offspring = mate(organisms[i],organisms[i+1]);
                 
                 // Remove the organisms parents
                 organisms.RemoveRange(0,2);

                 organisms.Add(offspring);          

            }

            return organisms;
        }

        // Mates two organisms by combining their genes and returning a 
        // new orgianism 
        protected Organism mate(Organism mother,Organism father)
        {
            return mother; // testing
        }

        // Perform random mutations of some of the genes of offspring (with a
        // low probability) 
        protected List<Organism> mutation(List<Organism> organisms)
        {
            return organisms;
        }

        // Iterates through each organism in the population and prints the
        // genes of each organism 
        protected void printOrganismGenes(){

        }


    }
}