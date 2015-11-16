namespace shlab4
{
    partial class Movies
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
            this.updateMovie_button = new System.Windows.Forms.Button();
            this.AddMovie_button = new System.Windows.Forms.Button();
            this.DeleteMovie_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Types_button = new System.Windows.Forms.Button();
            this.Info_button = new System.Windows.Forms.Button();
            this.see_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateMovie_button
            // 
            this.updateMovie_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateMovie_button.Location = new System.Drawing.Point(85, 30);
            this.updateMovie_button.Name = "updateMovie_button";
            this.updateMovie_button.Size = new System.Drawing.Size(84, 36);
            this.updateMovie_button.TabIndex = 0;
            this.updateMovie_button.Text = "Update";
            this.updateMovie_button.UseVisualStyleBackColor = false;
            this.updateMovie_button.Click += new System.EventHandler(this.updateMovie_button_Click);
            // 
            // AddMovie_button
            // 
            this.AddMovie_button.Location = new System.Drawing.Point(85, 91);
            this.AddMovie_button.Name = "AddMovie_button";
            this.AddMovie_button.Size = new System.Drawing.Size(84, 34);
            this.AddMovie_button.TabIndex = 1;
            this.AddMovie_button.Text = "Add";
            this.AddMovie_button.UseVisualStyleBackColor = true;
            this.AddMovie_button.Click += new System.EventHandler(this.AddMovie_button_Click);
            // 
            // DeleteMovie_button
            // 
            this.DeleteMovie_button.Location = new System.Drawing.Point(85, 150);
            this.DeleteMovie_button.Name = "DeleteMovie_button";
            this.DeleteMovie_button.Size = new System.Drawing.Size(84, 33);
            this.DeleteMovie_button.TabIndex = 2;
            this.DeleteMovie_button.Text = "Delete";
            this.DeleteMovie_button.UseVisualStyleBackColor = true;
            this.DeleteMovie_button.Click += new System.EventHandler(this.DeleteMovie_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Types_button
            // 
            this.Types_button.Location = new System.Drawing.Point(264, 44);
            this.Types_button.Name = "Types_button";
            this.Types_button.Size = new System.Drawing.Size(84, 36);
            this.Types_button.TabIndex = 4;
            this.Types_button.Text = "Movie Types";
            this.Types_button.UseVisualStyleBackColor = true;
            this.Types_button.Click += new System.EventHandler(this.Types_button_Click);
            // 
            // Info_button
            // 
            this.Info_button.Location = new System.Drawing.Point(264, 121);
            this.Info_button.Name = "Info_button";
            this.Info_button.Size = new System.Drawing.Size(84, 36);
            this.Info_button.TabIndex = 5;
            this.Info_button.Text = "Movies Information";
            this.Info_button.UseVisualStyleBackColor = true;
            this.Info_button.Click += new System.EventHandler(this.Info_button_Click);
            // 
            // see_button
            // 
            this.see_button.Location = new System.Drawing.Point(142, 260);
            this.see_button.Name = "see_button";
            this.see_button.Size = new System.Drawing.Size(63, 27);
            this.see_button.TabIndex = 6;
            this.see_button.Text = "See";
            this.see_button.UseVisualStyleBackColor = true;
            this.see_button.Click += new System.EventHandler(this.see_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "The most popular movie at the moment:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 348);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.see_button);
            this.Controls.Add(this.Info_button);
            this.Controls.Add(this.Types_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteMovie_button);
            this.Controls.Add(this.AddMovie_button);
            this.Controls.Add(this.updateMovie_button);
            this.Name = "Movies";
            this.Text = "Movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateMovie_button;
        private System.Windows.Forms.Button AddMovie_button;
        private System.Windows.Forms.Button DeleteMovie_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Types_button;
        private System.Windows.Forms.Button Info_button;
        private System.Windows.Forms.Button see_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}