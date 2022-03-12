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
    public partial class Individuals : Form
    {
        Controller controllerObj;
        public Individuals(int a)
        {
            InitializeComponent();
            if (a == 0) //1 for admin, 0 for other
            {
                this.SelectCustomer_Button.Enabled = true;
            }
            controllerObj = new Controller();
        }

        private void Individuals_Load(object sender, EventArgs e)
        {
            ConfirmBooking_Button.Visible = false;
            BookCar_Button.Visible = false;
            CreateAccount_Button.Visible = false;
            ChooseAccount_Button.Visible = false;
            ViewAccount_Button.Visible = false;
            ShowSelectedCar_Button.Visible = false;
            CalculatePrice_Button.Visible = false;
            ShowSelectedCustomer_Button.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            Price_RO_TextBox.Visible = false;
            Name_RO_TextBox.Visible = false;
            ID_RO_TextBox.Visible = false;
            Brand_RO_TextBox.Visible = false;
            Model_RO_TextBox.Visible = false;
            PlateNumber_RO_TextBox.Visible = false;

        }

        private void SelectCustomer_Button_Click(object sender, EventArgs e)
        {
            CreateAccount_Button.Visible = true;
            ChooseAccount_Button.Visible = true;
        }

        private void CreateAccount_Button_Click(object sender, EventArgs e)
        {
            Price_RO_TextBox.Visible = false;
            label8.Visible = false;
            ConfirmBooking_Button.Visible = false;
            Name_RO_TextBox.Clear();
            ID_RO_TextBox.Clear();
            Controller.SetUserID(0);
            ViewAccount_Button.Visible = true;
            BookCar_Button.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            Name_RO_TextBox.Visible = true;
            ID_RO_TextBox.Visible = true;
            ShowSelectedCustomer_Button.Visible = true;
            CreateUserAccount CUA = new CreateUserAccount();
            CUA.Show();
        }

        private void ChooseAccount_Button_Click(object sender, EventArgs e)
        {
            Price_RO_TextBox.Visible = false;
            label8.Visible = false;
            ConfirmBooking_Button.Visible = false;
            Name_RO_TextBox.Clear();
            ID_RO_TextBox.Clear();
            Controller.SetUserID(0);
            label2.Visible = true;
            label3.Visible = true;
            ShowSelectedCustomer_Button.Visible = true;
            Name_RO_TextBox.Visible = true;
            ID_RO_TextBox.Visible = true;
            ViewAccount_Button.Visible = true;
            BookCar_Button.Visible = true;
            ChooseUserAccount ChooseUA = new ChooseUserAccount();
            ChooseUA.Show();
        }

        private void BookCar_Button_Click(object sender, EventArgs e)
        {
            Price_RO_TextBox.Visible = false;
            label8.Visible = false;
            ConfirmBooking_Button.Visible = false;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            ShowSelectedCar_Button.Visible = true;
            Brand_RO_TextBox.Visible = true;
            Model_RO_TextBox.Visible = true;
            PlateNumber_RO_TextBox.Visible = true;
            Model_RO_TextBox.Clear();
            Brand_RO_TextBox.Clear();
            PlateNumber_RO_TextBox.Clear();
            Controller.SetPlateNumber("");
            Controller.SetOfferDiscount(0);
            BookAVehicle BV = new BookAVehicle();
            CalculatePrice_Button.Visible = true;
            BV.Show();
        }

        private void ViewAccount_Button_Click(object sender, EventArgs e)
        {
            int id = Controller.GetUserID();
            if(id == 0)
            {
                MessageBox.Show("Select an account first");
            }
            else
            {
                ViewUserAccount VUA = new ViewUserAccount();
                VUA.Show();
            }
        }

        private void CalculatePrice_Button_Click(object sender, EventArgs e)
        {
            int id = Controller.GetUserID();
            String PlateNumber = Controller.GetPlateNumber();
            if(id == 0 || PlateNumber == "")
            {
                MessageBox.Show("Select a Car and a Customer First");
            }
            else
            {
                label8.Visible = true;
                Price_RO_TextBox.Visible = true;
                ConfirmBooking_Button.Visible = true;
                DateTime RentD = Controller.GetRentDate();
                DateTime ReturnD = Controller.GetReturnDate();
                int NofDays = (ReturnD.Date - RentD.Date).Days + 1;
                DataTable dt = controllerObj.GetInsurancePrice(Controller.GetPlateNumber());
                DataTable dt1 = controllerObj.GetIsPremium(id);
                int Insurance = 0;
                string Ispremium = "";
                int Balance = 0;
                foreach (DataRow row in dt.Rows)
                {
                    Insurance = Convert.ToInt32(row["Insurance_Price"].ToString());
                }
                foreach (DataRow row in dt1.Rows)
                {
                    Ispremium = row["Is_Premium_Account"].ToString();
                    Balance = Convert.ToInt32(row["Individual_Balance"]);
                }
                Controller.SetBalance(Balance);
                double RentalPrice = (Insurance / 10) * NofDays;
                if(Ispremium == "Y")
                {
                    RentalPrice = 0.85 * RentalPrice;
                }
                int discount = Controller.GetOfferDiscount();
                if (discount != 0)
                {
                    double x = 1.0 - (discount / 100.0);
                    RentalPrice = x * RentalPrice;
                }
                Controller.SetPrice(Convert.ToInt32(RentalPrice));
                Price_RO_TextBox.Text = (Convert.ToInt32(RentalPrice)).ToString();
            }
        }

        private void Name_RO_TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ID_RO_TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ShowSelectedCustomer_Button_Click(object sender, EventArgs e)
        {
            int id = Controller.GetUserID();
            if(id == 0)
            {
                MessageBox.Show("Select a customer First");
            }
            else
            {
                ID_RO_TextBox.Text = id.ToString();
                Name_RO_TextBox.Text = Controller.GetUserName();
            }
        }

        private void ShowSelectedCar_Button_Click(object sender, EventArgs e)
        {
            string PlateNumber = Controller.GetPlateNumber();
            if(PlateNumber == "")
            {
                MessageBox.Show("Select a car First");
            }
            else 
            {
                PlateNumber_RO_TextBox.Text = PlateNumber;
                Brand_RO_TextBox.Text = Controller.GetBrand();
                Model_RO_TextBox.Text = Controller.GetModel();
            }
        }

        private void ConfirmBooking_Button_Click(object sender, EventArgs e)
        {
            int id = Controller.GetUserID();
            String PlateNumber = Controller.GetPlateNumber();
            int price = Controller.GetPrice();
            if (id == 0 || PlateNumber == "" || price == -1)
            {
                MessageBox.Show("Complete All Oprations First");
            }
            else
            {
                MessageBox.Show("Booking Confirmed");
                ConfirmBooking_Button.Visible = false;
                BookCar_Button.Visible = false;
                ViewAccount_Button.Visible = false;
                ShowSelectedCar_Button.Visible = false;
                CalculatePrice_Button.Visible = false;
                ShowSelectedCustomer_Button.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                Price_RO_TextBox.Visible = false;
                Name_RO_TextBox.Visible = false;
                ID_RO_TextBox.Visible = false;
                Brand_RO_TextBox.Visible = false;
                Model_RO_TextBox.Visible = false;
                PlateNumber_RO_TextBox.Visible = false;
                int r = controllerObj.UpdateVehcileAvailability(PlateNumber);
                int r1 = controllerObj.UpdateIndividualBalance(id ,Controller.GetBalance() - Controller.GetPrice());
                int r2 = controllerObj.InsertTracks(PlateNumber, Controller.GetRentDate(), DateTime.Today, Controller.GetReturnDate(), price, id);
                Controller.SetUserID(0);
                Controller.SetPlateNumber("");
                Controller.SetOfferDiscount(0);
                Controller.SetPrice(-1);
            }
        }
    }
}
