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
    public partial class Form7 : Form
    {
        double[] a;
        double[] b;
        public Form7()
        {
            InitializeComponent();
        }

        void vvoda(out double[] a)
        {
            double x;
            int n = Convert.ToInt32(textBox1.Text);
            a = new double[n];
            String S = textBox3.Text;
            char r = ' ';
            String[] sm = S.Split(r);
            a[0] = Convert.ToDouble(sm[0]);
            int nn = 1;
            for (int i = 1; i < n; i++)
            {
                x = Convert.ToDouble(sm[i]);
                for (int j = nn; j > poisk(a, nn, x) - 1; j--)
                    a[j] = a[j - 1];
                a[poisk(a, nn, x) - 1] = x;
                nn++;
            }
        }

        void vvodb(out double[] b)
        {
            int n = Convert.ToInt32(textBox2.Text);
            b = new double[n];
            String S = textBox4.Text;
            char r = ' ';
            String[] sm = S.Split(r);
            for (int i = 0; i < n; i++)
                b[i] = Convert.ToDouble(sm[i]);
        }

        int poisk(double[] mas, int n, double f)
        {
            int a = 0, b = n-1, d;
            while (b - a > 1)
            {
                d = (b - a) / 2 + a;
                if (mas[d] >= f)
                    b = d;
                else
                    a = d;
            }
            if (f < mas[a])
                return a+1;
            if (f > mas[b])
                return b+2;
            else return b+1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            vvoda(out a);
            vivod(a, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            vvodb(out b);
            vivod(b, listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int n = Convert.ToInt32(textBox2.Text);
            Int32[] rez = new Int32[n];
            for(int i=0;i<n;i++)
                rez[i] = poisk(a, a.Length, b[i]);
            vivodint(rez, listBox3);
        }

        void vivod(double[] mas, ListBox lb)
        {
            foreach (double x in mas)
                lb.Items.Add(x);
        }

        void vivodint(int[] mas, ListBox lb)
        {
            foreach (double x in mas)
                lb.Items.Add(x);
        }
    }
}
