using System;
using GenticAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Genetic Algorithm Example");

        Population population = new Population(100);

        // The number of generatioins to run
        int epoch = 5;
        population.age(epoch);

    }
}
