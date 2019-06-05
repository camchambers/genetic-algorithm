using System;

namespace GenticAlgorithm
{
    class Population
    {
        int populationSize = 10;
        float fitnessPercentage = 0.2f;

        Organism[] Organisms;

        // Creates a new population of organisms given a population size        
        public Population(int size = 10, float percent = 0.2f)
        {
            populationSize = size;
            fitnessPercentage = percent;
            Organisms = new Organism[size];
        }

        // Return an array containing a percent of the fittest individuals
        // from the population
        public void getFittest()
        {
            // Use fitnessPercentage to determine number of organisms to 
            // return as being the fittest
        }
    }
}