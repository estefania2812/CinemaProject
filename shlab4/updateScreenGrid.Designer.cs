namespace shlab4
{
    partial class updateScreenGrid
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
            this.screen_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screen_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // screen_dataGridView
            // 
            this.screen_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.screen_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.screen_dataGridView.Location = new System.Drawing.Point(12, 45);
            this.screen_dataGridView.Name = "screen_dataGridView";
            this.screen_dataGridView.Size = new System.Drawing.Size(562, 280);
            this.screen_dataGridView.TabIndex = 0;
            this.screen_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.screen_dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Screen to update";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(265, 361);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // updateScreenGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screen_dataGridView);
            this.Name = "updateScreenGrid";
            this.Text = "updateGrid";
            ((System.ComponentModel.ISupportInitialize)(this.screen_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView screen_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
    }
}