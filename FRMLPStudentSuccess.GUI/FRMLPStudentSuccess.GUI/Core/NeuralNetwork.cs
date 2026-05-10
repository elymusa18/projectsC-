using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMLPStudentSuccess.GUI

{
    public class NeuralNetwork
    {
        private int inputSize;
        private int hiddenSize;
        private int outputSize;

        private double[,] w1;
        private double[,] w2;
        private double[] b1;
        private double[] b2;

        private Random rnd;

        public NeuralNetwork(int inputSize, int hiddenSize, int outputSize)
        {
            this.inputSize = inputSize;
            this.hiddenSize = hiddenSize;
            this.outputSize = outputSize;

            w1 = new double[hiddenSize, inputSize];
            w2 = new double[outputSize, hiddenSize];
            b1 = new double[hiddenSize];
            b2 = new double[outputSize];

            rnd = new Random(123);

            InitializeWeights();
        }

        private void InitializeWeights()
        {
            double initRange = 0.5;

            for (int i = 0; i < hiddenSize; i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    w1[i, j] = (rnd.NextDouble() * 2 - 1) * initRange;
                }
                b1[i] = 0.0;
            }

            for (int i = 0; i < outputSize; i++)
            {
                for (int j = 0; j < hiddenSize; j++)
                {
                    w2[i, j] = (rnd.NextDouble() * 2 - 1) * initRange;
                }
                b2[i] = 0.0;
            }
        }

        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));

        private double SigmoidDerivative(double x)
        {
            double s = Sigmoid(x);
            return s * (1.0 - s);
        }

        // Forward pass (samo za predskazvane)
        public double[] Forward(double[] input)
        {
            double[] z1 = new double[hiddenSize];
            double[] a1 = new double[hiddenSize];

            for (int i = 0; i < hiddenSize; i++)
            {
                double sum = b1[i];
                for (int j = 0; j < inputSize; j++)
                {
                    sum += w1[i, j] * input[j];
                }
                z1[i] = sum;
                a1[i] = Sigmoid(sum);
            }

            double[] z2 = new double[outputSize];
            double[] a2 = new double[outputSize];

            for (int i = 0; i < outputSize; i++)
            {
                double sum = b2[i];
                for (int j = 0; j < hiddenSize; j++)
                {
                    sum += w2[i, j] * a1[j];
                }
                z2[i] = sum;
                a2[i] = Sigmoid(sum);
            }

            return a2;
        }

        // Forward s mezhdinni stoinosti(za backprop)
        private void ForwardWithIntermediates(double[] input,
            out double[] z1, out double[] a1,
            out double[] z2, out double[] a2)
        {
            z1 = new double[hiddenSize];
            a1 = new double[hiddenSize];

            for (int i = 0; i < hiddenSize; i++)
            {
                double sum = b1[i];
                for (int j = 0; j < inputSize; j++)
                {
                    sum += w1[i, j] * input[j];
                }
                z1[i] = sum;
                a1[i] = Sigmoid(sum);
            }

            z2 = new double[outputSize];
            a2 = new double[outputSize];

            for (int i = 0; i < outputSize; i++)
            {
                double sum = b2[i];
                for (int j = 0; j < hiddenSize; j++)
                {
                    sum += w2[i, j] * a1[j];
                }
                z2[i] = sum;
                a2[i] = Sigmoid(sum);
            }
        }

        public void Train(List<DataPoint> trainData, int epochs, double learningRate)
        {
            var rnd = new Random(456);

            for (int epoch = 0; epoch < epochs; epoch++)
            {
                double totalLoss = 0.0;

                // za vsqka epoch se razburkvat dannite
                foreach (var dp in Shuffle(trainData, rnd))
                {
                    double[] x = dp.Features;
                    double y = dp.Label;

                    ForwardWithIntermediates(x,
                        out double[] z1, out double[] a1,
                        out double[] z2, out double[] a2);

                    // MSE: 0.5 * (y - output)^2
                    double[] delta2 = new double[outputSize];

                    for (int k = 0; k < outputSize; k++)
                    {
                        double error = a2[k] - y;
                        totalLoss += 0.5 * error * error;
                        delta2[k] = error * SigmoidDerivative(z2[k]);
                    }

                    double[] delta1 = new double[hiddenSize];

                    for (int i = 0; i < hiddenSize; i++)
                    {
                        double sum = 0.0;
                        for (int k = 0; k < outputSize; k++)
                        {
                            sum += w2[k, i] * delta2[k];
                        }
                        delta1[i] = sum * SigmoidDerivative(z1[i]);
                    }

                    // Obnovqvane na w2 i b2
                    for (int k = 0; k < outputSize; k++)
                    {
                        for (int j = 0; j < hiddenSize; j++)
                        {
                            w2[k, j] -= learningRate * delta2[k] * a1[j];
                        }
                        b2[k] -= learningRate * delta2[k];
                    }

                    // Obnovqvane na w1 i b1
                    for (int i = 0; i < hiddenSize; i++)
                    {
                        for (int j = 0; j < inputSize; j++)
                        {
                            w1[i, j] -= learningRate * delta1[i] * x[j];
                        }
                        b1[i] -= learningRate * delta1[i];
                    }
                }

                if ((epoch + 1) % 100 == 0)
                {
                    Console.WriteLine($"Epoch {epoch + 1}, Loss: {totalLoss:F4}");
                }
            }
        }

        private IEnumerable<T> Shuffle<T>(IEnumerable<T> source, Random rnd)
        {
            var list = new List<T>(source);
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
            return list;
        }

        // prediction :  0 ili 1
        public int PredictLabel(double[] input)
        {
            var output = Forward(input);
            // pri edin izhod (outputSize = 1)
            return output[0] >= 0.5 ? 1 : 0;
        }
    }
}


