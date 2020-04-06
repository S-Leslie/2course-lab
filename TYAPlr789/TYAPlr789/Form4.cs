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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab9DataSet.Таблица2' table. You can move, or remove it, as needed.
            this.таблица2TableAdapter.Fill(this.lab9DataSet.Таблица2);
            // TODO: This line of code loads data into the 'lab9DataSet.Таблица1' table. You can move, or remove it, as needed.
            this.таблица1TableAdapter.Fill(this.lab9DataSet.Таблица1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView Grid3 = new DataGridView();
            this.Controls.Add(Grid3);
            Grid3.ColumnCount = 2;
            Grid3.Name = "Список по предприятиям";
            Grid3.Top = dataGridView1.Bottom - 180;
            Grid3.Left = dataGridView2.Left + 600;
            Grid3.Size = new Size(220, 140);
            Grid3.RowHeadersVisible = false;
            Grid3.Columns[0].Name = "Название предприятия";
            Grid3.Columns[1].Name = "Общая стоимость ремонта";
            Grid3.AllowUserToAddRows = false;
            int z, obj, sr, s, q = 0;
            int sum = 0;
            z = 0;
            string[] num1;
            string[] num2;
            string[] nik;
            int[] nn;
            num1 = new string[dataGridView1.RowCount];
            num2 = new string[dataGridView1.RowCount];
            nik = new string[dataGridView1.RowCount];
            nn = new int[dataGridView1.RowCount];
            s = dataGridView1.RowCount;
            for (int l = 0; l < s - q + 1; l++)
            {
                num1[l] = Convert.ToString(dataGridView1.Rows[l].Cells[0].Value);
                for (int i = l; i < dataGridView1.RowCount; i++)
                {
                    num2[i] = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    if (num1[l] == num2[i])
                    {
                        q++;
                        sr = Convert.ToInt32(dataGridView2.Rows[Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) - 1].Cells[2].Value);
                        obj = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                        sum += sr * obj;
                        nik[z] = num1[l];
                    }

                }
                nn[z] = sum;
                sum = 0;
                Grid3.Rows.Add();
                Grid3.Rows[z].Cells[0].Value = Convert.ToString(nik[z]);
                Grid3.Rows[z].Cells[1].Value = Convert.ToString(nn[z]);
                z++;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView Grid4 = new DataGridView();
            this.Controls.Add(Grid4);
            Grid4.ColumnCount = 2;
            Grid4.Name = "Список ремонтных организаций";
            Grid4.Top = dataGridView1.Bottom + 30;
            Grid4.Left = dataGridView2.Left + 600;
            Grid4.Size = new Size(200, 200);
            Grid4.RowHeadersVisible = false;
            Grid4.Columns[0].Name = "Название организации";
            Grid4.Columns[1].Name = "Средняя стоимость ремонта";
            Grid4.AllowUserToAddRows = false;

            string name = Convert.ToString(textBox1.Text);
            int l = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                String sss = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                if (name == sss)
                {
                    Grid4.Rows.Add();
                    Grid4.Rows[l].Cells[0].Value = Convert.ToString(dataGridView2.Rows[Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) - 1].Cells[1].Value);
                    Grid4.Rows[l].Cells[1].Value = Convert.ToString(dataGridView2.Rows[Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) -1].Cells[2].Value);
                    l++;
                }
            }
        }
    }
}
