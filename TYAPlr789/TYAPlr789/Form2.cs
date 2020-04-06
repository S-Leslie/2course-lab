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
    public partial class Form2 : Form
    {
        int size1, size2, flag;
        public Form2()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            size1 = 0; size2 = 0; flag = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button2.Visible = true;
            textBox2.Visible = true;

            size1 = Convert.ToInt32(textBox1.Text);
            button1.Enabled = false;
            textBox1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button3.Visible = true;
            textBox3.Visible = true;

            size2 = Convert.ToInt32(textBox2.Text);
            button2.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            label5.Visible = true;
            if (flag < size1)
            {
                listBox1.Items.Add(textBox3.Text);
                textBox3.Text = "";
                textBox3.Focus();
                flag++;
                if (flag == size1)
                {
                    listBox1.Enabled = false;
                }
            }
            else if (flag < size1 + size2)
            {
                listBox2.Items.Add(textBox3.Text);
                textBox3.Text = "";
                textBox3.Focus();
                flag++;
                if (flag == size1 + size2)
                {
                    listBox3.Visible = true;
                    listBox4.Visible = true;
                    label6.Visible = true;
                    button4.Visible = true;
                    listBox2.Enabled = false;
                }
            }
        }
        public void get_arr(out int[] mas1, out int[] mas2)
        {
            mas1 = new int[size1];
            mas2 = new int[size2];
            for (int i = 0; i < size1; i++)
                mas1[i] = Convert.ToInt32(listBox1.Items[i]);
            for (int i = 0; i < size2; i++)
                mas2[i] = Convert.ToInt32(listBox2.Items[i]);
        }
        private int sravnenie(int[] mas1, int[] mas2)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                for (int j = 0; j < mas2.Length; j++)
                {
                    if (mas1[i] == mas2[j]) { y++; }

                }
                x++;
            }
            x = x - y;
            return x;
        }
        private int[] ff(int[] mas1, int[] mas2, int k)
        {
            int x = 0;
            int zz = 0;
            int[] mas3 = new int[k];
            for (int i = 0; i < mas1.Length; i++)
            {
                for (int j = 0; j < mas2.Length; j++)
                {
                    if (mas1[i] != mas2[j]) { zz++; }

                }
                if (zz == mas2.Length && x != k)
                {
                    mas3[x] = mas1[i];
                    x++;
                }
                zz = 0;

            }
            return mas3;
        }
        public void vivod(int[] nmas, int[] mas)
        {
            for (int i = 0; i < nmas.Length; i++)
                listBox3.Items.Add(nmas[i]);
            for (int i = 0; i < mas.Length; i++)
                listBox4.Items.Add(mas[i]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] mas1, mas2;
            get_arr(out mas1, out mas2);
            int j = sravnenie(mas1, mas2);
            int k = sravnenie(mas2, mas1);
            int[] mas3 = ff(mas1, mas2, j);
            int[] mas4 = ff(mas2, mas1, k);
            vivod(mas3, mas4);
            button4.Enabled = false;
            textBox3.Enabled = false;
        }
    }
}
