namespace shlab4
{
    partial class UpdateMovie
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
            this.exit_button2 = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.movieNumber_comboBox = new System.Windows.Forms.ComboBox();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.actors_textBox = new System.Windows.Forms.TextBox();
            this.rate_comboBox = new System.Windows.Forms.ComboBox();
            this.genre_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exit_button2
            // 
            this.exit_button2.BackColor = System.Drawing.Color.White;
            this.exit_button2.Location = new System.Drawing.Point(357, 386);
            this.exit_button2.Name = "exit_button2";
            this.exit_button2.Size = new System.Drawing.Size(91, 26);
            this.exit_button2.TabIndex = 2;
            this.exit_button2.Text = "Back";
            this.exit_button2.UseVisualStyleBackColor = false;
            this.exit_button2.Click += new System.EventHandler(this.exit_button2_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.White;
            this.confirm_button.Location = new System.Drawing.Point(228, 386);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_button.TabIndex = 3;
            this.confirm_button.Text = "Update";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movie Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Actors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rate";
            // 
            // movieNumber_comboBox
            // 
            this.movieNumber_comboBox.FormattingEnabled = true;
            this.movieNumber_comboBox.Location = new System.Drawing.Point(154, 84);
            this.movieNumber_comboBox.Name = "movieNumber_comboBox";
            this.movieNumber_comboBox.Size = new System.Drawing.Size(121, 21);
            this.movieNumber_comboBox.TabIndex = 11;
            this.movieNumber_comboBox.SelectedIndexChanged += new System.EventHandler(this.movieNumber_comboBox_SelectedIndexChanged);
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(154, 167);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(166, 20);
            this.title_textBox.TabIndex = 13;
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(154, 205);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(437, 97);
            this.description_richTextBox.TabIndex = 14;
            this.description_richTextBox.Text = "";
            // 
            // actors_textBox
            // 
            this.actors_textBox.Location = new System.Drawing.Point(416, 84);
            this.actors_textBox.Name = "actors_textBox";
            this.actors_textBox.Size = new System.Drawing.Size(175, 20);
            this.actors_textBox.TabIndex = 15;
            // 
            // rate_comboBox
            // 
            this.rate_comboBox.FormattingEnabled = true;
            this.rate_comboBox.Location = new System.Drawing.Point(416, 140);
            this.rate_comboBox.Name = "rate_comboBox";
            this.rate_comboBox.Size = new System.Drawing.Size(63, 21);
            this.rate_comboBox.TabIndex = 16;
            // 
            // genre_comboBox
            // 
            this.genre_comboBox.FormattingEnabled = true;
            this.genre_comboBox.Location = new System.Drawing.Point(154, 126);
            this.genre_comboBox.Name = "genre_comboBox";
            this.genre_comboBox.Size = new System.Drawing.Size(121, 21);
            this.genre_comboBox.TabIndex = 17;
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.genre_comboBox);
            this.Controls.Add(this.rate_comboBox);
            this.Controls.Add(this.actors_textBox);
            this.Controls.Add(this.description_richTextBox);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.movieNumber_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.exit_button2);
            this.Name = "UpdateMovie";
            this.Text = "Update Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button2;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox movieNumber_comboBox;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.TextBox actors_textBox;
        private System.Windows.Forms.ComboBox rate_comboBox;
        private System.Windows.Forms.ComboBox genre_comboBox;
    }
}