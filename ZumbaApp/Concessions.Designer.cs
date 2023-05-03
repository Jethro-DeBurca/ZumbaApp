namespace ZumbaApp
{
    partial class Concessions
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
            this.btn_BuyCon = new System.Windows.Forms.Button();
            this.lbl_ConAmount = new System.Windows.Forms.Label();
            this.btn_PlusCon = new System.Windows.Forms.Button();
            this.btn_MinusCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BuyCon
            // 
            this.btn_BuyCon.Font = new System.Drawing.Font("Impact", 16.2F);
            this.btn_BuyCon.Location = new System.Drawing.Point(314, 212);
            this.btn_BuyCon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuyCon.Name = "btn_BuyCon";
            this.btn_BuyCon.Size = new System.Drawing.Size(247, 160);
            this.btn_BuyCon.TabIndex = 0;
            this.btn_BuyCon.Text = "Buy Concessions";
            this.btn_BuyCon.UseVisualStyleBackColor = true;
            this.btn_BuyCon.Click += new System.EventHandler(this.btn_BuyCon_Click);
            // 
            // lbl_ConAmount
            // 
            this.lbl_ConAmount.AutoSize = true;
            this.lbl_ConAmount.Font = new System.Drawing.Font("Impact", 16.2F);
            this.lbl_ConAmount.Location = new System.Drawing.Point(423, 164);
            this.lbl_ConAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ConAmount.Name = "lbl_ConAmount";
            this.lbl_ConAmount.Size = new System.Drawing.Size(0, 35);
            this.lbl_ConAmount.TabIndex = 1;
            // 
            // btn_PlusCon
            // 
            this.btn_PlusCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlusCon.Location = new System.Drawing.Point(510, 164);
            this.btn_PlusCon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PlusCon.Name = "btn_PlusCon";
            this.btn_PlusCon.Size = new System.Drawing.Size(51, 41);
            this.btn_PlusCon.TabIndex = 2;
            this.btn_PlusCon.Text = "+";
            this.btn_PlusCon.UseVisualStyleBackColor = true;
            this.btn_PlusCon.Click += new System.EventHandler(this.btn_PlusCon_Click);
            // 
            // btn_MinusCon
            // 
            this.btn_MinusCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MinusCon.Location = new System.Drawing.Point(314, 164);
            this.btn_MinusCon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MinusCon.Name = "btn_MinusCon";
            this.btn_MinusCon.Size = new System.Drawing.Size(49, 41);
            this.btn_MinusCon.TabIndex = 3;
            this.btn_MinusCon.Text = "-";
            this.btn_MinusCon.UseVisualStyleBackColor = true;
            this.btn_MinusCon.Click += new System.EventHandler(this.btn_MinusCon_Click);
            // 
            // Concessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_MinusCon);
            this.Controls.Add(this.btn_PlusCon);
            this.Controls.Add(this.lbl_ConAmount);
            this.Controls.Add(this.btn_BuyCon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Concessions";
            this.Size = new System.Drawing.Size(898, 559);
            this.Load += new System.EventHandler(this.Concessions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuyCon;
        private System.Windows.Forms.Label lbl_ConAmount;
        private System.Windows.Forms.Button btn_PlusCon;
        private System.Windows.Forms.Button btn_MinusCon;
    }
}
