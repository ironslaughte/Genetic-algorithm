using System;

namespace Genetic_Algorithm
{
    static class Converter
    {
        public static double minValue, maxValue;

        public static int ConvertRToZ(double num) => (int)((num - minValue) * Math.Pow(2, Chromosome._bitDepth)) / (int)(maxValue - minValue);

        public static double ConvertZToR(int num) => num * (maxValue - minValue) / (Math.Pow(2, Chromosome._bitDepth) - 1) + minValue;
    }
}
