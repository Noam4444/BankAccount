namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ביתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.בנקיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.תנועותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ביתToolStripMenuItem
            // 
            this.ביתToolStripMenuItem.Name = "ביתToolStripMenuItem";
            this.ביתToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.ביתToolStripMenuItem.Text = "בית";
            // 
            // בנקיםToolStripMenuItem
            // 
            this.בנקיםToolStripMenuItem.Name = "בנקיםToolStripMenuItem";
            this.בנקיםToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.בנקיםToolStripMenuItem.Text = "בנקים";
            this.בנקיםToolStripMenuItem.Click += new System.EventHandler(this.בנקיםToolStripMenuItem_Click);
            // 
            // תנועותToolStripMenuItem
            // 
            this.תנועותToolStripMenuItem.Name = "תנועותToolStripMenuItem";
            this.תנועותToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.תנועותToolStripMenuItem.Text = "תנועות";
            this.תנועותToolStripMenuItem.Click += new System.EventHandler(this.תנועותToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(301, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ברוכים הבאים ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ביתToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem בנקיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem תנועותToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

