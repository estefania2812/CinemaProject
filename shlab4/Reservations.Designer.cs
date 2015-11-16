namespace shlab4
{
    partial class Reservations
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
            this.addReservation_button = new System.Windows.Forms.Button();
            this.deleteReservation_button = new System.Windows.Forms.Button();
            this.TicketsForRes_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addReservation_button
            // 
            this.addReservation_button.Location = new System.Drawing.Point(41, 45);
            this.addReservation_button.Name = "addReservation_button";
            this.addReservation_button.Size = new System.Drawing.Size(75, 23);
            this.addReservation_button.TabIndex = 0;
            this.addReservation_button.Text = "Add";
            this.addReservation_button.UseVisualStyleBackColor = true;
            this.addReservation_button.Click += new System.EventHandler(this.addReservation_button_Click);
            // 
            // deleteReservation_button
            // 
            this.deleteReservation_button.Location = new System.Drawing.Point(41, 104);
            this.deleteReservation_button.Name = "deleteReservation_button";
            this.deleteReservation_button.Size = new System.Drawing.Size(75, 23);
            this.deleteReservation_button.TabIndex = 1;
            this.deleteReservation_button.Text = "Delete";
            this.deleteReservation_button.UseVisualStyleBackColor = true;
            this.deleteReservation_button.Click += new System.EventHandler(this.deleteReservation_button_Click);
            // 
            // TicketsForRes_button
            // 
            this.TicketsForRes_button.Location = new System.Drawing.Point(41, 167);
            this.TicketsForRes_button.Name = "TicketsForRes_button";
            this.TicketsForRes_button.Size = new System.Drawing.Size(75, 39);
            this.TicketsForRes_button.TabIndex = 2;
            this.TicketsForRes_button.Text = "Tickets for Reservation";
            this.TicketsForRes_button.UseVisualStyleBackColor = true;
            this.TicketsForRes_button.UseWaitCursor = true;
            this.TicketsForRes_button.Click += new System.EventHandler(this.TicketsForRes_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(175, 215);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.TicketsForRes_button);
            this.Controls.Add(this.deleteReservation_button);
            this.Controls.Add(this.addReservation_button);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addReservation_button;
        private System.Windows.Forms.Button deleteReservation_button;
        private System.Windows.Forms.Button TicketsForRes_button;
        private System.Windows.Forms.Button back_button;
    }
}