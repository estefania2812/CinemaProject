namespace shlab4
{
    partial class Main
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
            this.tablesView_button = new System.Windows.Forms.Button();
            this.Movies_button = new System.Windows.Forms.Button();
            this.rooms_button = new System.Windows.Forms.Button();
            this.clients_button = new System.Windows.Forms.Button();
            this.tickets_button = new System.Windows.Forms.Button();
            this.reservation_button = new System.Windows.Forms.Button();
            this.screens_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablesView_button
            // 
            this.tablesView_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tablesView_button.Location = new System.Drawing.Point(26, 161);
            this.tablesView_button.Name = "tablesView_button";
            this.tablesView_button.Size = new System.Drawing.Size(93, 32);
            this.tablesView_button.TabIndex = 0;
            this.tablesView_button.Text = "Tables View";
            this.tablesView_button.UseVisualStyleBackColor = false;
            this.tablesView_button.Click += new System.EventHandler(this.tablesView_button_Click);
            // 
            // Movies_button
            // 
            this.Movies_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Movies_button.Location = new System.Drawing.Point(209, 161);
            this.Movies_button.Name = "Movies_button";
            this.Movies_button.Size = new System.Drawing.Size(109, 32);
            this.Movies_button.TabIndex = 1;
            this.Movies_button.Text = "Movies";
            this.Movies_button.UseVisualStyleBackColor = false;
            this.Movies_button.Click += new System.EventHandler(this.Movies_button_Click);
            // 
            // rooms_button
            // 
            this.rooms_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rooms_button.Location = new System.Drawing.Point(397, 226);
            this.rooms_button.Name = "rooms_button";
            this.rooms_button.Size = new System.Drawing.Size(109, 32);
            this.rooms_button.TabIndex = 2;
            this.rooms_button.Text = "Rooms";
            this.rooms_button.UseVisualStyleBackColor = false;
            this.rooms_button.Click += new System.EventHandler(this.rooms_button_Click);
            // 
            // clients_button
            // 
            this.clients_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clients_button.Location = new System.Drawing.Point(26, 226);
            this.clients_button.Name = "clients_button";
            this.clients_button.Size = new System.Drawing.Size(93, 32);
            this.clients_button.TabIndex = 3;
            this.clients_button.Text = "Clients";
            this.clients_button.UseVisualStyleBackColor = false;
            this.clients_button.Click += new System.EventHandler(this.clients_button_Click);
            // 
            // tickets_button
            // 
            this.tickets_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tickets_button.Location = new System.Drawing.Point(209, 226);
            this.tickets_button.Name = "tickets_button";
            this.tickets_button.Size = new System.Drawing.Size(109, 32);
            this.tickets_button.TabIndex = 4;
            this.tickets_button.Text = "Tickets";
            this.tickets_button.UseVisualStyleBackColor = false;
            this.tickets_button.Click += new System.EventHandler(this.tickets_button_Click);
            // 
            // reservation_button
            // 
            this.reservation_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reservation_button.Location = new System.Drawing.Point(397, 161);
            this.reservation_button.Name = "reservation_button";
            this.reservation_button.Size = new System.Drawing.Size(109, 32);
            this.reservation_button.TabIndex = 5;
            this.reservation_button.Text = "Reservations";
            this.reservation_button.UseVisualStyleBackColor = false;
            this.reservation_button.Click += new System.EventHandler(this.reservation_button_Click);
            // 
            // screens_button
            // 
            this.screens_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.screens_button.Location = new System.Drawing.Point(26, 289);
            this.screens_button.Name = "screens_button";
            this.screens_button.Size = new System.Drawing.Size(93, 32);
            this.screens_button.TabIndex = 6;
            this.screens_button.Text = "Screens";
            this.screens_button.UseVisualStyleBackColor = false;
            this.screens_button.Click += new System.EventHandler(this.screens_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exit_button.Location = new System.Drawing.Point(397, 358);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(110, 28);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::shlab4.Properties.Resources.cinema_city;
            this.ClientSize = new System.Drawing.Size(548, 407);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.screens_button);
            this.Controls.Add(this.reservation_button);
            this.Controls.Add(this.tickets_button);
            this.Controls.Add(this.clients_button);
            this.Controls.Add(this.rooms_button);
            this.Controls.Add(this.Movies_button);
            this.Controls.Add(this.tablesView_button);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tablesView_button;
        private System.Windows.Forms.Button Movies_button;
        private System.Windows.Forms.Button rooms_button;
        private System.Windows.Forms.Button clients_button;
        private System.Windows.Forms.Button tickets_button;
        private System.Windows.Forms.Button reservation_button;
        private System.Windows.Forms.Button screens_button;
        private System.Windows.Forms.Button exit_button;
    }
}

