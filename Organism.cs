using System;

namespace GenticAlgorithm
{

    class Organism
    {

        int fitness = 0;
        int[] genes = new int[10];
        int geneLength = 10;

        public Organism()
        {
            Random rnd = new Random();

            // Initialize genes randomly
            for (int i = 0; i < genes.Length; i++)
            {
                genes[i] = Math.Abs(rnd.Next() % 2);
            }

        }


    }


}