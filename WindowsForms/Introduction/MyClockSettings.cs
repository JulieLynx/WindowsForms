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
    public partial class MyClockSettings : Form
    {
        Form1 parent;
        public MyClockSettings(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.checkBox1.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;
           //// this.cbShowDate.Checked = parent.Lb_date.Visible;
        }

        private void btnCalcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //    checkBox1.Checked = 
            //Application.OpenForms[0].TopMost =
            //Application.OpenForms[0].TopMost ? false : true;
            parent.alwaysOnTopToolStripMenuItem_Click(sender,e);
            checkBox1.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if(this.checkBox1.Checked)checkBox1_Click(sender,e);
            //if(this.cbShowDate.Checked)cbShowDate_Click(sender,e);
           // if(checkBox1.Checked)(sender, e);
           //if( cbShowDate.Checked)(senser, e);
            this.Close();
        }

        private void cbShowDate_CheckedChanged(object sender, EventArgs e)
        {
           // parent.Lb_date.Visible = parent.Lb_date.Visible ? false : true;
        }

        private void cbShowDate_Click(object sender, EventArgs e)
        {
           //// parent.Lb_date.Visible = parent.Lb_date.Checked ? false : true;
        }
    }
}
