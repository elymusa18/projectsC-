using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Забраняваме преоразмеряване
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Добавяме събитие при затваряне
            this.FormClosing += Form1_FormClosing;
        }

        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Прочитаме двете числа
                double left = double.Parse(textBoxNumLeft.Text);
                double right = double.Parse(textBoxNumRight.Text);

                // Изчисляваме резултата
                double result = left + right;

                // Показваме резултата
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Моля, въведете валидни числа!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Изчистваме всички полета
            textBoxNumLeft.Clear();
            textBoxNumRight.Clear();
            textBoxResult.Clear();

            // Фокус върху първото поле
            textBoxNumLeft.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сигурни ли сте, че искате да излезете?",
                "Изход от програмата",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Спираме затварянето
            }
        }
    }
}
