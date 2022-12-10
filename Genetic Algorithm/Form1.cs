using System;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class Form1 : Form
    {
        Genetic_Algorithm GA;
        EncodingMethod encodingMethod = EncodingMethod.None;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                double mutateRate, crossoverRate, L, minX, maxX;
                int numPopulation, numGeneration;
                ParseParams(out mutateRate, out crossoverRate, out L, out minX, out maxX, out numPopulation, out numGeneration);
                InitializeParamsConverter(minX, maxX);
                if (encodingMethod == EncodingMethod.None)
                {
                    MessageBox.Show("Вы не выбрали способ кодирования генов.");
                    return;
                }

                LaunchGA(mutateRate, crossoverRate, L, minX, maxX, numPopulation, numGeneration);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Параметры введены не корректно");
            }
        }

        private static void InitializeParamsConverter(double minX, double maxX)
        {
            Converter.maxValue = maxX; Converter.minValue = minX;
        }

        private void LaunchGA(double mutateRate, double crossoverRate, double L, double minX, double maxX, int numPopulation, int numGeneration)
        {
            GA = new Genetic_Algorithm(mutateRate, crossoverRate, textBoxFunction.Text, numGeneration, numPopulation,
                                minX, maxX, L, encodingMethod, MathParserSpace.MathParser.calculate);
            GA.RunGA();
            PrintBestIndividGA();
        }

        private void PrintBestIndividGA()
        {
            var ind = GA.GetBestIndivid();
            labelAnswer.Text = "x = " + ind.Chromosome[0] + "\ny = " + ind.Chromosome[1] + "\nF(x,y)= " + ind.Fitness;
        }

        private void ParseParams(out double mutateRate, out double crossoverRate, out double L, out double minX, out double maxX, out int numPopulation, out int numGeneration)
        {
            mutateRate = Double.Parse(textBoxMutateRate.Text) / 100.0;
            crossoverRate = Double.Parse(textBoxCrossoverRate.Text) / 100.0;
            L = Double.Parse(textBoxCuttOffThreshold.Text) / 100.0;
            minX = Double.Parse(TextBoxMinBound.Text);
            maxX = Double.Parse(TextBoxMaxBound.Text);
            numPopulation = Int32.Parse(textBoxNumIndivid.Text);
            numGeneration = int.Parse(textBoxNumGeneration.Text);
        }

        private void TypeDecode_SelectedIndexChanged(object sender, EventArgs e) => encodingMethod = (EncodingMethod)TypeDecode.SelectedIndex;
    }
}
