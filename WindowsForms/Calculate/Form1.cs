using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if(lb_1.Text == "") lb_1.Text += Convert.ToDouble(textBox1.Text);
           else  lb_1.Text += (" + " + Convert.ToDouble(textBox1.Text));
            if(a == 0)
            {
              a = Convert.ToDouble(textBox1.Text);
            } else
            {
                b = Convert.ToDouble(textBox1.Text);
                a += b;
                b = 0;
                textBox1.Text = a.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
