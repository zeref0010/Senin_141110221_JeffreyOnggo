using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int range;
        public DateTime min, max, now;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            now = DateTime.Now;
            range = hScrollBar1.Value + hScrollBar2.Value;
            label1.Text = hScrollBar1.Value.ToString();
            label3.Text = "Range : " + range.ToString();
            min = new DateTime(now.Year - range, now.Month, now.Day);
            max = new DateTime(now.Year + range, now.Month, now.Day);
            dateTimePicker1.MinDate = min;
            dateTimePicker1.MaxDate = max;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            now = DateTime.Now;
            range = hScrollBar1.Value + hScrollBar2.Value;
            label2.Text = hScrollBar2.Value.ToString();
            label3.Text = "Range : " + range.ToString();
            min = new DateTime(now.Year - range, now.Month, now.Day);
            max = new DateTime(now.Year + range, now.Month, now.Day);
            dateTimePicker1.MinDate = min;
            dateTimePicker1.MaxDate = max;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
