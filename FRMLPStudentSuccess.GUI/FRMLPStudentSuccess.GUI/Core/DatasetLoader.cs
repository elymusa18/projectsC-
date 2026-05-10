using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FRMLPStudentSuccess.GUI

{
    public static class DatasetLoader
    {
        public static List<DataPoint> LoadFromCsv(string path)
        {
            var data = new List<DataPoint>();

            var lines = File.ReadAllLines(path);
            // purviqt red e header
            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                // posl kolona e etiket (0/1)
                int label = int.Parse(parts[parts.Length - 1].Trim());


                double[] features = parts
                    .Take(parts.Length - 1)
                    .Select(p => double.Parse(p.Trim().Replace('.', ',')))
                    .ToArray();

                data.Add(new DataPoint(features, label));
            }

            return data;
        }

        public static void TrainTestSplit(
            List<DataPoint> allData,
            double trainRatio,
            out List<DataPoint> trainData,
            out List<DataPoint> testData)
        {
            var rnd = new Random(42);
            var shuffled = allData.OrderBy(_ => rnd.Next()).ToList();

            int trainCount = (int)(shuffled.Count * trainRatio);
            trainData = shuffled.Take(trainCount).ToList();
            testData = shuffled.Skip(trainCount).ToList();
        }
    }
}

