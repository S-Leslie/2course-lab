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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resh();
        }
        void Resh()
        {
            String S = textBox1.Text;
            char r = ' ';
            String[] slov = S.Split(r);
            String newS="";
            int kol=0;
            for(int i=0;i<slov.Length;i++)
            {
                for (int j = 0; j < slov[i].Length - 1;j++)
                {
                    if (String.Compare(slov[i][j].ToString(), slov[i][j + 1].ToString(), true) == 0)
                        if (slov[i][j] < slov[i][j + 1])
                        {
                            slov[i] = slov[i].Remove(j, 1);
                            j--;
                            kol++;
                        }
                        else if (slov[i][j] > slov[i][j + 1])
                        {
                            slov[i] = slov[i].Remove(j + 1, 1);
                            kol++;
                        }
                }
                newS = newS + slov[i]+" ";
            }
            textBox2.Text = newS;
            textBox3.Text = kol.ToString();
        }
    }
}
