using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private Form7 form7;
        private Form8 form8;
        private Form9 form9;
        public Form1()
        {
            InitializeComponent();
        } 

        private void laba7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form7.IsDisposed)
            {
                form7 = new Form7();
                form7.MdiParent = this;
            }
            form7.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form7 = new Form7();
            form7.Hide();
            form7.MdiParent = this;
            form8 = new Form8();
            form8.Hide();
            form8.MdiParent = this;
            form9 = new Form9();
            form9.Hide();
            form9.MdiParent = this;
        }

        private void laba8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form8.IsDisposed)
            {
                form8 = new Form8();
                form8.MdiParent = this;
            }
            form8.Show();
        }

        private void laba9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form9.IsDisposed)
            {
                form9 = new Form9();
                form9.MdiParent = this;
            }
            form9.Show();
        }
    }
}
