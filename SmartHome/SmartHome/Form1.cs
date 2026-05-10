using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class MainForm : Form
    {
        // Папка с картинките (Images до .exe-то)
        private readonly string imagesPath;
        public MainForm()
        {
            InitializeComponent();

            imagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Images");

            InitializeUi();
        }
        // ----------------- НАСТРОЙКА НА UI -----------------
        private void InitializeUi()
        {
            this.Text = "SmartHome";
            this.StartPosition = FormStartPosition.CenterScreen;

            // картинката да се мащабира
            pictureRoom.SizeMode = PictureBoxSizeMode.Zoom;

            // Добавямеplaceholder в комботата и събития
            SetupComboBox(comboBox1);
            SetupComboBox(comboBox2);
            SetupComboBox(comboBox3);
            SetupComboBox(comboBox4);
            SetupComboBox(comboBox5);
            SetupComboBox(comboBox6);

            // Събития за избор на уред
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged; // Спалня
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged; // Всекидневна
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged; // Кухня
            comboBox4.SelectedIndexChanged += ComboBox4_SelectedIndexChanged; // Антре
            comboBox5.SelectedIndexChanged += ComboBox5_SelectedIndexChanged; // Баня
            comboBox6.SelectedIndexChanged += ComboBox6_SelectedIndexChanged; // Дрешник

            // Бутон "Начало"
            btnHome.Click += BtnHome_Click;

            // Показваме общ план в началото
            ShowHomePlan();
        }

        private void SetupComboBox(ComboBox cb)
        {
            if (cb.Items.Count == 0 || !cb.Items[0].ToString().StartsWith("-Изберете"))
            {
                cb.Items.Insert(0, "-Изберете уред-");
            }
            cb.SelectedIndex = 0;
        }

        // ----------------- ЗАРЕЖДАНЕ НА КАРТИНКИ -----------------

        private void ShowHomePlan()
        {
            ClearDeviceControls();
            LoadRoomImage("plan.png");
        }

        private void LoadRoomImage(string fileName)
        {
            string fullPath = Path.Combine(imagesPath, fileName);

            if (File.Exists(fullPath))
            {
                // за да не държим файла заключен:
                using (var imgTemp = Image.FromFile(fullPath))
                {
                    pictureRoom.Image = new Bitmap(imgTemp);
                }
            }
            else
            {
                pictureRoom.Image = null;
                MessageBox.Show(
                    $"Картинката не е намерена:\n{fullPath}",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // чистим контролите за уредите, но пазим бутона Начало
        private void ClearDeviceControls()
        {
            var toRemove = panelDeviceControls.Controls
                .Cast<Control>()
                .Where(c => c != btnHome)
                .ToList();

            foreach (var c in toRemove)
            {
                panelDeviceControls.Controls.Remove(c);
                c.Dispose();
            }
        }

        // ----------------- СЪБИТИЯ НА КОМБОТАТА (СТАИ) -----------------

        // СПАЛНЯ – comboBox1
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= 0) return;

            LoadRoomImage("bedroom.jpeg");
            ClearDeviceControls();

            switch (comboBox1.SelectedIndex)
            {
                case 1: // телевизор
                    CreateTvControls();
                    break;
                case 2: // осветление (димиируемо)
                    CreateDimmableLightControls();
                    break;
                case 3: // вентилатор
                    CreateFanControls();
                    break;
            }
        }

        // ВСЕКИДНЕВНА – comboBox2
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex <= 0) return;

            LoadRoomImage("livingroom.jpeg");
            ClearDeviceControls();

            switch (comboBox2.SelectedIndex)
            {
                case 1: // телевизор
                    CreateTvControls();
                    break;
                case 2: // климатик
                    CreateAcControls();
                    break;
                case 3: // осветление
                    CreateDimmableLightControls();
                    break;
                case 4: // вентилатор
                    CreateFanControls();
                    break;
            }
        }

        // КУХНЯ – comboBox3
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex <= 0) return;

            LoadRoomImage("kitchen.jpeg");
            ClearDeviceControls();

            switch (comboBox3.SelectedIndex)
            {
                case 1: // кафе машина
                    CreateCoffeeMachineControls();
                    break;
                case 2: // осветление
                    CreateOnOffLightControls();
                    break;
            }
        }

        // АНТРЕ – comboBox4
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex <= 0) return;

            LoadRoomImage("hall.jpeg");
            ClearDeviceControls();

            switch (comboBox4.SelectedIndex)
            {
                case 1: // врата
                    CreateDoorControls();
                    break;
                case 2: // осветление
                    CreateOnOffLightControls();
                    break;
            }
        }

        // БАНЯ – comboBox5
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex <= 0) return;

            LoadRoomImage("bath.jpeg");
            ClearDeviceControls();

            switch (comboBox5.SelectedIndex)
            {
                case 1: // бойлер
                    CreateBoilerControls();
                    break;
                case 2: // осветление
                    CreateOnOffLightControls();
                    break;
            }
        }

        // ДРЕШНИК – comboBox6
        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex <= 0) return;

            LoadRoomImage("closet.png");
            ClearDeviceControls();

            // само осветление
            CreateOnOffLightControls();
        }

        // ----------------- БУТОН "НАЧАЛО" -----------------

        private void BtnHome_Click(object sender, EventArgs e)
        {
            // reset на всички комбота
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;

            ShowHomePlan();
        }

        // ----------------- КОНТРОЛИ ЗА УРЕДИТЕ -----------------

        // TV on/off
        private void CreateTvControls()
        {
            Label lbl = new Label
            {
                Text = "Телевизор",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            Button btn = new Button
            {
                Text = "Off",
                Left = 150,
                Top = 15,
                Width = 100
            };

            btn.Click += (s, e) =>
            {
                btn.Text = (btn.Text == "Off") ? "On" : "Off";
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(btn);
        }

        // осветление нормален / димируем режим
        private void CreateDimmableLightControls()
        {
            Label lbl = new Label
            {
                Text = "Осветление",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            RadioButton rbNormal = new RadioButton
            {
                Text = "Нормален режим",
                Left = 150,
                Top = 18,
                Checked = true
            };

            RadioButton rbDim = new RadioButton
            {
                Text = "Димируем режим",
                Left = 150,
                Top = 45
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(rbNormal);
            panelDeviceControls.Controls.Add(rbDim);
        }

        // обикновено on/off осветление
        private void CreateOnOffLightControls()
        {
            Label lbl = new Label
            {
                Text = "Осветление",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            Button btn = new Button
            {
                Text = "Off",
                Left = 150,
                Top = 15,
                Width = 100
            };

            btn.Click += (s, e) =>
            {
                btn.Text = (btn.Text == "Off") ? "On" : "Off";
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(btn);
        }

        // вентилатор степен 0–3
        private void CreateFanControls()
        {
            Label lbl = new Label
            {
                Text = "Вентилатор",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            TrackBar track = new TrackBar
            {
                Minimum = 0,
                Maximum = 3,
                TickStyle = TickStyle.Both,
                Left = 150,
                Top = 10,
                Width = 200
            };

            Label lblSpeed = new Label
            {
                Left = 370,
                Top = 20,
                AutoSize = true,
                Text = "Степен: 0"
            };

            track.Scroll += (s, e) =>
            {
                lblSpeed.Text = "Степен: " + track.Value;
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(track);
            panelDeviceControls.Controls.Add(lblSpeed);
        }

        // климатик
        private void CreateAcControls()
        {
            Label lbl = new Label
            {
                Text = "Климатик",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            Button btnPower = new Button
            {
                Text = "Off",
                Left = 150,
                Top = 15,
                Width = 80
            };

            NumericUpDown numTemp = new NumericUpDown
            {
                Left = 250,
                Top = 17,
                Minimum = 16,
                Maximum = 30,
                Value = 24
            };

            Label lblTemp = new Label
            {
                Text = "°C",
                Left = 330,
                Top = 20,
                AutoSize = true
            };

            btnPower.Click += (s, e) =>
            {
                btnPower.Text = (btnPower.Text == "Off") ? "On" : "Off";
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(btnPower);
            panelDeviceControls.Controls.Add(numTemp);
            panelDeviceControls.Controls.Add(lblTemp);
        }

        // врата lock / unlock
        private void CreateDoorControls()
        {
            Label lbl = new Label
            {
                Text = "Врата",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            Button btn = new Button
            {
                Text = "Lock",
                Left = 150,
                Top = 15,
                Width = 100
            };

            btn.Click += (s, e) =>
            {
                btn.Text = (btn.Text == "Lock") ? "Unlock" : "Lock";
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(btn);
        }

        // бойлер
        private void CreateBoilerControls()
        {
            Label lbl = new Label
            {
                Text = "Бойлер",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            Button btn = new Button
            {
                Text = "Off",
                Left = 150,
                Top = 15,
                Width = 100
            };

            btn.Click += (s, e) =>
            {
                btn.Text = (btn.Text == "Off") ? "On" : "Off";
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(btn);
        }

        // кафе машина
        private void CreateCoffeeMachineControls()
        {
            Label lbl = new Label
            {
                Text = "Кафе машина",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            Button btn = new Button
            {
                Text = "Направи кафе",
                Left = 150,
                Top = 15,
                Width = 150
            };

            btn.Click += (s, e) =>
            {
                MessageBox.Show("Вашето кафе е готово!", "SmartHome");
            };

            panelDeviceControls.Controls.Add(lbl);
            panelDeviceControls.Controls.Add(btn);
        }

        // за да не дава грешка, понеже в Designer има event за label1_Click
        private void label1_Click(object sender, EventArgs e)
        {
            // по желание – прехвърля фокус към combobox-а на спалнята
            comboBox1.Focus();
        }
      
    }

}

 
