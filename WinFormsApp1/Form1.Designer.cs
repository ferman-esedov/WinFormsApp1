namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_baku = new System.Windows.Forms.Button();
            this.btn_london = new System.Windows.Forms.Button();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_baku
            // 
            this.btn_baku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baku.Location = new System.Drawing.Point(199, 355);
            this.btn_baku.Name = "btn_baku";
            this.btn_baku.Size = new System.Drawing.Size(75, 23);
            this.btn_baku.TabIndex = 0;
            this.btn_baku.Text = "Baku";
            this.btn_baku.UseVisualStyleBackColor = true;
            this.btn_baku.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_london
            // 
            this.btn_london.FlatAppearance.BorderSize = 3;
            this.btn_london.Location = new System.Drawing.Point(458, 355);
            this.btn_london.Name = "btn_london";
            this.btn_london.Size = new System.Drawing.Size(75, 23);
            this.btn_london.TabIndex = 1;
            this.btn_london.Text = "London";
            this.btn_london.UseVisualStyleBackColor = true;
            this.btn_london.Click += new System.EventHandler(this.btn_london_Click);
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clock.Location = new System.Drawing.Point(67, 28);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(0, 15);
            this.lbl_clock.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.btn_london);
            this.Controls.Add(this.btn_baku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_baku;
        private Button btn_london;
        private Label lbl_clock;
    }
}