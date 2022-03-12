using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin a = new AdminLogin();
            a.Show();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Individuals f = new Individuals(0);//for admin
            f.Show();
        }
    }
}
