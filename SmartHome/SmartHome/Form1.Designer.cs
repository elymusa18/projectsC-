namespace SmartHome
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelDeviceControls = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureRoom = new System.Windows.Forms.PictureBox();
            this.panelRooms.SuspendLayout();
            this.panelDeviceControls.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Спалня";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Всекидневна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кухня";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Антре";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Баня";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дрешник";
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRooms.Controls.Add(this.comboBox6);
            this.panelRooms.Controls.Add(this.comboBox5);
            this.panelRooms.Controls.Add(this.comboBox4);
            this.panelRooms.Controls.Add(this.comboBox3);
            this.panelRooms.Controls.Add(this.comboBox2);
            this.panelRooms.Controls.Add(this.comboBox1);
            this.panelRooms.Controls.Add(this.label6);
            this.panelRooms.Controls.Add(this.label5);
            this.panelRooms.Controls.Add(this.label4);
            this.panelRooms.Controls.Add(this.label3);
            this.panelRooms.Controls.Add(this.label2);
            this.panelRooms.Controls.Add(this.label1);
            this.panelRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRooms.Location = new System.Drawing.Point(0, 0);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(303, 1035);
            this.panelRooms.TabIndex = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "осветление "});
            this.comboBox6.Location = new System.Drawing.Point(30, 719);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(218, 33);
            this.comboBox6.TabIndex = 11;
            this.comboBox6.Text = "-Изберете уред-";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "бойлер",
            "осветление "});
            this.comboBox5.Location = new System.Drawing.Point(30, 618);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(218, 33);
            this.comboBox5.TabIndex = 10;
            this.comboBox5.Text = "-Изберете уред-";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "врата (lock/unlock)",
            "осветление (on/off) "});
            this.comboBox4.Location = new System.Drawing.Point(30, 496);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(218, 33);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.Text = "-Изберете уред-";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "кафе машина",
            "осветление "});
            this.comboBox3.Location = new System.Drawing.Point(30, 373);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(218, 33);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "-Изберете уред-";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "телевизор",
            "климатик",
            "осветление",
            "вентилатор "});
            this.comboBox2.Location = new System.Drawing.Point(30, 242);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 33);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "-Изберете уред-";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "телевизор (on/off)",
            "осветление (нормален/димируем режим)",
            "вентилатор (1, 2, 3) "});
            this.comboBox1.Location = new System.Drawing.Point(35, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "-Изберете уред-";
            // 
            // panelDeviceControls
            // 
            this.panelDeviceControls.BackColor = System.Drawing.Color.Honeydew;
            this.panelDeviceControls.Controls.Add(this.btnHome);
            this.panelDeviceControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeviceControls.Location = new System.Drawing.Point(303, 0);
            this.panelDeviceControls.Name = "panelDeviceControls";
            this.panelDeviceControls.Size = new System.Drawing.Size(1332, 166);
            this.panelDeviceControls.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1101, 62);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 65);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Начало";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::SmartHome.Properties.Resources.smarthome;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Controls.Add(this.pictureRoom);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(303, 166);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1332, 869);
            this.panelMain.TabIndex = 2;
            // 
            // pictureRoom
            // 
            this.pictureRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureRoom.Location = new System.Drawing.Point(200, 44);
            this.pictureRoom.Name = "pictureRoom";
            this.pictureRoom.Size = new System.Drawing.Size(892, 657);
            this.pictureRoom.TabIndex = 0;
            this.pictureRoom.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelDeviceControls);
            this.Controls.Add(this.panelRooms);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.panelDeviceControls.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelDeviceControls;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureRoom;
        private System.Windows.Forms.Button btnHome;
    }
}

