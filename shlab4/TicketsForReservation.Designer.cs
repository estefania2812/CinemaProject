namespace shlab4
{
    partial class TicketsForReservation
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
            this.resNum_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tickets_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Number";
            // 
            // resNum_comboBox
            // 
            this.resNum_comboBox.FormattingEnabled = true;
            this.resNum_comboBox.Location = new System.Drawing.Point(138, 52);
            this.resNum_comboBox.Name = "resNum_comboBox";
            this.resNum_comboBox.Size = new System.Drawing.Size(121, 21);
            this.resNum_comboBox.TabIndex = 1;
            this.resNum_comboBox.SelectedIndexChanged += new System.EventHandler(this.resNum_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tickets ";
            // 
            // tickets_textBox
            // 
            this.tickets_textBox.Location = new System.Drawing.Point(138, 119);
            this.tickets_textBox.Name = "tickets_textBox";
            this.tickets_textBox.Size = new System.Drawing.Size(100, 20);
            this.tickets_textBox.TabIndex = 3;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(184, 208);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 26);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // TicketsForReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.tickets_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resNum_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "TicketsForReservation";
            this.Text = "TicketsForReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox resNum_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tickets_textBox;
        private System.Windows.Forms.Button back_button;
    }
}