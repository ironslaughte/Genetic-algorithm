using System;
using System.Collections.Generic;
using System.Linq;

namespace Genetic_Algorithm
{

    public delegate double GAFunction(double x, double y, string infixPhrase);
    public class Genetic_Algorithm
    {
        private double  _crossoverRate, _l, _minX, _maxX;
        private string _strFitnessFunc;
        private int _numGenerations, _populationSize;

        private EncodingMethod _encodingMethod;

        private List<Individ> _currentGeneration, _nextGeneration;
        private Random rand = new Random();
        private GAFunction _fitnessFunc;


        public Genetic_Algorithm(double mutateReate, double crossoverRate, string strFitnessFunc, int numGenerations, int populationSize, 
            double minX, double maxX,double L, EncodingMethod encoding, GAFunction fitnessFunc)
        {
            Chromosome.MutateRate = mutateReate;
            Chromosome._bitDepth = (int)Math.Log((int)((maxX - minX) / 0.1 + 1), 2) + 1;
            Chromosome.minValGen = minX;
            Chromosome.maxValGen = maxX;
            _crossoverRate = crossoverRate;
            _strFitnessFunc = strFitnessFunc;
            _numGenerations = numGenerations;
            _populationSize = populationSize;
            _fitnessFunc = fitnessFunc;
            _encodingMethod = encoding;
            _minX = minX;
            _maxX = maxX;
            _l = L;
            SelectFuncToProcess();
            InitializeGenterations(minX, maxX, encoding);
        }

        public void RunGA()
        {
            RankPopulation();
            for(int i = 0; i < _numGenerations; i++)
            {
                CreateNewGeneration();
                RankPopulation();          
            }
        }

        public Individ GetBestIndivid()
        {
            Individ bestIndivid;
            if (_encodingMethod == EncodingMethod.IntegerEncoding)
            {
                double x = Converter.ConvertZToR((int)_currentGeneration[0].Chromosome[0]);
                double y = Converter.ConvertZToR((int)_currentGeneration[0].Chromosome[1]);
                bestIndivid = new Individ(new Chromosome(new List<double> { x, y }));
                bestIndivid.Fitness = _currentGeneration[0].Fitness;
            }
            else
                bestIndivid = _currentGeneration[0];

            return bestIndivid;
        }

        private void RankPopulation()
        {
            foreach (var individ in _currentGeneration)
            {
                if (_encodingMethod == EncodingMethod.RealEncoding)
                    individ.Fitness = _fitnessFunc(individ.Chromosome[0], individ.Chromosome[1], _strFitnessFunc);
                else
                    individ.Fitness = _fitnessFunc(Converter.ConvertZToR((int)individ.Chromosome[0]),
                        Converter.ConvertZToR((int)individ.Chromosome[1]), _strFitnessFunc);
            }
            _currentGeneration = _currentGeneration.OrderBy(x => x.Fitness).ToList();
        }

        private void CreateNewGeneration()
        {
            for (int k = 0; k < _populationSize;)              
                k = SetNewGeneration(k);

            for (int i = 0; i < _populationSize; i++)
            {
                _nextGeneration[i].Mutate();
                _currentGeneration[i] = _nextGeneration[i];
            }
        }
      
        private int SetNewGeneration(int k)
        {
            int i = (int)(rand.NextDouble() * (_populationSize * _l));
            int j = (int)(rand.NextDouble() * (_populationSize * _l));
            if (rand.NextDouble() >= _crossoverRate)
            {
                _nextGeneration[k++] = _currentGeneration[i];
                _nextGeneration[k++] = _currentGeneration[j];
            }
            else
            {
                var children = _currentGeneration[i].Crossover(_currentGeneration[j]);
                _nextGeneration[k++] = children.Item1;
                _nextGeneration[k++] = children.Item2;
            }
            return k;
        }

        private void InitializeGenterations(double minX, double maxX, EncodingMethod encoding)
        {
            _currentGeneration = new List<Individ>();
            _nextGeneration = new List<Individ>();
            for (int i = 0; i < _populationSize; i++)
            {
                _currentGeneration.Add(new Individ(new Chromosome(() =>
                {
                    var genom = new List<double>();
                    for (int j = 0; j < 2; j++)
                    {
                        var value = rand.NextDouble() * (maxX - minX) + minX;
                        genom.Add(value);
                        if (encoding == EncodingMethod.IntegerEncoding)
                            genom[j] = Converter.ConvertRToZ(genom[j]);
                    }
                    return genom;
                })));
                _nextGeneration.Add(new Individ(new Chromosome(() =>
                {
                    var genom = new List<double>();
                    for (int j = 0; j < 2; j++)
                        genom.Add(0);
                    return genom;
                })));
            }
        }

        private void SelectFuncToProcess()
        {
            if (_encodingMethod == EncodingMethod.RealEncoding)
            {
                Individ.MutationMethod = MutateExtensions.RealGenMutate;
                Individ.CrossoverMethod = CrossoverExtensions.RealChromosomeCrossover;
                Chromosome.FucnCheckCurrectGens = GenomeExtensions.CheckCorrectValueRealGens;
            }
            else
            {
                Individ.MutationMethod = MutateExtensions.IntegerGenMutate;
                Individ.CrossoverMethod = CrossoverExtensions.IntegerChromosomeCrossover;
                Chromosome.FucnCheckCurrectGens = GenomeExtensions.CheckCorrectValueIntGens;
            }
        }
    }
}
