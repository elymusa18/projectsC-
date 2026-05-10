using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMLPStudentSuccess.GUI

{
    public static class Evaluator
    {
        public static double Accuracy(List<DataPoint> data, NeuralNetwork nn)
        {
            int correct = 0;

            foreach (var dp in data)
            {
                int pred = nn.PredictLabel(dp.Features);
                if (pred == dp.Label)
                    correct++;
            }

            return (double)correct / data.Count;
        }
    }
}

