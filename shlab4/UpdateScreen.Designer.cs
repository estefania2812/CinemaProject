namespace shlab4
{
    partial class UpdateScreen
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
            this.movieNum_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.seats_textBox = new System.Windows.Forms.TextBox();
            this.room_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieNum_comboBox
            // 
            this.movieNum_comboBox.FormattingEnabled = true;
            this.movieNum_comboBox.Location = new System.Drawing.Point(144, 128);
            this.movieNum_comboBox.Name = "movieNum_comboBox";
            this.movieNum_comboBox.Size = new System.Drawing.Size(121, 21);
            this.movieNum_comboBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Reserved Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Movie Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Screen Date";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(190, 210);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 14;
            this.Add_button.Text = "Update";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(340, 210);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // seats_textBox
            // 
            this.seats_textBox.Location = new System.Drawing.Point(398, 124);
            this.seats_textBox.Name = "seats_textBox";
            this.seats_textBox.Size = new System.Drawing.Size(100, 20);
            this.seats_textBox.TabIndex = 22;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Location = new System.Drawing.Point(395, 61);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(0, 13);
            this.room_label.TabIndex = 24;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(141, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 25;
            // 
            // UpdateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(545, 260);
            this.Controls.Add(this.label);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.seats_textBox);
            this.Controls.Add(this.movieNum_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.back_button);
            this.Name = "UpdateScreen";
            this.Text = "UpdateScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movieNum_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox seats_textBox;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Label label;
    }
}