namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laba7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laba8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laba9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laba7ToolStripMenuItem,
            this.laba8ToolStripMenuItem,
            this.laba9ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laba7ToolStripMenuItem
            // 
            this.laba7ToolStripMenuItem.Name = "laba7ToolStripMenuItem";
            this.laba7ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.laba7ToolStripMenuItem.Text = "laba7";
            this.laba7ToolStripMenuItem.Click += new System.EventHandler(this.laba7ToolStripMenuItem_Click);
            // 
            // laba8ToolStripMenuItem
            // 
            this.laba8ToolStripMenuItem.Name = "laba8ToolStripMenuItem";
            this.laba8ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.laba8ToolStripMenuItem.Text = "laba8";
            this.laba8ToolStripMenuItem.Click += new System.EventHandler(this.laba8ToolStripMenuItem_Click);
            // 
            // laba9ToolStripMenuItem
            // 
            this.laba9ToolStripMenuItem.Name = "laba9ToolStripMenuItem";
            this.laba9ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.laba9ToolStripMenuItem.Text = "laba9";
            this.laba9ToolStripMenuItem.Click += new System.EventHandler(this.laba9ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 522);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laba7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laba8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laba9ToolStripMenuItem;
    }
}

