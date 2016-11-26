using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static int mod = 1000000007;
        static private long peluang(int a, int b)
        {
            long hasil = 1;
            for (int i = 0; i < b; i++)
            {
                hasil = hasil * (a - i) / (i + 1);
            }
            return hasil % mod;
        }
        static long pangkat(long a, long b)
        {
            if (b == 0)
            {
                return 1;
            }
            if (b == 1)
            {
                return a;
            }
            if (a == 0)
            {
                return 0;
            }
            long bagi = pangkat(a, b / 2);
            if (b % 2 == 0)
            {
                return (bagi * bagi) % mod;
            }
            else
            {
                return (((bagi * bagi) % mod) * a) % mod;
            }
        }
        static long keluar(int x, int y)
        {
            int tempSwap = 0;
            if (x < y)
            {
                tempSwap = x;
                x = y;
                y = tempSwap;
            }
            if (x < 25)
            {
                return 0;
            }
            if (x == 25)
            {
                if (y >= 24)
                {
                    return 0;
                }
                else
                {
                    return peluang(x + y - 1, y);
                }
            }
            if (x - y != 2)
            {
                return 0;
            }
            else
            {
                return peluang(48, 24) * pangkat(2, x - 26) % mod;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(textBox2.Text);
            int text2 = Convert.ToInt32(textBox1.Text);
            textBox3.Text = keluar(text1, text2).ToString();
        }
    }
}
