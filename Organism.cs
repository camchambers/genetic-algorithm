using System;

namespace GenticAlgorithm
{
    // The organism class is responsible for defining organisms that form a 
    // population and determine how fit an organism is
    class Organism
    {

        // Determines how fit an organism is (fitness score)
        int Fitness = 0;

        // An abstract binary representation of an organisms genes
        int[] Genes = new int[10];

        // Constructor for organism class
        public Organism()
        {
            Random rnd = new Random();

            // Initialize genes randomly by iterating over all of the genes
            // and creating a binary string of size geneLength
            for (int i = 0; i < genes.Length; i++)
            {
                genes[i] = Math.Abs(rnd.Next() % 2);
            }
        }

        // The fitness method determines the fitness of an organism (ability to
        // compete with other individuals) based on its genes.
        // It applies a fitness score to the organism and the probability that
        // the organism will be selected for reproduction is based on its
        // fitness score.
        // In this case, the fitness score will favour individuals that contain
        // 1's in the binary representation of their genes.
        public void CalculateFitness()
        {
            for (int i = 0; i < genes.Length; i++)
            {
                if (genes[i] == 1)
                {
                    fitness++;
                }
            }
        }
    }
}