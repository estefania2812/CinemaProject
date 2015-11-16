namespace shlab4
{
    partial class ShowBirthdays
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
            this.months_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.birthdays_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.birthdays_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // months_comboBox
            // 
            this.months_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.months_comboBox.FormattingEnabled = true;
            this.months_comboBox.Location = new System.Drawing.Point(272, 31);
            this.months_comboBox.Name = "months_comboBox";
            this.months_comboBox.Size = new System.Drawing.Size(121, 21);
            this.months_comboBox.TabIndex = 0;
            this.months_comboBox.SelectedIndexChanged += new System.EventHandler(this.months_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose month";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.back_button.Location = new System.Drawing.Point(480, 313);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // birthdays_dataGridView
            // 
            this.birthdays_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.birthdays_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birthdays_dataGridView.Location = new System.Drawing.Point(29, 80);
            this.birthdays_dataGridView.Name = "birthdays_dataGridView";
            this.birthdays_dataGridView.Size = new System.Drawing.Size(526, 175);
            this.birthdays_dataGridView.TabIndex = 3;
            // 
            // ShowBirthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(587, 357);
            this.Controls.Add(this.birthdays_dataGridView);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.months_comboBox);
            this.Name = "ShowBirthdays";
            this.Text = "ShowBirthdays";
            ((System.ComponentModel.ISupportInitialize)(this.birthdays_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox months_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView birthdays_dataGridView;
    }
}