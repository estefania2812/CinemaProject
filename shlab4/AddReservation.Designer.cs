namespace shlab4
{
    partial class AddReservation
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
            this.clientId_comboBox = new System.Windows.Forms.ComboBox();
            this.resNum_textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(152, 192);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(55, 192);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // clientId_comboBox
            // 
            this.clientId_comboBox.FormattingEnabled = true;
            this.clientId_comboBox.Location = new System.Drawing.Point(129, 107);
            this.clientId_comboBox.Name = "clientId_comboBox";
            this.clientId_comboBox.Size = new System.Drawing.Size(121, 21);
            this.clientId_comboBox.TabIndex = 2;
            // 
            // resNum_textBox
            // 
            this.resNum_textBox.Location = new System.Drawing.Point(129, 53);
            this.resNum_textBox.Name = "resNum_textBox";
            this.resNum_textBox.Size = new System.Drawing.Size(100, 20);
            this.resNum_textBox.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Reservation Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Id";
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.resNum_textBox);
            this.Controls.Add(this.clientId_comboBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.back_button);
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox clientId_comboBox;
        private System.Windows.Forms.TextBox resNum_textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
    }
}