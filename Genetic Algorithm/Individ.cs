using System;
using System.Collections.Generic;


namespace Genetic_Algorithm
{
    public class Individ
    {
        private static Random random = new Random();
        public Chromosome Chromosome { get; private set; }
        public double Fitness { get; set; }

        public static Func<double, double> MutationMethod { get; set; }

        public static Func<Individ, Individ, (Individ, Individ)> CrossoverMethod { get; set; }
        public Individ(Chromosome chromosome)
        {
            Chromosome = chromosome;
        }

        public Individ(Func<List<double>> InitializeGenom)
        {
            Chromosome = new Chromosome(InitializeGenom);
        }

        public void Mutate()
        {
           for(int i = 0; i < Chromosome.NumGenes; i++)
                if (random.NextDouble() <= Chromosome.MutateRate)
                    Chromosome[i] = MutationMethod(Chromosome[i]);
           Chromosome.CheckCorrectValueGens();
        }

        public (Individ, Individ) Crossover(Individ secondParent) 
        {
            var children = CrossoverMethod(this, secondParent);
            children.Item1.Chromosome.CheckCorrectValueGens();      
            children.Item2.Chromosome.CheckCorrectValueGens();
            return children;
        }

    }
}
