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
    public partial class Form92 : Form
    {
        DataGridView grid1;
        DataGridView grid2;
        public Form92()
        {
            InitializeComponent();
        }
        public Form92(DataGridView dgrid1, DataGridView dgrid2)
        {
            InitializeComponent();
            grid1 = dgrid1;
            grid2 = dgrid2;
        }
        private void Form92_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = grid2.RowCount;
            for (int i = 1; i < grid2.RowCount; i++)
                dataGridView1.Columns[i].Name = Convert.ToString(grid2[1, i-1].Value);
            int k = 0, n;
            Int32[] s = new Int32[grid1.RowCount];
            String mag;
            for (int i = 0; i < grid1.RowCount ; i++)
            {
                if (s.Contains<Int32>(Convert.ToInt32(grid1[0, i].Value)))
                    continue;
                s[k++] = Convert.ToInt32(grid1[0, i].Value);
                mag = Convert.ToString(grid1[1, i].Value);
                n = dataGridView1.Rows.Add();
                dataGridView1[0, n].Value = mag;
                for (int j = 1; j < grid2.RowCount ; j++)
                {
                    if (s[k - 1] == Convert.ToInt32(grid2[0,j-1].Value))
                        dataGridView1[j, n].Value = grid2[2, j-1].Value;
                }
            }
            dataGridView1.AutoResizeColumns();
        }
    }
}
