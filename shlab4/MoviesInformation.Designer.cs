namespace shlab4
{
    partial class MoviesInformation
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
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseMovie_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.income_textBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.seeIncome_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(253, 432);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a movie";
            // 
            // chooseMovie_comboBox
            // 
            this.chooseMovie_comboBox.FormattingEnabled = true;
            this.chooseMovie_comboBox.Location = new System.Drawing.Point(116, 40);
            this.chooseMovie_comboBox.Name = "chooseMovie_comboBox";
            this.chooseMovie_comboBox.Size = new System.Drawing.Size(121, 21);
            this.chooseMovie_comboBox.TabIndex = 2;
            this.chooseMovie_comboBox.SelectedIndexChanged += new System.EventHandler(this.chooseMovie_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dates";
            // 
            // income_textBox
            // 
            this.income_textBox.Location = new System.Drawing.Point(168, 351);
            this.income_textBox.Name = "income_textBox";
            this.income_textBox.Size = new System.Drawing.Size(100, 20);
            this.income_textBox.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(90, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(223, 234);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // seeIncome_checkBox
            // 
            this.seeIncome_checkBox.AutoSize = true;
            this.seeIncome_checkBox.Location = new System.Drawing.Point(60, 353);
            this.seeIncome_checkBox.Name = "seeIncome_checkBox";
            this.seeIncome_checkBox.Size = new System.Drawing.Size(83, 17);
            this.seeIncome_checkBox.TabIndex = 7;
            this.seeIncome_checkBox.Text = "See Income";
            this.seeIncome_checkBox.UseVisualStyleBackColor = true;
            this.seeIncome_checkBox.CheckedChanged += new System.EventHandler(this.checkedChanged1);
            // 
            // MoviesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(360, 490);
            this.Controls.Add(this.seeIncome_checkBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.income_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseMovie_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Name = "MoviesInformation";
            this.Text = "MoviesInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseMovie_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox income_textBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox seeIncome_checkBox;
    }
}