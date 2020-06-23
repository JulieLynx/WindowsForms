using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DateCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp1.Value;
            DateTime endDate = dtp2.Value;
            int res = 0;

            //TimeSpan interval = endDate - startDate;
            //MessageBox.Show(interval..ToString(), "Interval");
            if (radioButton1.Checked)
            {
                int buff;
                buff = endDate.Month - startDate.Month;
                res = ((endDate.Year - startDate.Year) * 12) + buff;
                res = res / 12;
                MessageBox.Show(res.ToString() + " years");
            }
            if (radioButton2.Checked)
            {
                int buff;
                buff = endDate.Month - startDate.Month;
                res = ((endDate.Year - startDate.Year) * 12) + buff;
                MessageBox.Show(res.ToString() + " month");
            }
            if (radioButton3.Checked)
            {
                //int buff_m;
                //int buff_d= 0;
                //buff_d = endDate.Day - startDate.Day;
                //buff_m = endDate.Month - startDate.Month;
                //res = ((((endDate.Year - startDate.Year) * 12) + buff_m)*30) + buff_d;
                //MessageBox.Show(res.ToString() + " days");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
