using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FRMLPStudentSuccess.GUI

{
    public static class FrequencyRatioCalculator
    {
        public static double[] ComputeFR(List<DataPoint> data)
        {
            if (data.Count == 0)
                throw new ArgumentException("Dataset is empty.");

            int featureCount = data[0].Features.Length;

            double[] sumPos = new double[featureCount];
            double[] sumNeg = new double[featureCount];
            int countPos = 0;
            int countNeg = 0;

            foreach (var dp in data)
            {
                if (dp.Label == 1)
                {
                    countPos++;
                    for (int i = 0; i < featureCount; i++)
                        sumPos[i] += dp.Features[i];
                }
                else
                {
                    countNeg++;
                    for (int i = 0; i < featureCount; i++)
                        sumNeg[i] += dp.Features[i];
                }
            }

            double[] fr = new double[featureCount];
            const double epsilon = 1e-6;

            for (int i = 0; i < featureCount; i++)
            {
                double meanPos = countPos > 0 ? sumPos[i] / countPos : 0.0;
                double meanNeg = countNeg > 0 ? sumNeg[i] / countNeg : epsilon;

                fr[i] = meanNeg > 0 ? meanPos / (meanNeg + epsilon) : 1.0;
            }

            return fr;
        }

        // modificirane na features (umnojavat se po FR koef.)
        public static void ApplyFR(List<DataPoint> data, double[] fr)
        {
            foreach (var dp in data)
            {
                for (int i = 0; i < dp.Features.Length; i++)
                {
                    // прилагаме FR
                    dp.Features[i] = dp.Features[i] * fr[i];

                    // нормализираме в диапазона [0,1],
                    // за да не се "насища" сигмоидата
                    if (dp.Features[i] > 1.0)
                        dp.Features[i] = 1.0;
                    if (dp.Features[i] < 0.0)
                        dp.Features[i] = 0.0;
                }
            }
        }
    }
}  

