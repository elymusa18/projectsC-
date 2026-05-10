namespace eShop
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupPrices = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericQty = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.comboMeasure = new System.Windows.Forms.ComboBox();
            this.labelMeasure = new System.Windows.Forms.Label();
            this.groupProducts = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkedProducts = new System.Windows.Forms.CheckedListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupCategory = new System.Windows.Forms.GroupBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.tabDelivery = new System.Windows.Forms.TabPage();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.groupDeliveryMethod = new System.Windows.Forms.GroupBox();
            this.radioToOffice = new System.Windows.Forms.RadioButton();
            this.radioToAddress = new System.Windows.Forms.RadioButton();
            this.comboDeliveryCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.numericAddrNum = new System.Windows.Forms.NumericUpDown();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioBank = new System.Windows.Forms.RadioButton();
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendFinal = new System.Windows.Forms.Button();
            this.btnCancelFinal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.groupPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQty)).BeginInit();
            this.groupProducts.SuspendLayout();
            this.groupCategory.SuspendLayout();
            this.tabDelivery.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.groupDeliveryMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddrNum)).BeginInit();
            this.groupPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabDelivery);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 841);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.gridProducts);
            this.tabProducts.Controls.Add(this.btnCancel);
            this.tabProducts.Controls.Add(this.btnSave);
            this.tabProducts.Controls.Add(this.groupPrices);
            this.tabProducts.Controls.Add(this.groupProducts);
            this.tabProducts.Controls.Add(this.groupCategory);
            this.tabProducts.Location = new System.Drawing.Point(8, 39);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1325, 794);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Продукти";
            this.tabProducts.UseVisualStyleBackColor = true;
            this.tabProducts.Click += new System.EventHandler(this.tabProducts_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gridProducts.Location = new System.Drawing.Point(10, 456);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersWidth = 82;
            this.gridProducts.RowTemplate.Height = 33;
            this.gridProducts.Size = new System.Drawing.Size(1070, 200);
            this.gridProducts.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Продукт";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Мярка";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Количество";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Категория";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Единична цена";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Крайна цена";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Delete ";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Запис";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupPrices
            // 
            this.groupPrices.Controls.Add(this.label4);
            this.groupPrices.Controls.Add(this.lblPricePerUnit);
            this.groupPrices.Controls.Add(this.txtFinalPrice);
            this.groupPrices.Controls.Add(this.txtUnitPrice);
            this.groupPrices.Controls.Add(this.label2);
            this.groupPrices.Controls.Add(this.label1);
            this.groupPrices.Controls.Add(this.numericQty);
            this.groupPrices.Controls.Add(this.labelQuantity);
            this.groupPrices.Controls.Add(this.comboMeasure);
            this.groupPrices.Controls.Add(this.labelMeasure);
            this.groupPrices.Location = new System.Drawing.Point(730, 20);
            this.groupPrices.Name = "groupPrices";
            this.groupPrices.Size = new System.Drawing.Size(350, 310);
            this.groupPrices.TabIndex = 2;
            this.groupPrices.TabStop = false;
            this.groupPrices.Text = "Мярка / Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "лв.";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Location = new System.Drawing.Point(287, 152);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(78, 25);
            this.lblPricePerUnit.TabIndex = 8;
            this.lblPricePerUnit.Text = "лв. / кг";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(170, 202);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.Size = new System.Drawing.Size(100, 31);
            this.txtFinalPrice.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(181, 152);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 31);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Крайна цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Единична цена:";
            // 
            // numericQty
            // 
            this.numericQty.Location = new System.Drawing.Point(196, 70);
            this.numericQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQty.Name = "numericQty";
            this.numericQty.Size = new System.Drawing.Size(95, 31);
            this.numericQty.TabIndex = 3;
            this.numericQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(191, 40);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(129, 25);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Количество";
            // 
            // comboMeasure
            // 
            this.comboMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMeasure.FormattingEnabled = true;
            this.comboMeasure.Location = new System.Drawing.Point(22, 68);
            this.comboMeasure.Name = "comboMeasure";
            this.comboMeasure.Size = new System.Drawing.Size(120, 33);
            this.comboMeasure.TabIndex = 1;
            // 
            // labelMeasure
            // 
            this.labelMeasure.AutoSize = true;
            this.labelMeasure.Location = new System.Drawing.Point(17, 40);
            this.labelMeasure.Name = "labelMeasure";
            this.labelMeasure.Size = new System.Drawing.Size(76, 25);
            this.labelMeasure.TabIndex = 0;
            this.labelMeasure.Text = "Мярка";
            // 
            // groupProducts
            // 
            this.groupProducts.Controls.Add(this.btnClear);
            this.groupProducts.Controls.Add(this.checkedProducts);
            this.groupProducts.Controls.Add(this.btnSelect);
            this.groupProducts.Location = new System.Drawing.Point(370, 20);
            this.groupProducts.Name = "groupProducts";
            this.groupProducts.Size = new System.Drawing.Size(350, 310);
            this.groupProducts.TabIndex = 1;
            this.groupProducts.TabStop = false;
            this.groupProducts.Text = "Продукти";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // checkedProducts
            // 
            this.checkedProducts.FormattingEnabled = true;
            this.checkedProducts.Location = new System.Drawing.Point(43, 40);
            this.checkedProducts.Name = "checkedProducts";
            this.checkedProducts.Size = new System.Drawing.Size(200, 200);
            this.checkedProducts.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(22, 246);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 39);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Избери";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupCategory
            // 
            this.groupCategory.Controls.Add(this.comboCategory);
            this.groupCategory.Location = new System.Drawing.Point(10, 20);
            this.groupCategory.Name = "groupCategory";
            this.groupCategory.Size = new System.Drawing.Size(350, 310);
            this.groupCategory.TabIndex = 0;
            this.groupCategory.TabStop = false;
            this.groupCategory.Text = "Категория";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(20, 40);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(200, 33);
            this.comboCategory.TabIndex = 0;
            // 
            // tabDelivery
            // 
            this.tabDelivery.Controls.Add(this.btnCancelOrder);
            this.tabDelivery.Controls.Add(this.btnSendOrder);
            this.tabDelivery.Controls.Add(this.groupPayment);
            this.tabDelivery.Controls.Add(this.numericAddrNum);
            this.tabDelivery.Controls.Add(this.txtAddress);
            this.tabDelivery.Controls.Add(this.label9);
            this.tabDelivery.Controls.Add(this.label8);
            this.tabDelivery.Controls.Add(this.label7);
            this.tabDelivery.Controls.Add(this.label6);
            this.tabDelivery.Controls.Add(this.label5);
            this.tabDelivery.Controls.Add(this.comboCity);
            this.tabDelivery.Controls.Add(this.comboRegion);
            this.tabDelivery.Controls.Add(this.comboCountry);
            this.tabDelivery.Controls.Add(this.label3);
            this.tabDelivery.Controls.Add(this.comboDeliveryCompany);
            this.tabDelivery.Controls.Add(this.groupDeliveryMethod);
            this.tabDelivery.Location = new System.Drawing.Point(8, 39);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelivery.Size = new System.Drawing.Size(1325, 794);
            this.tabDelivery.TabIndex = 1;
            this.tabDelivery.Text = "Доставки";
            this.tabDelivery.UseVisualStyleBackColor = true;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.btnCancelFinal);
            this.tabOrders.Controls.Add(this.btnSendFinal);
            this.tabOrders.Controls.Add(this.gridOrders);
            this.tabOrders.Location = new System.Drawing.Point(8, 39);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(1325, 794);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "Поръчки";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // groupDeliveryMethod
            // 
            this.groupDeliveryMethod.Controls.Add(this.radioToAddress);
            this.groupDeliveryMethod.Controls.Add(this.radioToOffice);
            this.groupDeliveryMethod.Location = new System.Drawing.Point(10, 10);
            this.groupDeliveryMethod.Name = "groupDeliveryMethod";
            this.groupDeliveryMethod.Size = new System.Drawing.Size(546, 181);
            this.groupDeliveryMethod.TabIndex = 0;
            this.groupDeliveryMethod.TabStop = false;
            this.groupDeliveryMethod.Text = "Метод на доставка";
            // 
            // radioToOffice
            // 
            this.radioToOffice.AutoSize = true;
            this.radioToOffice.Checked = true;
            this.radioToOffice.Location = new System.Drawing.Point(0, 48);
            this.radioToOffice.Name = "radioToOffice";
            this.radioToOffice.Size = new System.Drawing.Size(341, 29);
            this.radioToOffice.TabIndex = 0;
            this.radioToOffice.TabStop = true;
            this.radioToOffice.Text = "До офис на фирма доставчик";
            this.radioToOffice.UseVisualStyleBackColor = true;
            // 
            // radioToAddress
            // 
            this.radioToAddress.AutoSize = true;
            this.radioToAddress.Location = new System.Drawing.Point(347, 48);
            this.radioToAddress.Name = "radioToAddress";
            this.radioToAddress.Size = new System.Drawing.Size(201, 29);
            this.radioToAddress.TabIndex = 1;
            this.radioToAddress.Text = "До личен адрес";
            this.radioToAddress.UseVisualStyleBackColor = true;
            // 
            // comboDeliveryCompany
            // 
            this.comboDeliveryCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeliveryCompany.FormattingEnabled = true;
            this.comboDeliveryCompany.Location = new System.Drawing.Point(207, 233);
            this.comboDeliveryCompany.Name = "comboDeliveryCompany";
            this.comboDeliveryCompany.Size = new System.Drawing.Size(150, 33);
            this.comboDeliveryCompany.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фирма доставчик:";
            // 
            // comboCountry
            // 
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(218, 364);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(173, 33);
            this.comboCountry.TabIndex = 3;
            // 
            // comboRegion
            // 
            this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(552, 364);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(192, 33);
            this.comboRegion.TabIndex = 4;
            // 
            // comboCity
            // 
            this.comboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(1013, 364);
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(294, 33);
            this.comboCity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Държава:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Област:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Град/Село:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Адрес:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(933, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "№:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 475);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(585, 31);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Text = "Въведете адрес на офис....";
            // 
            // numericAddrNum
            // 
            this.numericAddrNum.Location = new System.Drawing.Point(991, 479);
            this.numericAddrNum.Name = "numericAddrNum";
            this.numericAddrNum.Size = new System.Drawing.Size(120, 31);
            this.numericAddrNum.TabIndex = 14;
            // 
            // groupPayment
            // 
            this.groupPayment.Controls.Add(this.radioCard);
            this.groupPayment.Controls.Add(this.radioBank);
            this.groupPayment.Controls.Add(this.radioCash);
            this.groupPayment.Location = new System.Drawing.Point(11, 583);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(535, 121);
            this.groupPayment.TabIndex = 15;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "Метод на плащане:";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(6, 57);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(212, 29);
            this.radioCash.TabIndex = 0;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Наложен платеж";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioBank
            // 
            this.radioBank.AutoSize = true;
            this.radioBank.Location = new System.Drawing.Point(224, 57);
            this.radioBank.Name = "radioBank";
            this.radioBank.Size = new System.Drawing.Size(187, 29);
            this.radioBank.TabIndex = 1;
            this.radioBank.TabStop = true;
            this.radioBank.Text = "По банков път";
            this.radioBank.UseVisualStyleBackColor = true;
            // 
            // radioCard
            // 
            this.radioCard.AutoSize = true;
            this.radioCard.Location = new System.Drawing.Point(408, 57);
            this.radioCard.Name = "radioCard";
            this.radioCard.Size = new System.Drawing.Size(121, 29);
            this.radioCard.TabIndex = 2;
            this.radioCard.TabStop = true;
            this.radioCard.Text = "С карта";
            this.radioCard.UseVisualStyleBackColor = true;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOrder.Location = new System.Drawing.Point(17, 724);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(311, 48);
            this.btnSendOrder.TabIndex = 16;
            this.btnSendOrder.Text = "Изпрати заявката";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelOrder.Location = new System.Drawing.Point(975, 724);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(285, 54);
            this.btnCancelOrder.TabIndex = 17;
            this.btnCancelOrder.Text = "Откажи заявката";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // gridOrders
            // 
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.gridOrders.Location = new System.Drawing.Point(6, 6);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.RowHeadersWidth = 82;
            this.gridOrders.RowTemplate.Height = 33;
            this.gridOrders.Size = new System.Drawing.Size(1313, 693);
            this.gridOrders.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Продукт";
            this.Column10.MinimumWidth = 10;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Мярка";
            this.Column11.MinimumWidth = 10;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Количество";
            this.Column12.MinimumWidth = 10;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Ед. цена";
            this.Column13.MinimumWidth = 10;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Крайна цена";
            this.Column14.MinimumWidth = 10;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Метод доставка";
            this.Column15.MinimumWidth = 10;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Доставчик";
            this.Column16.MinimumWidth = 10;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Адрес";
            this.Column17.MinimumWidth = 10;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Плащане";
            this.Column18.MinimumWidth = 10;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // btnSendFinal
            // 
            this.btnSendFinal.BackColor = System.Drawing.Color.LightGray;
            this.btnSendFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFinal.Location = new System.Drawing.Point(36, 719);
            this.btnSendFinal.Name = "btnSendFinal";
            this.btnSendFinal.Size = new System.Drawing.Size(290, 54);
            this.btnSendFinal.TabIndex = 1;
            this.btnSendFinal.Text = "Изпрати заявката";
            this.btnSendFinal.UseVisualStyleBackColor = false;
            // 
            // btnCancelFinal
            // 
            this.btnCancelFinal.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFinal.Location = new System.Drawing.Point(960, 722);
            this.btnCancelFinal.Name = "btnCancelFinal";
            this.btnCancelFinal.Size = new System.Drawing.Size(296, 48);
            this.btnCancelFinal.TabIndex = 2;
            this.btnCancelFinal.Text = "Откажи заявката";
            this.btnCancelFinal.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 841);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.groupPrices.ResumeLayout(false);
            this.groupPrices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQty)).EndInit();
            this.groupProducts.ResumeLayout(false);
            this.groupCategory.ResumeLayout(false);
            this.tabDelivery.ResumeLayout(false);
            this.tabDelivery.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            this.groupDeliveryMethod.ResumeLayout(false);
            this.groupDeliveryMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddrNum)).EndInit();
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabDelivery;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.GroupBox groupCategory;
        private System.Windows.Forms.GroupBox groupProducts;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckedListBox checkedProducts;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupPrices;
        private System.Windows.Forms.ComboBox comboMeasure;
        private System.Windows.Forms.Label labelMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericQty;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.GroupBox groupDeliveryMethod;
        private System.Windows.Forms.ComboBox comboDeliveryCompany;
        private System.Windows.Forms.RadioButton radioToAddress;
        private System.Windows.Forms.RadioButton radioToOffice;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.NumericUpDown numericAddrNum;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.RadioButton radioCard;
        private System.Windows.Forms.RadioButton radioBank;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.Button btnCancelFinal;
        private System.Windows.Forms.Button btnSendFinal;
    }
}

