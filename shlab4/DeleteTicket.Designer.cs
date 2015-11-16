namespace shlab4
{
    partial class DeleteTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.TicketToDelete_comboBox = new System.Windows.Forms.ComboBox();
            this.DeleteTicket_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(164, 164);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose a ticket";
            // 
            // TicketToDelete_comboBox
            // 
            this.TicketToDelete_comboBox.FormattingEnabled = true;
            this.TicketToDelete_comboBox.Location = new System.Drawing.Point(135, 75);
            this.TicketToDelete_comboBox.Name = "TicketToDelete_comboBox";
            this.TicketToDelete_comboBox.Size = new System.Drawing.Size(121, 21);
            this.TicketToDelete_comboBox.TabIndex = 5;
            // 
            // DeleteTicket_button
            // 
            this.DeleteTicket_button.Location = new System.Drawing.Point(65, 164);
            this.DeleteTicket_button.Name = "DeleteTicket_button";
            this.DeleteTicket_button.Size = new System.Drawing.Size(75, 23);
            this.DeleteTicket_button.TabIndex = 4;
            this.DeleteTicket_button.Text = "Delete";
            this.DeleteTicket_button.UseVisualStyleBackColor = true;
            this.DeleteTicket_button.Click += new System.EventHandler(this.DeleteTicket_button_Click);
            // 
            // DeleteTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketToDelete_comboBox);
            this.Controls.Add(this.DeleteTicket_button);
            this.Name = "DeleteTicket";
            this.Text = "DeleteTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TicketToDelete_comboBox;
        private System.Windows.Forms.Button DeleteTicket_button;
    }
}