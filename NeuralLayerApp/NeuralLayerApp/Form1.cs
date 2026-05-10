using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralLayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculateLayer_Click(object sender, EventArgs e)
        {
            

            double[] inputs = new double[] { 1, 2, 3, 2.5 };

            // double[,] weights: [Неврон, Вход]
            double[,] weights = new double[,] {
                { 0.2, 0.8, -0.5, 1.0 },       // Тегла за Неврон 1 (индекс 0)
                { 0.5, -0.91, 0.26, -0.5 },    // Тегла за Неврон 2 (индекс 1)
                { -0.26, -0.27, 0.17, 0.87 }   // Тегла за Неврон 3 (индекс 2)
            };

            double[] bias = new double[] { 2, 3, 0.5 };
            double[] outputs = new double[3]; // Масив за съхранение на 3-те изхода

            // --- 2. Моделиране на слоя с вложени цикли ---

            int numberOfNeurons = bias.Length; // 3
            int numberOfInputs = inputs.Length; // 4

           
            for (int i = 0; i < numberOfNeurons; i++)
            {
                double neuronOutput = 0.0;

                for (int j = 0; j < numberOfInputs; j++)
                {
               
                    neuronOutput += inputs[j] * weights[i, j];
                }

                neuronOutput += bias[i];

                outputs[i] = neuronOutput;
            }

          

            // Резултати: 4.800, 1.210, 2.385

            // Неврон 1 (i=0)
            label1.Text = $"Неврон 1: {outputs[0]:F3}";

            // Неврон 2 (i=1) 
            label2.Text = $"Неврон 2: {outputs[1]:F3}";

            // Неврон 3 (i=2)
            label3.Text = $"Неврон 3: {outputs[2]:F3}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


    

