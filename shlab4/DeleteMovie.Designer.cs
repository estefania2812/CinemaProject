﻿namespace shlab4
{
    partial class DeleteMovie
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
            this.DeleteMovie_button = new System.Windows.Forms.Button();
            this.MovieToDelete_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteMovie_button
            // 
            this.DeleteMovie_button.Location = new System.Drawing.Point(48, 149);
            this.DeleteMovie_button.Name = "DeleteMovie_button";
            this.DeleteMovie_button.Size = new System.Drawing.Size(75, 23);
            this.DeleteMovie_button.TabIndex = 0;
            this.DeleteMovie_button.Text = "Delete";
            this.DeleteMovie_button.UseVisualStyleBackColor = true;
            this.DeleteMovie_button.Click += new System.EventHandler(this.DeleteMovie_button_Click);
            // 
            // MovieToDelete_comboBox
            // 
            this.MovieToDelete_comboBox.FormattingEnabled = true;
            this.MovieToDelete_comboBox.Location = new System.Drawing.Point(118, 60);
            this.MovieToDelete_comboBox.Name = "MovieToDelete_comboBox";
            this.MovieToDelete_comboBox.Size = new System.Drawing.Size(121, 21);
            this.MovieToDelete_comboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a movie";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(147, 149);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieToDelete_comboBox);
            this.Controls.Add(this.DeleteMovie_button);
            this.Name = "DeleteMovie";
            this.Text = "DeleteMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteMovie_button;
        private System.Windows.Forms.ComboBox MovieToDelete_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
    }
}