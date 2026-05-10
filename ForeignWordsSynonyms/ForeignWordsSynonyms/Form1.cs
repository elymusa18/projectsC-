using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeignWordsSynonyms
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> synonyms = new Dictionary<string, string>()
        {
            { "емоджи", "иконка, усмивка, пиктограма" },
            { "флашмоб", "събиране, акция, импровизация" },
            { "слоган", "мото, лозунг, девиз" },
            { "маркетинг", "реклама, промоция, търговия" },
            { "инфлуенсър", "влиятел, популярна личност, блогър" }
        };
        public Form1()
        {
            InitializeComponent(); this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Попълваме падащия списък
            comboBoxWords.Items.AddRange(new object[]
            {
                "емоджи",
                "флашмоб",
                "слоган",
                "маркетинг",
                "инфлуенсър"
            });

            textBoxSynonyms.ReadOnly = true;
        }


        private void comboBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWord = comboBoxWords.SelectedItem.ToString();
            if (synonyms.ContainsKey(selectedWord))
                textBoxSynonyms.Text = synonyms[selectedWord];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newSynonym = textBoxNewSynonym.Text.Trim();
            string selectedWord = comboBoxWords.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedWord))
            {
                MessageBox.Show("Моля, изберете дума от списъка!");
                return;
            }

            if (string.IsNullOrEmpty(newSynonym))
            {
                MessageBox.Show("Моля, въведете нов синоним!");
                return;
            }

            // Добавяме предложението в списъка
            listBoxSuggestions.Items.Add($"{selectedWord} → {newSynonym}");

            // Изчистваме полето
            textBoxNewSynonym.Clear();
        }
        private void listBoxSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
           
    }
}

