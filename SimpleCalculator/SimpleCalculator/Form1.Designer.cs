namespace SimpleCalculator
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
            this.textBoxNumLeft = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.labelPlusSymbol = new System.Windows.Forms.Label();
            this.textBoxNumRight = new System.Windows.Forms.TextBox();
            this.labelEqual = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumLeft
            // 
            this.textBoxNumLeft.Font = new System.Drawing.Font("Times New Roman", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumLeft.Location = new System.Drawing.Point(12, 121);
            this.textBoxNumLeft.Name = "textBoxNumLeft";
            this.textBoxNumLeft.Size = new System.Drawing.Size(72, 57);
            this.textBoxNumLeft.TabIndex = 0;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // labelPlusSymbol
            // 
            this.labelPlusSymbol.AutoSize = true;
            this.labelPlusSymbol.Font = new System.Drawing.Font("Arial Narrow", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlusSymbol.Location = new System.Drawing.Point(130, 122);
            this.labelPlusSymbol.Name = "labelPlusSymbol";
            this.labelPlusSymbol.Size = new System.Drawing.Size(43, 52);
            this.labelPlusSymbol.TabIndex = 1;
            this.labelPlusSymbol.Text = "+";
            // 
            // textBoxNumRight
            // 
            this.textBoxNumRight.Font = new System.Drawing.Font("Times New Roman", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumRight.Location = new System.Drawing.Point(242, 121);
            this.textBoxNumRight.Name = "textBoxNumRight";
            this.textBoxNumRight.Size = new System.Drawing.Size(67, 57);
            this.textBoxNumRight.TabIndex = 2;
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.Font = new System.Drawing.Font("Arial Narrow", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEqual.Location = new System.Drawing.Point(394, 132);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(43, 52);
            this.labelEqual.TabIndex = 3;
            this.labelEqual.Text = "=";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.Color.Green;
            this.textBoxResult.Location = new System.Drawing.Point(511, 131);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(78, 57);
            this.textBoxResult.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Yellow;
            this.buttonCalculate.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Blue;
            this.buttonCalculate.Location = new System.Drawing.Point(98, 240);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(265, 56);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(98, 302);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(265, 60);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear Screen";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 607);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelEqual);
            this.Controls.Add(this.textBoxNumRight);
            this.Controls.Add(this.labelPlusSymbol);
            this.Controls.Add(this.textBoxNumLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumLeft;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox textBoxNumRight;
        private System.Windows.Forms.Label labelPlusSymbol;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelEqual;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

