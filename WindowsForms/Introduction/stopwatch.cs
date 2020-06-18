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
    public partial class stopwatch : Form
    {
        uint h = 0; uint m = 0; uint s = 0;
        bool stop;
        public stopwatch()
        {
            InitializeComponent();
        }

        private void lb_stopWatch_Click(object sender, EventArgs e)
        {

        }

        private void sw_timer_Tick(object sender, EventArgs e)
        {if(stop == false)
            {

            if (s == 60)
            {
                m++;
                s = 0;
                if (m == 60)
                {
                    h++;
                    m = 0;
                }
            }
            this.lb_stopWatch.Text = (h + ":" + m + ":" + s);
            s++;
            }
        }

        private void bt_sw_start_Click(object sender, EventArgs e)
        {
            stop = false;
            h = 0; m = 0; s = 0;
            this.lb_stopWatch.Visible = true;
        }
        private void bt_sw_finish_Click(object sender, EventArgs e)
        {
            stop = true ;
            this.lb_stopWatch.Text = (h + ":" + m + ":" + (s-1));

        }
    }
}
