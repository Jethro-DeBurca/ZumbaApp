namespace ZumbaApp
{
    partial class Booking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sunday = new System.Windows.Forms.Button();
            this.Monday = new System.Windows.Forms.Button();
            this.Tuesday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sunday
            // 
            this.Sunday.Location = new System.Drawing.Point(304, 112);
            this.Sunday.Margin = new System.Windows.Forms.Padding(4);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(273, 105);
            this.Sunday.TabIndex = 0;
            this.Sunday.Text = "button1";
            this.Sunday.UseVisualStyleBackColor = true;
            this.Sunday.Click += new System.EventHandler(this.Sunday_Click);
            // 
            // Monday
            // 
            this.Monday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.Monday.Location = new System.Drawing.Point(304, 225);
            this.Monday.Margin = new System.Windows.Forms.Padding(4);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(273, 105);
            this.Monday.TabIndex = 1;
            this.Monday.Text = "button2";
            this.Monday.UseVisualStyleBackColor = true;
            this.Monday.Click += new System.EventHandler(this.Monday_Click);
            // 
            // Tuesday
            // 
            this.Tuesday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.Tuesday.Location = new System.Drawing.Point(304, 338);
            this.Tuesday.Margin = new System.Windows.Forms.Padding(4);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(273, 105);
            this.Tuesday.TabIndex = 2;
            this.Tuesday.Text = "button2";
            this.Tuesday.UseVisualStyleBackColor = true;
            this.Tuesday.Click += new System.EventHandler(this.Tuesday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F);
            this.label1.Location = new System.Drawing.Point(327, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upcoming Classes";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(898, 559);
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sunday;
        private System.Windows.Forms.Button Monday;
        private System.Windows.Forms.Button Tuesday;
        private System.Windows.Forms.Label label1;
    }
}
