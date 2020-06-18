using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class TimerOff : Form
    {
        int h = 0; int m = 0; int s = 0;
        bool start = false;
        public TimerOff()
        {
            InitializeComponent();
        }

        private void TimerOff_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //h = Convert.ToInt32(this.tb_h.Text);
            //s = Convert.ToInt32(this.tb_s.Text);
            //m = Convert.ToInt32(this.tb_m.Text);
        }
        private void bt_off_your_pc_Click(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToInt32(this.tb_h.Text);
                s = Convert.ToInt32(this.tb_s.Text);
                m = Convert.ToInt32(this.tb_m.Text);
            }
            catch
            {
                MessageBox.Show("Enter a value");
            }
            start = true;
            this.lb_timer_pc_off.Visible = true;
            this.pictureBox_cancel.Visible = true;
        }

        private void timer_off_pc_Tick(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (s < 0)
                {
                    m--;
                    if (m < 0 && s < 0) { h--; m = 59; }
                    s = 59;
                    
                }
                this.lb_timer_pc_off.Text = (h + ":" + m + ":" + s);
                s--;
            }
            if (h == 0 && m == 0 && s == -1)
            {
                start = false;
               // System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
            }
        }
        private void timer_pc_off_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox_cancel_Click(object sender, EventArgs e)
        {
            start = false;
        }
    }
}
