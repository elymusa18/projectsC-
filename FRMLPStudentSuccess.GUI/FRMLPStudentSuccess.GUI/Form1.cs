using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FRMLPStudentSuccess.GUI
{
    public partial class Form1 : Form

    {
        // Данни и модел
        private List<DataPoint> trainData;
        private List<DataPoint> testData;
        private NeuralNetwork nnFR;
        private double[] fr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Моделът още не е обучен.";
            lblResult.Text = "Няма предсказание.";

        }
        // ======= Бутон Train =======
        private void btnTrain_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                string path = "students.csv";

                var allData = DatasetLoader.LoadFromCsv(path);
                DatasetLoader.TrainTestSplit(allData, 0.8, out trainData, out testData);

                int featureCount = trainData[0].Features.Length;

                // Изчисляваме FR по train данните
                fr = FrequencyRatioCalculator.ComputeFR(trainData);

                // Прилагаме FR към train и test
                FrequencyRatioCalculator.ApplyFR(trainData, fr);
                FrequencyRatioCalculator.ApplyFR(testData, fr);

                // Създаваме и обучаваме MLP – повече неврони + по-малък learning rate
                nnFR = new NeuralNetwork(inputSize: featureCount, hiddenSize: 12, outputSize: 1);
                nnFR.Train(trainData, epochs: 3000, learningRate: 0.01);

                // Оценяваме на test
                double acc = Evaluator.Accuracy(testData, nnFR);

                lblStatus.Text = $"Моделът е обучен върху данните от students.csv. " +
                 $"Точност върху test набора: {acc * 100:F2}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при обучение: " + ex.Message, "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // ======= Бутон Predict =======
        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (nnFR == null || fr == null)
            {
                MessageBox.Show("Първо обучи модела с бутона Train.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Четем входовете от текстовите полета
                double attendance = double.Parse(txtAttendance.Text.Replace(',', '.'));
                double assignments = double.Parse(txtAssignments.Text.Replace(',', '.'));
                double practice = double.Parse(txtPractice.Text.Replace(',', '.'));

                double[] features = new double[] { attendance, assignments, practice };

                // Прилагаме FR върху входа
                for (int i = 0; i < features.Length; i++)
                {
                    features[i] = features[i] * fr[i];
                }

                int pred = nnFR.PredictLabel(features);

                if (pred == 1)
                    lblResult.Text = "Прогноза: Студентът най-вероятно ЩЕ ВЗЕМЕ изпита.";
                else
                    lblResult.Text = "Прогноза: Студентът е рисков да НЕ ВЗЕМЕ изпита.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при предсказанието: " + ex.Message, "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrain_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPredict_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
