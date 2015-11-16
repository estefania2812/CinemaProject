namespace shlab4
{
    partial class Rooms
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
            this.commit_button = new System.Windows.Forms.Button();
            this.rooms_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.increase1_textBox = new System.Windows.Forms.TextBox();
            this.increase2_textBox = new System.Windows.Forms.TextBox();
            this.room_dataGridView = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.room_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commit_button
            // 
            this.commit_button.Location = new System.Drawing.Point(403, 357);
            this.commit_button.Name = "commit_button";
            this.commit_button.Size = new System.Drawing.Size(75, 23);
            this.commit_button.TabIndex = 0;
            this.commit_button.Text = "Commit";
            this.commit_button.UseVisualStyleBackColor = true;
            this.commit_button.Click += new System.EventHandler(this.commit_button_Click);
            // 
            // rooms_button
            // 
            this.rooms_button.Location = new System.Drawing.Point(224, 12);
            this.rooms_button.Name = "rooms_button";
            this.rooms_button.Size = new System.Drawing.Size(107, 23);
            this.rooms_button.TabIndex = 1;
            this.rooms_button.Text = "Show Rooms";
            this.rooms_button.UseVisualStyleBackColor = true;
            this.rooms_button.Click += new System.EventHandler(this.rooms_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Increase for normal rooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Increase for rooms VIP";
            // 
            // increase1_textBox
            // 
            this.increase1_textBox.Location = new System.Drawing.Point(175, 318);
            this.increase1_textBox.Name = "increase1_textBox";
            this.increase1_textBox.Size = new System.Drawing.Size(100, 20);
            this.increase1_textBox.TabIndex = 4;
            // 
            // increase2_textBox
            // 
            this.increase2_textBox.Location = new System.Drawing.Point(175, 360);
            this.increase2_textBox.Name = "increase2_textBox";
            this.increase2_textBox.Size = new System.Drawing.Size(100, 20);
            this.increase2_textBox.TabIndex = 5;
            // 
            // room_dataGridView
            // 
            this.room_dataGridView.BackgroundColor = System.Drawing.Color.Teal;
            this.room_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_dataGridView.Location = new System.Drawing.Point(35, 52);
            this.room_dataGridView.Name = "room_dataGridView";
            this.room_dataGridView.Size = new System.Drawing.Size(531, 247);
            this.room_dataGridView.TabIndex = 6;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(491, 357);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 399);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.room_dataGridView);
            this.Controls.Add(this.increase2_textBox);
            this.Controls.Add(this.increase1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rooms_button);
            this.Controls.Add(this.commit_button);
            this.Name = "Rooms";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.room_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commit_button;
        private System.Windows.Forms.Button rooms_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox increase1_textBox;
        private System.Windows.Forms.TextBox increase2_textBox;
        private System.Windows.Forms.DataGridView room_dataGridView;
        private System.Windows.Forms.Button back_button;
    }
}