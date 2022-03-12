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
    public partial class ChooseUserAccount : Form
    {
        Controller controllerObj;
        public ChooseUserAccount()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectFirstName();
            FirstName_ComboBox.DataSource = dt;
            FirstName_ComboBox.DisplayMember = "First_Name";

        }

        private void LastName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_ComboBox.Visible = false;
            ID_ComboBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FirstName_ComboBox.Text.ToString() == "" || LastName_ComboBox.Text.ToString() == "" || ID_ComboBox.Text.ToString() == "")
            {
                MessageBox.Show("Insert All Data");
            }
            else
            {
                Controller.SetUserID(Convert.ToInt32(ID_ComboBox.Text));
                Controller.SetUserName(FirstName_ComboBox.Text.ToString());
                MessageBox.Show("Customer Selected");
                this.Hide();
            }
        }

        private void FirstName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastName_ComboBox.Visible = false;
            ID_ComboBox.Visible = false;
            LastName_ComboBox.Text = "";
            ID_ComboBox.Text = "";
        }

        private void ChooseUserAccount_Load(object sender, EventArgs e)
        {
            LastName_ComboBox.Visible = false;
            ID_ComboBox.Visible = false;
        }

        private void ID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LastName_ComboBox.Visible = true;
            DataTable dt = controllerObj.SelectLasttName(FirstName_ComboBox.Text.ToString());
            LastName_ComboBox.DataSource = dt;
            LastName_ComboBox.DisplayMember = "Last_Name";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ID_ComboBox.Visible = true;
            DataTable dt = controllerObj.SelectID(FirstName_ComboBox.Text.ToString(), LastName_ComboBox.Text.ToString());
            ID_ComboBox.DataSource = dt;
            ID_ComboBox.DisplayMember = "ID";
        }
    }
}
