namespace Fall_Project_2._0
{
    partial class Physics
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
            this.Dell = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Evaluationn = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Backtomenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogOut = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dell
            // 
            this.Dell.Location = new System.Drawing.Point(361, 365);
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(100, 20);
            this.Dell.TabIndex = 41;
            this.Dell.TextChanged += new System.EventHandler(this.Dell_TextChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(361, 323);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 23);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "Delete ";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(88, 365);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(237, 20);
            this.FullName.TabIndex = 39;
            this.FullName.TextChanged += new System.EventHandler(this.FullName_TextChanged);
            // 
            // Evaluationn
            // 
            this.Evaluationn.Location = new System.Drawing.Point(88, 391);
            this.Evaluationn.Name = "Evaluationn";
            this.Evaluationn.Size = new System.Drawing.Size(237, 20);
            this.Evaluationn.TabIndex = 38;
            this.Evaluationn.TextChanged += new System.EventHandler(this.Evaluationn_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(88, 323);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(237, 23);
            this.Save.TabIndex = 37;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Backtomenu
            // 
            this.Backtomenu.Location = new System.Drawing.Point(705, 69);
            this.Backtomenu.Name = "Backtomenu";
            this.Backtomenu.Size = new System.Drawing.Size(83, 31);
            this.Backtomenu.TabIndex = 36;
            this.Backtomenu.Text = "Back to menu";
            this.Backtomenu.UseVisualStyleBackColor = true;
            this.Backtomenu.Click += new System.EventHandler(this.Backtomenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 264);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(705, 40);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(83, 23);
            this.LogOut.TabIndex = 34;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(88, 417);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(237, 20);
            this.Date.TabIndex = 42;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // Physics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Dell);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Evaluationn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Backtomenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogOut);
            this.Name = "Physics";
            this.Text = "Physics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Dell;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Evaluationn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Backtomenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.TextBox Date;
    }
}