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
    public partial class CreateUserAccount : Form
    {
        Controller controllerObj;
        public CreateUserAccount()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number, id;
            if (FirstName_TextBox.Text == "" || LastName_TextBox.Text == "" || Address_TextBox.Text == "" || MNumber_TextBox.Text == "" || Email_TextBox.Text == "" )
            {
                MessageBox.Show("Insert All Data");
            }
            else
            {
                bool success = int.TryParse(MNumber_TextBox.Text, out number);
                if (!success)
                {
                    MessageBox.Show("Enter a valid mobile number");
                }
                else
                {
                    DataTable dt = controllerObj.CheckEmail(Email_TextBox.Text.ToString());
                    int check = Convert.ToInt32(dt.Rows[0][0]);
                    if (check != 0)
                    {
                        MessageBox.Show("This Email elready exists");
                    }
                    else
                    {
                        DataTable dt2 = controllerObj.GetGreaterID();
                        if(dt2 == null)
                        {
                            id = 1;
                        }
                        else
                        {
                            id = Convert.ToInt32(dt2.Rows[0][0]) + 1;
                        }
                        int r = controllerObj.InsertIndividual(id, FirstName_TextBox.Text.ToString(), LastName_TextBox.Text.ToString(), Address_TextBox.Text.ToString(),'N', 0, MNumber_TextBox.Text.ToString(), Email_TextBox.Text.ToString());
                        MessageBox.Show("User account added successfullly");
                        Controller.SetUserID(id);
                        Controller.SetUserName(FirstName_TextBox.Text.ToString());
                        this.Hide();
                    }
                }

            }
        }

        private void CreateUserAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
