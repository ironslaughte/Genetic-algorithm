using System;
using System.Collections;

namespace Genetic_Algorithm
{
    static class MutateExtensions
    {
        private static Random rand = new Random();
        public static double RealGenMutate(double gen)
        {
            return (gen + rand.NextDouble()) / 2.0;
        }

        public static double IntegerGenMutate(double gen)
        {
            byte[] genToBytes = BitConverter.GetBytes((int)gen);
            BitArray genToBits = new BitArray(new int[] { (int)gen });
            for (int i = 0; i < genToBits.Length; i++)
                if (rand.NextDouble() < Chromosome.MutateRate)
                    genToBits[i] = genToBits[i] == true ? false : true;
            genToBits.CopyTo(genToBytes, 0);
            return BitConverter.ToInt32(genToBytes, 0);
        }
    }
}
