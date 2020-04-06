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
    public partial class Form9 : Form
    {
        Form91 form91;
        Form92 form92;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазинDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.магазинDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазинDataSet.Магазины". При необходимости она может быть перемещена или удалена.
            this.магазиныTableAdapter.Fill(this.магазинDataSet.Магазины);
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoResizeColumns();
            form91 = new Form91(dataGridView2);
            form91.Hide();
            form92 = new Form92(dataGridView1, dataGridView2);
            form92.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView grid1 = dataGridView1;
            String s1 = textBox1.Text;
            String s2 = dateTimePicker1.Text;
            String ss, ss1;
            String[] slov;
            int k=0;
            //Количество строк
            int n = dataGridView1.RowCount;
            for (int i = 0; i < n; i++)
            {
                ss=Convert.ToString(grid1.Rows[i].Cells[1].Value);
                if (String.Compare(s1, ss)== 0)
                {
                    ss1 = Convert.ToString(grid1.Rows[i].Cells[2].Value);
                    slov = ss1.Split(' ');
                    if (String.Compare(s2, slov[0]) == 0)
                    {
                        textBox2.Text = Convert.ToString(grid1.Rows[i].Cells[3].Value);
                        k++;
                    }
                }
            }
            if (k==0)
                textBox2.Text = "Не найдено";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (form91.IsDisposed)
            {
                form91 = new Form91(dataGridView2);
            }
            form91.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form92.IsDisposed)
            {
                form92 = new Form92(dataGridView1,dataGridView2);
            }
            form92.Show();
        }
    }
}
