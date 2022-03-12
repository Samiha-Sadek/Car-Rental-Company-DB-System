using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        static string PlateNumber = "";
        static DateTime RentDate;
        static DateTime Returndate;
        static int Price = -1;
        static int UserID = 0;
        static string UserName;
        static string Brand;
        static string Model;
        static int Balance = 0;
        static int OfferDiscount = 0;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        /// <summary>
        /// /Setter and getters
        /// 
        static public void SetUserID(int id)
        {
            UserID = id;
        }
        static public int GetUserID()
        {
            return UserID;
        }
        static public void SetPlateNumber(string PN)
        {
            PlateNumber = PN;
        }
        static public string GetPlateNumber()
        {
            return PlateNumber;
        }
        static public void SetPrice(int p)
        {
            Price = p;
        }
        static public int GetPrice()
        {
            return Price;
        }
        static public void SetRentDate(DateTime RD)
        {
            RentDate = RD;
        }
        static public DateTime GetRentDate()
        {
            return RentDate;
        }
        static public void SetReturnDate(DateTime RD)
        {
            Returndate = RD;
        }
        static public DateTime GetReturnDate()
        {
            return Returndate;
        }
        static public void SetUserName(string UN)
        {
            UserName = UN;
        }
        static public string GetUserName()
        {
            return UserName;
        }
        static public void SetBrand(string B)
        {
            Brand = B;
        }
        static public string GetBrand()
        {
            return Brand;
        }
        static public void SetModel (string M)
        {
            Model = M;
        }
        static public string GetModel()
        {
            return Model;
        }
        static public void SetBalance(int b)
        {
            Balance = b;
        }
        static public int GetBalance()
        {
            return Balance;
        }
        static public void SetOfferDiscount(int d)
        {
            OfferDiscount = d;
        }
        static public int GetOfferDiscount()
        {
            return OfferDiscount;
        }
        /// <summary>
        /// Queries
        /// </summary>

        public DataTable CheckEmail(string email)
        {
            string query = "SELECT COUNT(*) FROM Individuals WHERE Email='" 
                + email + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTimesRentedV(string PlateNumber)
        {
            string StoredProcedureName = StoredProcedures.GetTimesRentedV;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PlateNumber", PlateNumber);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //**??**//
        //public int InsertIndividual(int id, string fname, string lname, string address, char premium, int balance, string number, string email)
        //{
        //    string query = "INSERT INTO Individuals (ID, First_Name, Last_Name, Address, Is_Premium_Account, Individual_Balance, Contact_Number, Email)" +
        //                    "Values (" + id + ",'" + fname + "','" + lname + "','" + address + "','" + premium + "'," + balance + ",'" + number + "','" + email + "');";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int InsertIndividual(int id, string fname, string lname, string address, char premium, int balance, string number, string email)
        {
            string StoredProcedureName = StoredProcedures.InsertIndividual;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@fname", fname);
            Parameters.Add("@lname", lname);
            Parameters.Add("@address", address);
            Parameters.Add("@premium", premium);
            Parameters.Add("@balance", balance);
            Parameters.Add("@number", number);
            Parameters.Add("@email", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        //**??**//
        public DataTable GetGreaterID()
        {
            string query = "SELECT MAX(ID) FROM Individuals;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectFirstName()
        {
            string query = "SELECT DISTINCT First_Name FROM Individuals;";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectLasttName(string fname)
        {
            string query = "SELECT DISTINCT Last_Name FROM Individuals WHERE First_Name='"+fname+"';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectID(string fname, string lname)
        {
            string query = "SELECT DISTINCT ID FROM Individuals WHERE First_Name='" + fname + "' AND Last_Name='" + lname + "';";

            return dbMan.ExecuteReader(query);
        }
        
        public DataTable SelectLocation()
        {
            string query = "SELECT DISTINCT Parked_in FROM Cars;";

            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAvailableCars(string location, DateTime rentd, DateTime returnd)
        {
            string query = "SELECT VehiclePlateNumber, Brand, Model FROM Cars C, Car_Tracks T " +
                "WHERE Parked_in = '" + location + "' AND (C.Vehicle_Availability='Available' "+
                "OR (C.Vehicle_Availability='Booked' AND C.VehiclePlateNumber = T.Plate_Number AND " + 
                "((T.Rent_Date>'" + returnd + "') OR (T.Return_Date<'" + rentd + "'))));";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectBrand(string plateN)
        {
            string query = "SELECT Brand FROM Cars WHERE VehiclePlateNumber='" + plateN + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectModel(string plateN)
        {
            string query = "SELECT Model FROM Cars WHERE VehiclePlateNumber='" + plateN + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectUserInfo(int id)
        {
            string query = "SELECT First_Name, Last_Name, Address, Is_Premium_Account, Individual_Balance, Contact_Number, Email FROM Individuals WHERE ID=" + id + ";";
            return dbMan.ExecuteReader(query);
        }
        //**??**//
        public int UpgradeCustomer(int id)
        {
            string query = "UPDATE Individuals SET Is_Premium_Account = 'Y' WHERE ID=" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        //**??**//
        public DataTable GetIsPremium(int id)
        {
            string query = "SELECT Is_Premium_Account, Individual_Balance FROM Individuals WHERE ID=" + id + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetInsurancePrice(string PN)
        {
            string query = "SELECT Insurance_Price FROM Cars WHERE VehiclePlateNumber='" + PN + "';";
            return dbMan.ExecuteReader(query);
        }
        //**??**//
        public int UpdateVehcileAvailability(string PN)
        {
            string query = "UPDATE Vehicles SET Vehicle_Availability = 'Booked' WHERE VehiclePlateNumber='" + PN + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        //**??**//
        public int UpdateIndividualBalance(int id, int b)
        {
            string query = "UPDATE Individuals SET Individual_Balance =" + b + "WHERE ID=" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        //**??**//
        public int InsertTracks(string PN, DateTime RentD, DateTime BookingD, DateTime ReturnD, int price, int id)
        {
            string query = "INSERT INTO Tracks (Plate_Number, Rent_Date, Booking_Date, Return_Date, Price, Individual_ID)" +
                            "Values ('" + PN + "','" + RentD + "','" + BookingD + "','" + ReturnD + "'," + price + "," + id + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        //**??**//
        public DataTable SelectOffers_List()
        {
            string query = "SELECT * FROM Cars_Offer_List;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetOfferDescription(int id)
        {
            string query = "SELECT Description FROM Cars_Offer_list WHERE Offer_ID=" + id + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCarsBrandModel(string brand, string model, DateTime rentd, DateTime returnd)
        {
            string query = "SELECT VehiclePlateNumber, Parked_in FROM Cars C, Car_Tracks T " +
                "WHERE (Brand = '" + brand + "' AND Model = '"+ model +"') AND (C.Vehicle_Availability='Available' " +
                "OR (C.Vehicle_Availability='Booked' AND C.VehiclePlateNumber = T.Plate_Number AND " +
                "((T.Rent_Date>'" + returnd + "') OR (T.Return_Date<'" + rentd + "'))));";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCarsBrand(string brand, DateTime rentd, DateTime returnd)
        {
            string query = "SELECT VehiclePlateNumber, Model, Parked_in FROM Cars C, Car_Tracks T " +
                "WHERE (Brand = '" + brand + "') AND (C.Vehicle_Availability='Available' " +
                "OR (C.Vehicle_Availability='Booked' AND C.VehiclePlateNumber = T.Plate_Number AND " +
                "((T.Rent_Date>'" + returnd + "') OR (T.Return_Date<'" + rentd + "'))));";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetDiscount(int id)
        {
            string query = "SELECT Percentage_Discount FROM Cars_Offer_list WHERE Offer_ID=" + id + ";";
            return dbMan.ExecuteReader(query);
        }

    }
}
