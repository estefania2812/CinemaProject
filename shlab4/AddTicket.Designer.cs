namespace shlab4
{
    partial class AddTicket
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
            this.ticketNumber_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seat_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resNum_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number";
            // 
            // ticketNumber_textBox
            // 
            this.ticketNumber_textBox.Location = new System.Drawing.Point(115, 31);
            this.ticketNumber_textBox.Name = "ticketNumber_textBox";
            this.ticketNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.ticketNumber_textBox.TabIndex = 1;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(296, 376);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(169, 376);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seat Number";
            // 
            // seat_textBox
            // 
            this.seat_textBox.Location = new System.Drawing.Point(115, 93);
            this.seat_textBox.Name = "seat_textBox";
            this.seat_textBox.Size = new System.Drawing.Size(100, 20);
            this.seat_textBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservation Number";
            // 
            // resNum_comboBox
            // 
            this.resNum_comboBox.FormattingEnabled = true;
            this.resNum_comboBox.Location = new System.Drawing.Point(397, 31);
            this.resNum_comboBox.Name = "resNum_comboBox";
            this.resNum_comboBox.Size = new System.Drawing.Size(121, 21);
            this.resNum_comboBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 215);
            this.dataGridView1.TabIndex = 36;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 433);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resNum_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seat_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.ticketNumber_textBox);
            this.Controls.Add(this.label1);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticketNumber_textBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seat_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox resNum_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}