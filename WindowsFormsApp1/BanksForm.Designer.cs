namespace WindowsFormsApp1
{
    partial class BanksForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ביתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.בנקיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.תנועותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SumCol
            // 
            this.SumCol.HeaderText = "עובר ושב";
            this.SumCol.MinimumWidth = 6;
            this.SumCol.Name = "SumCol";
            this.SumCol.Width = 125;
            // 
            // OutCol
            // 
            this.OutCol.HeaderText = "יוצא";
            this.OutCol.MinimumWidth = 6;
            this.OutCol.Name = "OutCol";
            this.OutCol.Width = 125;
            // 
            // InCol
            // 
            this.InCol.HeaderText = "הכנסות";
            this.InCol.MinimumWidth = 6;
            this.InCol.Name = "InCol";
            this.InCol.Width = 125;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "שם";
            this.NameCol.MinimumWidth = 6;
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 125;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "מזהה";
            this.IdCol.MinimumWidth = 6;
            this.IdCol.Name = "IdCol";
            this.IdCol.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NameCol,
            this.InCol,
            this.OutCol,
            this.SumCol});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(51, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(931, 410);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ביתToolStripMenuItem,
            this.בנקיםToolStripMenuItem,
            this.תנועותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ביתToolStripMenuItem
            // 
            this.ביתToolStripMenuItem.Name = "ביתToolStripMenuItem";
            this.ביתToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.ביתToolStripMenuItem.Text = "בית";
            this.ביתToolStripMenuItem.Click += new System.EventHandler(this.ביתToolStripMenuItem_Click);
            // 
            // בנקיםToolStripMenuItem
            // 
            this.בנקיםToolStripMenuItem.Name = "בנקיםToolStripMenuItem";
            this.בנקיםToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.בנקיםToolStripMenuItem.Text = "בנקים";
            // 
            // תנועותToolStripMenuItem
            // 
            this.תנועותToolStripMenuItem.Name = "תנועותToolStripMenuItem";
            this.תנועותToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.תנועותToolStripMenuItem.Text = "תנועות";
            this.תנועותToolStripMenuItem.Click += new System.EventHandler(this.תנועותToolStripMenuItem_Click);
            // 
            // BanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanksForm";
            this.Text = "BanksForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn InCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ביתToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem בנקיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem תנועותToolStripMenuItem;
    }
}