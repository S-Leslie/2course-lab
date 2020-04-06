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
    public partial class Form91 : Form
    {
        DataGridView grid;
        public Form91()
        {
            InitializeComponent();
        }
        public Form91(DataGridView dgrid)
        {
            InitializeComponent();
            grid = dgrid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = Convert.ToInt32(textBox1.Text);
            for(int i=0;i<grid.RowCount;i++)
                if (a == Convert.ToInt32(grid.Rows[i].Cells[2].Value) && a!=0)
                    listBox1.Items.Add(grid.Rows[i].Cells[1].Value);
        }
    }
}
