using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShop
{
    public partial class Form1 : Form
    {
        int productId = 1;
        int orderId = 1;


        public Form1()
        {
            InitializeComponent();
            LoadData();
            HookEvents();
        }
        private void LoadData()
        {
            // Категории
            comboCategory.Items.AddRange(new string[]
            {
                "Млечни", "Месо", "Плодове", "Зеленчуци", "Напитки"
            });

            // Мерни единици
            comboMeasure.Items.AddRange(new string[]
            {
                "бр", "кг", "л"
            });

            // Фирми доставчици
            comboDeliveryCompany.Items.AddRange(new string[]
            {
                "Еконт", "Спиди", "Български пощи"
            });

            // Страни
            comboCountry.Items.AddRange(new string[]
            {
                "България", "Румъния", "Гърция"
            });

            // Default values
            comboCategory.SelectedIndex = 0;
            comboMeasure.SelectedIndex = 0;
            comboDeliveryCompany.SelectedIndex = 0;
            comboCountry.SelectedIndex = 0;

            LoadRegions();
            LoadCities();
        }

        private void HookEvents()
        {
            comboCategory.SelectedIndexChanged += ComboCategory_SelectedIndexChanged;
            txtUnitPrice.TextChanged += CalculateTotal;
            numericQty.ValueChanged += CalculateTotal;
            comboMeasure.SelectedIndexChanged += CalculateTotal;

            comboCountry.SelectedIndexChanged += (s, e) =>
            {
                LoadRegions();
                LoadCities();
            };

            comboRegion.SelectedIndexChanged += (s, e) =>
            {
                LoadCities();
            };

            gridProducts.CellContentClick += GridProducts_CellContentClick;
        }
        private void CalculateTotal(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal price))
            {
                decimal qty = numericQty.Value;
                txtFinalPrice.Text = (qty * price).ToString("0.00");
            }
        }
        // =====================================================================
        //  LOAD REGION CITY LOGIC 
        // =====================================================================
        private void LoadRegions()
        {
            comboRegion.Items.Clear();

            if (comboCountry.SelectedItem.ToString() == "България")
                comboRegion.Items.AddRange(new string[] { "София", "Пловдив", "Варна", "Бургас" });

            if (comboCountry.SelectedItem.ToString() == "Румъния")
                comboRegion.Items.AddRange(new string[] { "Букурещ", "Констанца" });

            if (comboCountry.SelectedItem.ToString() == "Гърция")
                comboRegion.Items.AddRange(new string[] { "Атина", "Солун" });

            comboRegion.SelectedIndex = 0;
        }

        private void LoadCities()
        {
            comboCity.Items.Clear();

            if (comboRegion.SelectedItem == null) return;

            if (comboRegion.SelectedItem.ToString() == "София")
                comboCity.Items.AddRange(new string[] { "София", "Банкя", "Нови Искър" });

            if (comboRegion.SelectedItem.ToString() == "Пловдив")
                comboCity.Items.AddRange(new string[] { "Пловдив", "Асеновград" });

            if (comboRegion.SelectedItem.ToString() == "Варна")
                comboCity.Items.AddRange(new string[] { "Варна", "Аксаково" });

            if (comboRegion.SelectedItem.ToString() == "Бургас")
                comboCity.Items.AddRange(new string[] { "Бургас", "Созопол" });

            comboCity.SelectedIndex = 1;
        }

        // =====================================================================
        //  CATEGORY → PRODUCTS
        // =====================================================================
        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedProducts.Items.Clear();

            switch (comboCategory.SelectedItem.ToString())
            {
                case "Млечни":
                    checkedProducts.Items.AddRange(new string[]
                    {
                        "Кисело мляко", "Прясно мляко", "Кашкавал", "Сирене"
                    });
                    break;

                case "Месо":
                    checkedProducts.Items.AddRange(new string[]
                    {
                        "Пилешко", "Свинско", "Телешко", "Кайма"
                    });
                    break;

                case "Плодове":
                    checkedProducts.Items.AddRange(new string[]
                    {
                        "Ябълки", "Банани", "Киви", "Грозде"
                    });
                    break;

                case "Зеленчуци":
                    checkedProducts.Items.AddRange(new string[]
                    {
                        "Домати", "Краставици", "Патладжан", "Картофи"
                    });
                    break;

                case "Напитки":
                    checkedProducts.Items.AddRange(new string[]
                    {
                        "Вода", "Сок", "Кола", "Фанта"
                    });
                    break;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedProducts.CheckedItems)
            {
                gridProducts.Rows.Add(
                    productId++,
                    item.ToString(),
                    comboMeasure.SelectedItem.ToString(),
                    numericQty.Value,
                    comboCategory.SelectedItem.ToString(),
                    txtUnitPrice.Text,
                    txtFinalPrice.Text,
                    "Изтрий"
                );
            }
        }
        private void GridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) // delete column
            {
                gridProducts.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Продуктите са записани!");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string method = radioToOffice.Checked ? "До офис" : "До адрес";
            string payment = radioCash.Checked ? "Наложен" :
                             radioBank.Checked ? "Банков" :
                             "Карта";

            foreach (DataGridViewRow row in gridProducts.Rows)
            {
                if (row.IsNewRow) continue;

                gridOrders.Rows.Add(
                    orderId++,
                    orderId++,
                    row.Cells[1].Value, // продукт
                    row.Cells[2].Value, // мярка
                    row.Cells[3].Value, // количество
                    row.Cells[5].Value, // ед. цена
                    row.Cells[6].Value, // крайна цена
                    method,
                    $"{comboCountry.SelectedItem}, {comboRegion.SelectedItem}, {comboCity.SelectedItem}, {txtAddress.Text} №{numericAddrNum.Value}",
                    comboDeliveryCompany.SelectedItem,
                    payment
                );
            }

            MessageBox.Show("Заявката е изпратена!");

        }

        private void tabProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
