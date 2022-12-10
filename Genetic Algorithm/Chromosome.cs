using System;
using System.Collections.Generic;

namespace Genetic_Algorithm
{
    public class Chromosome
    {
        private List<double> _genome;

        public static double minValGen, maxValGen;

        public static Action<List<double>> FucnCheckCurrectGens { get; set; }

        public static int _bitDepth;      
        public int NumGenes => _genome.Count;

        public static double MutateRate { get; set; }

        public Chromosome() => _genome = new List<double>();

        public Chromosome(List<double> genome) => _genome = genome;

        public Chromosome(Func<List<double>> InitializeGenom) => _genome = InitializeGenom();

        public void CheckCorrectValueGens() => FucnCheckCurrectGens(_genome);

        public double this[int index]
        {
            get { return _genome[index];}
            set { _genome[index] = value;}
        }
    }
}
