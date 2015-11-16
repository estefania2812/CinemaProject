namespace shlab4
{
    partial class DeleteReservation
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
            this.deleteRes_button = new System.Windows.Forms.Button();
            this.Res_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteRes_button
            // 
            this.deleteRes_button.Location = new System.Drawing.Point(39, 147);
            this.deleteRes_button.Name = "deleteRes_button";
            this.deleteRes_button.Size = new System.Drawing.Size(75, 23);
            this.deleteRes_button.TabIndex = 0;
            this.deleteRes_button.Text = "Delete";
            this.deleteRes_button.UseVisualStyleBackColor = true;
            this.deleteRes_button.Click += new System.EventHandler(this.deleteRes_button_Click);
            // 
            // Res_comboBox
            // 
            this.Res_comboBox.FormattingEnabled = true;
            this.Res_comboBox.Location = new System.Drawing.Point(130, 64);
            this.Res_comboBox.Name = "Res_comboBox";
            this.Res_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Res_comboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a Reservation";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(142, 147);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.UseWaitCursor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // DeleteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Res_comboBox);
            this.Controls.Add(this.deleteRes_button);
            this.Name = "DeleteReservation";
            this.Text = "DeleteReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteRes_button;
        private System.Windows.Forms.ComboBox Res_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
    }
}