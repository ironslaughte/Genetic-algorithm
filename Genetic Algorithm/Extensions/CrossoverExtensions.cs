using System;
using System.Collections;
using System.Collections.Generic;

namespace Genetic_Algorithm
{
    static class CrossoverExtensions
    {
        private static Random rand = new Random();
        public static (Individ, Individ) RealChromosomeCrossover(Individ firstParent, Individ secondParent)
        {
            int position = (int)(rand.NextDouble() * (double)firstParent.Chromosome.NumGenes);
            List<double> gensChild1 = new List<double>();
            List<double> gensChild2 = new List<double>();
            for (int i = 0; i < firstParent.Chromosome.NumGenes; i++)
            {
                if (i < position)
                {
                    gensChild1.Add(firstParent.Chromosome[i]);
                    gensChild2.Add(secondParent.Chromosome[i]);
                }
                else
                {
                    gensChild1.Add(secondParent.Chromosome[i]);
                    gensChild2.Add(firstParent.Chromosome[i]);
                }
            }
            return (new Individ(new Chromosome(gensChild1)), new Individ(new Chromosome(gensChild2)));
        }

        public static (Individ, Individ) IntegerChromosomeCrossover(Individ firstParent, Individ secondParent)
        {
            List<BitArray> bitGensFirstP, bitGensSecondP, bitGensFirstC, bitGensSecondC;
            InitializeGensChilds(out bitGensFirstC, out bitGensSecondC);
            ConvertIndividsToListsBits(firstParent, secondParent, out bitGensFirstP, out bitGensSecondP);
            int position = (int)(rand.NextDouble() * 32);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (j < position)
                    {
                        bitGensFirstC[i][j] = bitGensFirstP[i][j];
                        bitGensSecondC[i][j] = bitGensSecondP[i][j];
                    }
                    else
                    {
                        bitGensFirstC[i][j] = bitGensSecondP[i][j];
                        bitGensSecondC[i][j] = bitGensFirstP[i][j];
                    }
                }
            }

            List<double> gensFirstC = new List<double>(), gensSecondC = new List<double>();
            ConvertBitGensToInt(bitGensFirstP, bitGensSecondP, gensFirstC, gensSecondC);
            return (new Individ(new Chromosome(gensFirstC)), new Individ(new Chromosome(gensSecondC)));
        }

        private static void ConvertBitGensToInt(List<BitArray> bitGensFirstP, List<BitArray> bitGensSecondP, List<double> gensFirstC, List<double> gensSecondC)
        {
            byte[] gens = new byte[8];
            for (int i = 0; i < 2; i++)
            {
                bitGensFirstP[i].CopyTo(gens, 0);
                gensFirstC.Add(BitConverter.ToInt32(gens, 0));
                bitGensSecondP[i].CopyTo(gens, 0);
                gensSecondC.Add(BitConverter.ToInt32(gens, 0));
            }
        }

        private static void InitializeGensChilds(out List<BitArray> bitGensFirstC, out List<BitArray> bitGensSecondC)
        {
            bitGensFirstC = new List<BitArray> { new BitArray(32), new BitArray(32) };
            bitGensSecondC = new List<BitArray> { new BitArray(32), new BitArray(32) };
        }

        private static void ConvertIndividsToListsBits(Individ firstParent, Individ secondParent, out List<BitArray> bitGensFirstP, out List<BitArray> bitGensSecondP)
        {
            List<byte[]> byteGensFirstP = new List<byte[]> { BitConverter.GetBytes((int)firstParent.Chromosome[0]), 
                BitConverter.GetBytes((int)firstParent.Chromosome[1]) };
            List<byte[]> byteGensSecondP = new List<byte[]> { BitConverter.GetBytes((int)secondParent.Chromosome[0]),
                BitConverter.GetBytes((int)secondParent.Chromosome[1]) };
            bitGensFirstP = new List<BitArray> { new BitArray(byteGensFirstP[0]), new BitArray(byteGensFirstP[1]) };
            bitGensSecondP = new List<BitArray> { new BitArray(byteGensSecondP[0]), new BitArray(byteGensSecondP[1]) };
        }

    }
}
