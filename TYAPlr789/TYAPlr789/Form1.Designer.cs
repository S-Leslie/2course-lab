namespace TYAPlr789
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LabR7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabR8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лабораторнаяРабота9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabR7ToolStripMenuItem,
            this.LabR8ToolStripMenuItem,
            this.лабораторнаяРабота9ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LabR7ToolStripMenuItem
            // 
            this.LabR7ToolStripMenuItem.Name = "LabR7ToolStripMenuItem";
            this.LabR7ToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.LabR7ToolStripMenuItem.Text = "Лабораторная работа 7";
            this.LabR7ToolStripMenuItem.Click += new System.EventHandler(this.LabR7ToolStripMenuItem_Click);
            // 
            // LabR8ToolStripMenuItem
            // 
            this.LabR8ToolStripMenuItem.Name = "LabR8ToolStripMenuItem";
            this.LabR8ToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.LabR8ToolStripMenuItem.Text = "Лабораторная работа 8";
            this.LabR8ToolStripMenuItem.Click += new System.EventHandler(this.LabR8ToolStripMenuItem_Click);
            // 
            // лабораторнаяРабота9ToolStripMenuItem
            // 
            this.лабораторнаяРабота9ToolStripMenuItem.Name = "лабораторнаяРабота9ToolStripMenuItem";
            this.лабораторнаяРабота9ToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.лабораторнаяРабота9ToolStripMenuItem.Text = "Лабораторная работа 9";
            this.лабораторнаяРабота9ToolStripMenuItem.Click += new System.EventHandler(this.лабораторнаяРабота9ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 572);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторные работы С#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LabR7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LabR8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторнаяРабота9ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}