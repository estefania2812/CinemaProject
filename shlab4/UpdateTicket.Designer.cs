namespace shlab4
{
    partial class UpdateTicket
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
            this.label4 = new System.Windows.Forms.Label();
            this.seat_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketNum_comboBox = new System.Windows.Forms.ComboBox();
            this.room_label = new System.Windows.Forms.Label();
            this.resNum_comboBox = new System.Windows.Forms.ComboBox();
            this.date_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reservation Number";
            // 
            // seat_textBox
            // 
            this.seat_textBox.Location = new System.Drawing.Point(178, 182);
            this.seat_textBox.Name = "seat_textBox";
            this.seat_textBox.Size = new System.Drawing.Size(100, 20);
            this.seat_textBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seat Number";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(224, 453);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(379, 453);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ticket Number";
            // 
            // ticketNum_comboBox
            // 
            this.ticketNum_comboBox.FormattingEnabled = true;
            this.ticketNum_comboBox.Location = new System.Drawing.Point(178, 83);
            this.ticketNum_comboBox.Name = "ticketNum_comboBox";
            this.ticketNum_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ticketNum_comboBox.TabIndex = 27;
            this.ticketNum_comboBox.SelectedIndexChanged += new System.EventHandler(this.ticketNum_comboBox_SelectedIndexChanged);
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Location = new System.Drawing.Point(175, 141);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(0, 13);
            this.room_label.TabIndex = 28;
            // 
            // resNum_comboBox
            // 
            this.resNum_comboBox.FormattingEnabled = true;
            this.resNum_comboBox.Location = new System.Drawing.Point(443, 89);
            this.resNum_comboBox.Name = "resNum_comboBox";
            this.resNum_comboBox.Size = new System.Drawing.Size(121, 21);
            this.resNum_comboBox.TabIndex = 32;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(402, 142);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 13);
            this.date_label.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Current Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Room";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 150);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Show posible dates ad rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(651, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.resNum_comboBox);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.ticketNum_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seat_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTicket";
            this.Text = "UpdateTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seat_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ticketNum_comboBox;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.ComboBox resNum_comboBox;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}