using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime awalTahun = new DateTime(2016, 1, 1);
            DateTime akhirTahun = new DateTime(2016, 12, 31);
            for (int i = 1; i <= akhirTahun.DayOfYear; i++)
            {
                if (awalTahun.DayOfWeek.ToString() == "Saturday" || awalTahun.DayOfWeek.ToString() == "Sunday")
                {
                    monthCalendar.AddBoldedDate(awalTahun);
                }
                awalTahun = awalTahun.AddDays(1);
            }
            nudTanggal.Maximum = DateTime.DaysInMonth(2016, (int) nudBulan.Value);
            monthCalendar.UpdateBoldedDates();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void nudBulan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
