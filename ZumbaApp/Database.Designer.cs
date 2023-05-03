namespace ZumbaApp
{
    partial class Database
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
            this.View = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.txb_Concessions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.txb_lName = new System.Windows.Forms.TextBox();
            this.txb_fName = new System.Windows.Forms.TextBox();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Impact", 13.8F);
            this.View.Location = new System.Drawing.Point(164, 332);
            this.View.Margin = new System.Windows.Forms.Padding(4);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(127, 53);
            this.View.TabIndex = 27;
            this.View.Text = "View All";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(571, 510);
            this.dataGridView1.TabIndex = 26;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Impact", 13.8F);
            this.Search.Location = new System.Drawing.Point(164, 404);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(127, 128);
            this.Search.TabIndex = 25;
            this.Search.Text = "Search ID";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Impact", 13.8F);
            this.Delete.Location = new System.Drawing.Point(26, 404);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 53);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Impact", 13.8F);
            this.Update.Location = new System.Drawing.Point(26, 479);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(127, 53);
            this.Update.TabIndex = 23;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txb_Concessions
            // 
            this.txb_Concessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Concessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Concessions.Location = new System.Drawing.Point(27, 286);
            this.txb_Concessions.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Concessions.Name = "txb_Concessions";
            this.txb_Concessions.Size = new System.Drawing.Size(77, 34);
            this.txb_Concessions.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label4.Location = new System.Drawing.Point(22, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Concessions";
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Impact", 13.8F);
            this.Insert.Location = new System.Drawing.Point(26, 332);
            this.Insert.Margin = new System.Windows.Forms.Padding(4);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(127, 53);
            this.Insert.TabIndex = 20;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // txb_lName
            // 
            this.txb_lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_lName.Location = new System.Drawing.Point(27, 213);
            this.txb_lName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_lName.Name = "txb_lName";
            this.txb_lName.Size = new System.Drawing.Size(205, 34);
            this.txb_lName.TabIndex = 19;
            // 
            // txb_fName
            // 
            this.txb_fName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_fName.Location = new System.Drawing.Point(27, 137);
            this.txb_fName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_fName.Name = "txb_fName";
            this.txb_fName.Size = new System.Drawing.Size(205, 34);
            this.txb_fName.TabIndex = 18;
            // 
            // txb_ID
            // 
            this.txb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ID.Location = new System.Drawing.Point(27, 56);
            this.txb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(205, 34);
            this.txb_ID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label3.Location = new System.Drawing.Point(22, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Member ID";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.View);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.txb_Concessions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.txb_lName);
            this.Controls.Add(this.txb_fName);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Database";
            this.Size = new System.Drawing.Size(898, 559);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox txb_Concessions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox txb_lName;
        private System.Windows.Forms.TextBox txb_fName;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
