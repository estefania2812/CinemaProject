namespace shlab4
{
    partial class AddScreen
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
            this.Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.room_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.movieNum_comboBox = new System.Windows.Forms.ComboBox();
            this.seats_textBox = new System.Windows.Forms.TextBox();
            this.Hour_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(267, 238);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(160, 238);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Screen Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movie Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reserved Seats";
            // 
            // room_textBox
            // 
            this.room_textBox.Location = new System.Drawing.Point(368, 40);
            this.room_textBox.Name = "room_textBox";
            this.room_textBox.Size = new System.Drawing.Size(100, 20);
            this.room_textBox.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "DD/MM/YYYY";
            this.dateTimePicker.Location = new System.Drawing.Point(84, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // movieNum_comboBox
            // 
            this.movieNum_comboBox.FormattingEnabled = true;
            this.movieNum_comboBox.Location = new System.Drawing.Point(114, 164);
            this.movieNum_comboBox.Name = "movieNum_comboBox";
            this.movieNum_comboBox.Size = new System.Drawing.Size(121, 21);
            this.movieNum_comboBox.TabIndex = 11;
            // 
            // seats_textBox
            // 
            this.seats_textBox.Location = new System.Drawing.Point(368, 100);
            this.seats_textBox.Name = "seats_textBox";
            this.seats_textBox.Size = new System.Drawing.Size(100, 20);
            this.seats_textBox.TabIndex = 12;
            // 
            // Hour_comboBox
            // 
            this.Hour_comboBox.FormattingEnabled = true;
            this.Hour_comboBox.Location = new System.Drawing.Point(114, 99);
            this.Hour_comboBox.Name = "Hour_comboBox";
            this.Hour_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Hour_comboBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Choose an Hour";
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(490, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hour_comboBox);
            this.Controls.Add(this.seats_textBox);
            this.Controls.Add(this.movieNum_comboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.room_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.back_button);
            this.Name = "AddScreen";
            this.Text = "AddScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox room_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox movieNum_comboBox;
        private System.Windows.Forms.TextBox seats_textBox;
        private System.Windows.Forms.ComboBox Hour_comboBox;
        private System.Windows.Forms.Label label5;
    }
}