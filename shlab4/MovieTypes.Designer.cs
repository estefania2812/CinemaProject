namespace shlab4
{
    partial class MovieTypes
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
            this.genre_comboBox = new System.Windows.Forms.ComboBox();
            this.movieTypes_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(663, 345);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(191, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a genre";
            // 
            // genre_comboBox
            // 
            this.genre_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.genre_comboBox.FormattingEnabled = true;
            this.genre_comboBox.Location = new System.Drawing.Point(328, 37);
            this.genre_comboBox.Name = "genre_comboBox";
            this.genre_comboBox.Size = new System.Drawing.Size(121, 21);
            this.genre_comboBox.TabIndex = 2;
            this.genre_comboBox.SelectedIndexChanged += new System.EventHandler(this.genre_comboBox_SelectedIndexChanged);
            // 
            // movieTypes_dataGridView
            // 
            this.movieTypes_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.movieTypes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieTypes_dataGridView.Location = new System.Drawing.Point(12, 84);
            this.movieTypes_dataGridView.Name = "movieTypes_dataGridView";
            this.movieTypes_dataGridView.Size = new System.Drawing.Size(721, 238);
            this.movieTypes_dataGridView.TabIndex = 3;
            // 
            // MovieTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(763, 394);
            this.Controls.Add(this.movieTypes_dataGridView);
            this.Controls.Add(this.genre_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Name = "MovieTypes";
            this.Text = "MovieTypes";
            ((System.ComponentModel.ISupportInitialize)(this.movieTypes_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genre_comboBox;
        private System.Windows.Forms.DataGridView movieTypes_dataGridView;
    }
}