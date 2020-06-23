using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;
//    [DllImport("user32.dll")]
//public static extern void LockWorkStation();

namespace Introduction
{
    public partial class TimerOff : Form
    {
        int h = 0; int m = 0; int s = 0;
        bool start = false;
        public TimerOff()
        {
            InitializeComponent();
            ComboBoxAction.SelectedIndex = 0;
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
                //if (h <= 24 && m <= 59 && s <= 59
                //        &&
                //        h >= 0 && m >= 0 && s >= 0)
                //{
                h = Convert.ToInt32(this.tb_h.Text);
                s = Convert.ToInt32(this.tb_s.Text);
                m = Convert.ToInt32(this.tb_m.Text);
                //}
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
            if (rb_in.Checked)
            {
                if (h == DateTime.Now.Hour && m == DateTime.Now.Minute && s == DateTime.Now.Second)
                {
                    MessageBox.Show("hbgvnskld;fgsdfg");
                }
            }
            if (rb_after.Checked)
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
                    if (ComboBoxAction.SelectedItem.ToString() == "Lock screen")
                    {

                    }
                    if (ComboBoxAction.SelectedItem.ToString() == "Log off")
                    {

                    }
                    if (ComboBoxAction.SelectedItem.ToString() == "Suspend")
                    {
                        h = 10; m = 10; s = 10;
                        Application.SetSuspendState(PowerState.Suspend, true, true);
                    }
                    if (ComboBoxAction.SelectedItem.ToString() == "Hibernate")
                    {
                        h = 10; m = 10; s = 10;
                        Application.SetSuspendState(PowerState.Hibernate, true, true);
                    }
                    if (ComboBoxAction.SelectedItem.ToString() == "Shutdown")
                    {
                        System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
                    }
                }
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