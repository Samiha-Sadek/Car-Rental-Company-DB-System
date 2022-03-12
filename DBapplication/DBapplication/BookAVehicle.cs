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
    public partial class BookAVehicle : Form
    {
        Controller controllerObj;

        public BookAVehicle()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectLocation();
            Location_ComboBox.DataSource = dt;
            Location_ComboBox.DisplayMember = "Parked_in";
        }

        private void book_Button_Click(object sender, EventArgs e)
        {
            if(PlateNumber_ComboBox.Text.ToString() == "")
            {
                MessageBox.Show("Select a Car First");
            }
            else
            {
                Controller.SetPlateNumber(PlateNumber_ComboBox.Text.ToString());
                Controller.SetRentDate(RentDate.Value);
                Controller.SetReturnDate(ReturnDate.Value);
                DataTable dt = controllerObj.SelectBrand(PlateNumber_ComboBox.Text.ToString());
                DataTable dt2 = controllerObj.SelectModel(PlateNumber_ComboBox.Text.ToString());
                Controller.SetBrand(dt.Select()[0][0].ToString());
                Controller.SetModel(dt2.Select()[0][0].ToString());
                MessageBox.Show("Car Selected Successfully");
                //Get Discount 
                if(OfferID_ComboBox.Text.ToString() != "")
                {
                    int discount = 0;
                    DataTable dt3 = controllerObj.GetDiscount(Convert.ToInt32(OfferID_ComboBox.Text));
                    foreach (DataRow row in dt3.Rows)
                    {
                        discount = Convert.ToInt32(row["Percentage_Discount"].ToString());
                    }
                    Controller.SetOfferDiscount(discount);
                }
                this.Hide();
            }
        }

        private void BookAVehicle_Load(object sender, EventArgs e)
        {
            RentDate.MinDate = DateTime.Today;
            ReturnDate.MinDate = DateTime.Today;
            label3.Visible = false;
            ShowAvailableCars_Button.Visible = false;
            Available_Cars_DataGrid.Visible = false;
            Location_ComboBox.Visible = false; 
            OfferList_GridView.Visible = false;
            OfferID_ComboBox.Visible = false;
            label4.Visible = false;
            book_Button.Visible = false;
            OffersList.Visible = false;
            SearchVehicle.Visible = false;
            label1.Visible = false;
            PlateNumber_ComboBox.Visible = false;
            Check_Avail_Cars_Button.Visible = false;
        }

        private void SearchVehicle_Click(object sender, EventArgs e)
        {
            OfferID_ComboBox.Text = "";
            label1.Visible = false;
            PlateNumber_ComboBox.Visible = false;
            label3.Visible = true;
            ShowAvailableCars_Button.Visible = true;
            Location_ComboBox.Visible = true;
            OfferList_GridView.Visible = false;
            OfferID_ComboBox.Visible = false;
            label4.Visible = false;
            book_Button.Visible = false;
            Check_Avail_Cars_Button.Visible = false;
        }

        private void OffersList_Click(object sender, EventArgs e)
        {
            // OfferID_ComboBox.Text = "";
            Location_ComboBox.Text = "";
            PlateNumber_ComboBox.Text = "";
            ShowAvailableCars_Button.Visible = false;
            label3.Visible = false;            
            Location_ComboBox.Visible = false;
            OfferList_GridView.Visible = true;
            OfferID_ComboBox.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
            PlateNumber_ComboBox.Visible = false;
            Available_Cars_DataGrid.Visible = false;

            DataTable dt = controllerObj.SelectOffers_List();
            OfferList_GridView.DataSource = dt;
            OfferList_GridView.Refresh();

            DataTable dt2 = dt;
            OfferID_ComboBox.DataSource = dt;
            OfferID_ComboBox.DisplayMember = "Offer_ID";
            if(OfferID_ComboBox.Text.ToString() == "")
            {
                MessageBox.Show("No Offers Available now");
            }
            else
            {
                Check_Avail_Cars_Button.Visible = true;
            }
        }

        private void SelectCar_Button_Click(object sender, EventArgs e)
        {
            DateTime RentD = RentDate.Value;
            DateTime ReturnD = ReturnDate.Value;
            if(ReturnD < RentD)
            {
                MessageBox.Show("Choose Valid Return and Rent Dates");
            }
            else
            {
                SelectCar_Button.Visible = false;
                OffersList.Visible = true;
                SearchVehicle.Visible = true;
                Controller.SetRentDate(RentD);
                Controller.SetReturnDate(ReturnD);
            }
        }

        private void RentDate_ValueChanged(object sender, EventArgs e)
        {
            OfferID_ComboBox.Text = "";
            SelectCar_Button.Visible = true;
            ShowAvailableCars_Button.Visible = false;
            label3.Visible = false;
            Available_Cars_DataGrid.Visible = false;
            Location_ComboBox.Visible = false;
            OfferList_GridView.Visible = false;
            OfferID_ComboBox.Visible = false;
            label4.Visible = false;
            book_Button.Visible = false;
            OffersList.Visible = false;
            SearchVehicle.Visible = false;
            label1.Visible = false;
            PlateNumber_ComboBox.Visible = false;
        }

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            ShowAvailableCars_Button.Visible = false;
            SelectCar_Button.Visible = true;
            Available_Cars_DataGrid.Visible = false;
            label3.Visible = false;
            Location_ComboBox.Visible = false;
            OfferList_GridView.Visible = false;
            OfferID_ComboBox.Visible = false;
            label4.Visible = false;
            book_Button.Visible = false;
            OffersList.Visible = false;
            SearchVehicle.Visible = false;
            label1.Visible = false;
            PlateNumber_ComboBox.Visible = false;
            OfferID_ComboBox.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Location_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowAvailableCars_Button_Click(object sender, EventArgs e)
        {
            book_Button.Visible = true;
            Available_Cars_DataGrid.Visible = true;
            label1.Visible = true;
            PlateNumber_ComboBox.Visible = true;
            DataTable dt = controllerObj.SelectAvailableCars(Location_ComboBox.Text.ToString(), RentDate.Value, ReturnDate.Value);
            Available_Cars_DataGrid.DataSource = dt;
            Available_Cars_DataGrid.Refresh();
            DataTable dt2 = dt;
            PlateNumber_ComboBox.DataSource = dt;
            PlateNumber_ComboBox.DisplayMember = "VehiclePlateNumber";
        }


        private void Brand_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Model_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Check_Avail_Cars_Button_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.GetOfferDescription(Convert.ToInt32(OfferID_ComboBox.Text));
            string description = "";
            string brand = "";
            string model = "";
            string[] Brand_Model;
            foreach (DataRow row in dt.Rows)
            {
                description = row["Description"].ToString();
            }
            Brand_Model = description.Split(' ');
            int size = Brand_Model.Length;            
            if (size == 1)
            {
                brand = Brand_Model[0];
                DataTable dt2 = controllerObj.SelectCarsBrand(brand, RentDate.Value, ReturnDate.Value);
                PlateNumber_ComboBox.DataSource = dt2;
                PlateNumber_ComboBox.DisplayMember = "VehiclePlateNumber";
                if (PlateNumber_ComboBox.Text.ToString() == "")
                {
                    MessageBox.Show("No Vehicles available for this offer");
                }
                else
                {
                    OfferList_GridView.DataSource = dt2;
                    OfferList_GridView.Refresh();
                    PlateNumber_ComboBox.Visible = true;
                    label1.Visible = true;
                    book_Button.Visible = true;
                }
            }
            else
            {
                brand = Brand_Model[0];
                model = Brand_Model[1];
                DataTable dt1 = controllerObj.SelectCarsBrandModel(brand, model, RentDate.Value, ReturnDate.Value);
                PlateNumber_ComboBox.DataSource = dt1;
                PlateNumber_ComboBox.DisplayMember = "VehiclePlateNumber";
                if (PlateNumber_ComboBox.Text.ToString() == "")
                {
                    MessageBox.Show("No Vehicles available for this offer");
                }
                else
                {
                    OfferList_GridView.DataSource = dt1;
                    OfferList_GridView.Refresh();
                    PlateNumber_ComboBox.Visible = true;
                    label1.Visible = true;
                    book_Button.Visible = true;
                }
                //select plate number, model(if only brand is specified), parked_in 
            }
        }
    }
}
