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
    public partial class ViewUserAccount : Form
    {
        Controller controllerObj;
        public ViewUserAccount()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewUserAccount_Load(object sender, EventArgs e)
        {
            int id = Controller.GetUserID();
            DataTable dt = controllerObj.SelectUserInfo(id);
            string Fname = "", Lname = "", address = "", premium = "", balance = "", number = "", email = "";
            foreach (DataRow row in dt.Rows)
            {
                Fname = row["First_Name"].ToString();
                Lname = row["Last_Name"].ToString();
                address = row["Address"].ToString();
                premium = row["Is_Premium_Account"].ToString();
                balance = row["Individual_Balance"].ToString();
                number = row["Contact_Number"].ToString();
                email = row["Email"].ToString();
            }
            ViewID_TextBox.Text = id.ToString();
            ViewFName_TextBox.Text = Fname;
            ViewLName_TextBox.Text = Lname;
            ViewAddress_TextBox.Text = address;
            ViewBalance_TextBox.Text = balance;
            ViewMNumber_TextBox.Text = number;
            ViewEmail_TextBox.Text = email;
            if(premium == "Y")
            {
                Premium_CheckBox.Checked = true;
                Upgrade_Button.Visible = false;
            }
        }

        private void Upgrade_Button_Click(object sender, EventArgs e)
        {
            int id = Controller.GetUserID();
            controllerObj.UpgradeCustomer(id);
            Premium_CheckBox.Checked = true;
            Upgrade_Button.Visible = false;
        }
    }
}
