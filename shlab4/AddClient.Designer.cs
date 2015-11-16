namespace shlab4
{
    partial class AddClient
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
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.LName_textBox = new System.Windows.Forms.TextBox();
            this.FName_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(299, 271);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(147, 271);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Id";
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(110, 38);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.Size = new System.Drawing.Size(100, 20);
            this.Id_textBox.TabIndex = 3;
            // 
            // LName_textBox
            // 
            this.LName_textBox.Location = new System.Drawing.Point(110, 87);
            this.LName_textBox.Name = "LName_textBox";
            this.LName_textBox.Size = new System.Drawing.Size(100, 20);
            this.LName_textBox.TabIndex = 4;
            // 
            // FName_textBox
            // 
            this.FName_textBox.Location = new System.Drawing.Point(110, 137);
            this.FName_textBox.Name = "FName_textBox";
            this.FName_textBox.Size = new System.Drawing.Size(100, 20);
            this.FName_textBox.TabIndex = 5;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(102, 193);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(100, 20);
            this.Phone_textBox.TabIndex = 6;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(340, 41);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(100, 20);
            this.email_textBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birthdate";
            // 
            // birthdate_dateTimePicker
            // 
            this.birthdate_dateTimePicker.Location = new System.Drawing.Point(340, 143);
            this.birthdate_dateTimePicker.Name = "birthdate_dateTimePicker";
            this.birthdate_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdate_dateTimePicker.TabIndex = 13;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(563, 329);
            this.Controls.Add(this.birthdate_dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.FName_textBox);
            this.Controls.Add(this.LName_textBox);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.back_button);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.TextBox LName_textBox;
        private System.Windows.Forms.TextBox FName_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birthdate_dateTimePicker;
    }
}