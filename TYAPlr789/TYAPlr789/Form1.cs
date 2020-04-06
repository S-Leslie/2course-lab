using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYAPlr789
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabR7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 forr = new Form2();
            forr.Show();
        }

        private void LabR8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 forr = new Form3();
            forr.Show();
        }

        private void лабораторнаяРабота9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 forr = new Form4();
            forr.Show();
        }

        //private void toolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Form5 forr = new Form5();
        //    forr.Show();
        //}
    }
}
