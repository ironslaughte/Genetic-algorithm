using System.Collections.Generic;

namespace Genetic_Algorithm
{
    static class GenomeExtensions
    {
        public static void CheckCorrectValueIntGens(List<double> genome)
        {
            double[] genR = new double[genome.Count];
            genR[0] = Converter.ConvertZToR((int)genome[0]);
            genR[1] = Converter.ConvertZToR((int)genome[1]);
            for (int i = 0; i < genome.Count; i++)
            {
                if (genR[i] < Chromosome.minValGen)
                    genome[i] = Converter.ConvertRToZ(Chromosome.minValGen+0.1);
                else if (genR[i] > Chromosome.maxValGen)
                    genome[i] = Converter.ConvertRToZ(Chromosome.maxValGen-0.1);
            }
        }
        public static void CheckCorrectValueRealGens(List<double> genome)
        {
            for(int i = 0; i < genome.Count; i++)
            {
                if (genome[i] < Chromosome.minValGen)
                    genome[i] = Chromosome.minValGen;
                else if (genome[i] > Chromosome.maxValGen)
                    genome[i] = Chromosome.maxValGen;
            }
        }
    }
}
