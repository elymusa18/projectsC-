namespace ForeignWordsSynonyms
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
            this.labelWord = new System.Windows.Forms.Label();
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.labelSynonyms = new System.Windows.Forms.Label();
            this.textBoxSynonyms = new System.Windows.Forms.TextBox();
            this.labelNewSynonym = new System.Windows.Forms.Label();
            this.textBoxNewSynonym = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxSuggestions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(43, 44);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(170, 25);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "Изберете дума:";
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Location = new System.Drawing.Point(233, 44);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(122, 33);
            this.comboBoxWords.TabIndex = 1;
            this.comboBoxWords.SelectedIndexChanged += new System.EventHandler(this.comboBoxWords_SelectedIndexChanged);
            // 
            // labelSynonyms
            // 
            this.labelSynonyms.AutoSize = true;
            this.labelSynonyms.Location = new System.Drawing.Point(43, 106);
            this.labelSynonyms.Name = "labelSynonyms";
            this.labelSynonyms.Size = new System.Drawing.Size(120, 25);
            this.labelSynonyms.TabIndex = 2;
            this.labelSynonyms.Text = "Синоними:";
            // 
            // textBoxSynonyms
            // 
            this.textBoxSynonyms.Location = new System.Drawing.Point(233, 100);
            this.textBoxSynonyms.Name = "textBoxSynonyms";
            this.textBoxSynonyms.Size = new System.Drawing.Size(122, 31);
            this.textBoxSynonyms.TabIndex = 3;
            // 
            // labelNewSynonym
            // 
            this.labelNewSynonym.AutoSize = true;
            this.labelNewSynonym.Location = new System.Drawing.Point(43, 187);
            this.labelNewSynonym.Name = "labelNewSynonym";
            this.labelNewSynonym.Size = new System.Drawing.Size(148, 25);
            this.labelNewSynonym.TabIndex = 4;
            this.labelNewSynonym.Text = "Нов синоним:";
            // 
            // textBoxNewSynonym
            // 
            this.textBoxNewSynonym.Location = new System.Drawing.Point(233, 187);
            this.textBoxNewSynonym.Name = "textBoxNewSynonym";
            this.textBoxNewSynonym.Size = new System.Drawing.Size(122, 31);
            this.textBoxNewSynonym.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.Location = new System.Drawing.Point(418, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 38);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.ItemHeight = 25;
            this.listBoxSuggestions.Location = new System.Drawing.Point(48, 250);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(165, 54);
            this.listBoxSuggestions.TabIndex = 7;
            this.listBoxSuggestions.SelectedIndexChanged += new System.EventHandler(this.listBoxSuggestions_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 641);
            this.Controls.Add(this.listBoxSuggestions);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewSynonym);
            this.Controls.Add(this.labelNewSynonym);
            this.Controls.Add(this.textBoxSynonyms);
            this.Controls.Add(this.labelSynonyms);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.labelWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.ComboBox comboBoxWords;
        private System.Windows.Forms.Label labelSynonyms;
        private System.Windows.Forms.TextBox textBoxSynonyms;
        private System.Windows.Forms.Label labelNewSynonym;
        private System.Windows.Forms.TextBox textBoxNewSynonym;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxSuggestions;
    }
}

