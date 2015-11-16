namespace shlab4
{
    partial class AddMovie
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
            this.AddMovie_button = new System.Windows.Forms.Button();
            this.MovieNumber_textBox = new System.Windows.Forms.TextBox();
            this.Description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Genre_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.Actors_textBox = new System.Windows.Forms.TextBox();
            this.Rate_comboBox = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Number";
            // 
            // AddMovie_button
            // 
            this.AddMovie_button.Location = new System.Drawing.Point(155, 345);
            this.AddMovie_button.Name = "AddMovie_button";
            this.AddMovie_button.Size = new System.Drawing.Size(75, 23);
            this.AddMovie_button.TabIndex = 1;
            this.AddMovie_button.Text = "Add";
            this.AddMovie_button.UseVisualStyleBackColor = true;
            this.AddMovie_button.Click += new System.EventHandler(this.AddMovie_button_Click);
            // 
            // MovieNumber_textBox
            // 
            this.MovieNumber_textBox.Location = new System.Drawing.Point(103, 54);
            this.MovieNumber_textBox.Name = "MovieNumber_textBox";
            this.MovieNumber_textBox.Size = new System.Drawing.Size(97, 20);
            this.MovieNumber_textBox.TabIndex = 2;
            // 
            // Description_richTextBox
            // 
            this.Description_richTextBox.Location = new System.Drawing.Point(103, 215);
            this.Description_richTextBox.Name = "Description_richTextBox";
            this.Description_richTextBox.Size = new System.Drawing.Size(380, 104);
            this.Description_richTextBox.TabIndex = 3;
            this.Description_richTextBox.Text = "";
            // 
            // Genre_comboBox
            // 
            this.Genre_comboBox.FormattingEnabled = true;
            this.Genre_comboBox.Location = new System.Drawing.Point(103, 104);
            this.Genre_comboBox.Name = "Genre_comboBox";
            this.Genre_comboBox.Size = new System.Drawing.Size(97, 21);
            this.Genre_comboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Actors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Title";
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(103, 165);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(145, 20);
            this.Title_textBox.TabIndex = 10;
            // 
            // Actors_textBox
            // 
            this.Actors_textBox.Location = new System.Drawing.Point(337, 58);
            this.Actors_textBox.Name = "Actors_textBox";
            this.Actors_textBox.Size = new System.Drawing.Size(160, 20);
            this.Actors_textBox.TabIndex = 11;
            // 
            // Rate_comboBox
            // 
            this.Rate_comboBox.FormattingEnabled = true;
            this.Rate_comboBox.Location = new System.Drawing.Point(337, 109);
            this.Rate_comboBox.Name = "Rate_comboBox";
            this.Rate_comboBox.Size = new System.Drawing.Size(97, 21);
            this.Rate_comboBox.TabIndex = 12;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(263, 345);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(527, 403);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Rate_comboBox);
            this.Controls.Add(this.Actors_textBox);
            this.Controls.Add(this.Title_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre_comboBox);
            this.Controls.Add(this.Description_richTextBox);
            this.Controls.Add(this.MovieNumber_textBox);
            this.Controls.Add(this.AddMovie_button);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMovie_button;
        private System.Windows.Forms.TextBox MovieNumber_textBox;
        private System.Windows.Forms.RichTextBox Description_richTextBox;
        private System.Windows.Forms.ComboBox Genre_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.TextBox Actors_textBox;
        private System.Windows.Forms.ComboBox Rate_comboBox;
        private System.Windows.Forms.Button back_button;
    }
}