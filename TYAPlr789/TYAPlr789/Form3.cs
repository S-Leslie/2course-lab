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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static int getSum(string value)
        {
            int sum = 0;
            int num = 0;
            foreach (var ch in value)
            {
                if (ch >= 48 && ch <= 57)
                {
                    num += ch - 48;
                    sum += num;
                }
                num = 0;

            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string w;
            char fraz1 = ' ';
            string text = Convert.ToString(textBox1.Text);
            string sym = Convert.ToString(textBox2.Text);
            string[] words = text.Split(fraz1);
            int kol = words.Length;
            textBox4.Text = Convert.ToString(kol);
            int kol2 = 0;
            string newText = null;
            for (int i = 0; i < words.Length; i++)
            {

                kol2 = getSum(words[i]);
                if (kol2 != 0)
                {
                    for (int s = 0, len = words[i].Length; s < kol2; s++, len++)
                        //    words[i] = words[i] + sym;
                        words[i] = words[i].Insert(len, sym);
                    newText = newText + ' ' + words[i];
                }
                else
                {
                    newText = newText + ' ' + words[i];
                }
            }
            textBox3.Text = newText;
            string[] work = newText.Split(' ');
            int kos = work.Length;
            textBox5.Text = Convert.ToString(kos - 1);   
        }

    }
}
