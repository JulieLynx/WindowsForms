using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Introduction
{
    public partial class Form1 : Form
    {
		Font font_default;
		public Form1()
        {
            InitializeComponent();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (this.Width), 0);
            // Location = new Point(1000, 0);

            //TopMost = true;


			font_default = cb_showdate.Font;
		}

		private void main_timer_Tick(object sender, EventArgs e)
		{
			//this.lb_time.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
			this.lb_time.Text = DateTime.Now.ToLongTimeString();
			this.lb_date.Text = DateTime.Now.ToLongDateString();
			//if (cb_showdate.Checked)
			//{
			//	this.lb_date.Visible = true;
			//}
			//else
			//{
			//	this.lb_date.Visible = false;
			//}
		}

		private void cb_showdate_CheckedChanged(object sender, EventArgs e)
		{
			this.lb_date.Visible = this.cb_showdate.Checked;
            
		}

		private void cb_showdate_MouseHover(object sender, EventArgs e)
		{
			
			//font_default.
			this.cb_showdate.Font = new Font(font_default, FontStyle.Bold);
			this.cb_showdate.ForeColor = Color.Purple;
		}
		private void cb_showdate_MouseLeave(object sender, EventArgs e)
		{
			this.cb_showdate.Font = new Font(font_default, FontStyle.Regular);
			this.cb_showdate.ForeColor = Color.Black;
		}

		private void Form1_MouseLeave(object sender, EventArgs e)
		{

		}

        private void lb_date_Click(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        const string name = "T.T";
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetAutorunValue(true);
        }

        private void bt_auto_off_Click(object sender, EventArgs e)
        {
            SetAutorunValue(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
           alwaysOnTopToolStripMenuItem.Checked = this.TopMost = this.TopMost?false:true;
        }
    }
    
}
