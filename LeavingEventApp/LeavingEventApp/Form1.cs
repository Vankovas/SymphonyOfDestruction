using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Phidget22.Events;
using Phidget22;

namespace LeavingEventApp
{
    public partial class Form1 : Form
    {
        RFID rfid;
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }
        public void StartUp()
        {
            try
            {
                rfid = new RFID();

                rfid.Attach += rfid_Attach;
                rfid.Detach += rfid_Detach;
                rfid.Error += rfid_Error;
                tbBraceletId.Text = "";
                rfid.Tag += rfid_Tag;
                rfid.TagLost += rfid_TagLost;

                rfid.Open();
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch
            {
                MessageBox.Show("something else");
            }
        }

        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            tbStatus.Text = "attached";
        }

        private void rfid_Detach(object sender, DetachEventArgs e)
        {
            tbStatus.Text = "detached";
        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("error");
        }

        private void rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            tbStatus.Text = e.Tag;
            string reg = e.Tag;
            tbBraceletId.Text = reg;
            CheckForLeaving();
           
        }

        private void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            tbStatus.Text = "ready";
        }
        string userID = "";
        string deposit = "";
        int USB = 0;  // how much USB cabels
        int cameras = 0;// how much camers?
        int laptops = 0;  // how much Laptops
        int chargers = 0;  // how much PhoneChargers


        public void CheckForLeaving()
        {
            USB = 0;
            cameras = 0;
            laptops = 0;
            chargers = 0;
            MySqlConnection connection;


            lbInformation.Items.Clear();


            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement3 = "SELECT tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletId.Text.ToString() + "';";
            MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
            MySqlDataReader reader3;
            try
            {
                reader3 = sqlCommand3.ExecuteReader();
                while (reader3.Read())
                {

                    userID = reader3["userID"].ToString();

                }

                connection.Close();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Please enter valid informationasdasd.");

            }

            string deposit = "";
            List<int> items = new List<int>();
            connection.Open();
            string sqlStatement2 = "SELECT SUM(deposit) as `ASD` FROM `loaning` WHERE `userID` = '" + userID.ToString() + "' ;";
            MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, connection);
            MySqlDataReader reader2;
            try
            {
                reader2 = sqlCommand2.ExecuteReader();
                while (reader2.Read())
                {
                    deposit = reader2["ASD"].ToString();
                }
                if (deposit == "")
                {
                    deposit = "0";
                }
                connection.Close();
            }

            catch
            {
                connection.Close();
                MessageBox.Show("Operation Failed 1:( .");

            }



            connection.Open();
            string mySqlStatement7 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 5;";
            MySqlCommand command7 = new MySqlCommand(mySqlStatement7, connection);
            MySqlDataReader reader7;
            try
            {
                reader7 = command7.ExecuteReader();
                while (reader7.Read())
                {
                    cameras = Convert.ToInt32(reader7["ASD"]);
                }
                connection.Close();
            }

            catch
            {
                connection.Close();

            }

            connection.Open();
            string mySqlStatement4 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 6;";
            MySqlCommand command4 = new MySqlCommand(mySqlStatement4, connection);
            MySqlDataReader reader4;
            try
            {
                reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    chargers = Convert.ToInt32(reader4["ASD"]);
                }
                connection.Close();
            }

            catch
            {
                connection.Close();

            }


            connection.Open();
            string mySqlStatement5 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = ' " + userID.ToString() + "' AND itemID = 7;";
            MySqlCommand command5 = new MySqlCommand(mySqlStatement5, connection);
            MySqlDataReader reader5;
            try
            {
                reader5 = command5.ExecuteReader();

                while (reader5.Read())
                {
                    laptops = Convert.ToInt32(reader5["ASD"]);
                }
                connection.Close();
            }

            catch
            {
                connection.Close();

            }


            connection.Open();
            string mySqlStatement6 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 8;";
            MySqlCommand command6 = new MySqlCommand(mySqlStatement6, connection);
            MySqlDataReader reader6;
            try
            {
                reader6 = command6.ExecuteReader();
                while (reader6.Read())
                {
                    USB = Convert.ToInt32(reader6["ASD"]);
                }
                connection.Close();

            }

            catch
            {
                connection.Close();

            }
            if (cameras == 0 && laptops == 0 && chargers == 0 && USB == 0)
            {
                connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                 "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
                connection.Open();
                string sqlStatement = "SELECT tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletId.Text + "';";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                MySqlDataReader reader;
                try
                {
                    reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {

                        userID = reader["userID"].ToString();

                    }
                    connection.Close();
                }
                catch
                {
                    connection.Close();
                    MessageBox.Show("Please enter valid information222222222.");
                    return;
                }

                connection.Open();
                string sqlStatement1 = "UPDATE `ticket` SET `inside` = '0' WHERE userID = '" + userID.ToString() + "';";
                MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, connection);
                sqlCommand1.ExecuteNonQuery();
              
                connection.Close();



                lbInformation.Items.Add("This User Has Nothing To Return");

                return;
            }
            lbInformation.Items.Add("User with ID - " + userID + " deposited:");
            lbInformation.Items.Add(deposit + "$ for the following items:");
            lbInformation.Items.Add("Cameras: " + cameras.ToString());
            lbInformation.Items.Add("Phone Chargers: " + chargers.ToString());
            lbInformation.Items.Add("Laptops: " + laptops.ToString());
            lbInformation.Items.Add("USB Cabels: " + USB.ToString());
        }
        private void btnLeaveEvent_Click(object sender, EventArgs e)
        {
            USB = 0;
            cameras = 0;
            laptops = 0;
            chargers = 0;
            MySqlConnection connection;
           

            lbInformation.Items.Clear();

            
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement3 = "SELECT tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletId.Text.ToString() + "';";
            MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
            MySqlDataReader reader3;
            try
            {
                reader3 = sqlCommand3.ExecuteReader();
                while (reader3.Read())
                {

                    userID = reader3["userID"].ToString();

                }

                connection.Close();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Please enter valid informationasdasd.");

            }

            string deposit = "";
            List<int> items = new List<int>();
            connection.Open();
            string sqlStatement2 = "SELECT SUM(deposit) as `ASD` FROM `loaning` WHERE `userID` = '" + userID.ToString() + "' ;";
            MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, connection);
            MySqlDataReader reader2;
            try
            {
                reader2 = sqlCommand2.ExecuteReader();
                while (reader2.Read())
                {
                    deposit = reader2["ASD"].ToString();
                }
                if(deposit == "")
                {
                    deposit = "0";
                }
                connection.Close();
            }

            catch
            {
                connection.Close();
                MessageBox.Show("Operation Failed 1:( .");

            }



            connection.Open();
            string mySqlStatement7 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 5;";
            MySqlCommand command7 = new MySqlCommand(mySqlStatement7, connection);
            MySqlDataReader reader7;
            try
            {
                reader7 = command7.ExecuteReader();
                while (reader7.Read())
                {
                    cameras = Convert.ToInt32(reader7["ASD"]);
                }
                connection.Close();
            }

            catch
            {
                connection.Close();

            }

            connection.Open();
            string mySqlStatement4 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 6;";
            MySqlCommand command4 = new MySqlCommand(mySqlStatement4, connection);
            MySqlDataReader reader4;
            try
            {
                reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    chargers = Convert.ToInt32(reader4["ASD"]);
                }
                connection.Close();
            }

            catch
            {
                connection.Close();

            }


            connection.Open();
            string mySqlStatement5 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = ' " + userID.ToString() + "' AND itemID = 7;";
            MySqlCommand command5 = new MySqlCommand(mySqlStatement5, connection);
            MySqlDataReader reader5;
            try
            {
                reader5 = command5.ExecuteReader();

                while (reader5.Read())
                {
                    laptops = Convert.ToInt32(reader5["ASD"]);
                }
                connection.Close();
            }

            catch
            {
                connection.Close();

            }


            connection.Open();
            string mySqlStatement6 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 8;";
            MySqlCommand command6 = new MySqlCommand(mySqlStatement6, connection);
            MySqlDataReader reader6;
            try
            {
                reader6 = command6.ExecuteReader();
                while (reader6.Read())
                {
                    USB = Convert.ToInt32(reader6["ASD"]);
                }
                connection.Close();

            }

            catch
            {
                connection.Close();

            }
            if (cameras == 0 && laptops == 0 && chargers == 0 && USB == 0)
            {
                connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                 "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
                connection.Open();
                string sqlStatement = "SELECT tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletId.Text + "';";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                MySqlDataReader reader;
                try
                {
                    reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {

                        userID = reader["userID"].ToString();

                    }
                    connection.Close();
                }
                catch
                {
                    connection.Close();
                    MessageBox.Show("Please enter valid information222222222.");
                    return;
                }

                connection.Open();
                string sqlStatement1 = "UPDATE `ticket` SET `inside` = '0' WHERE userID = '" + userID.ToString() + "';";
                MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, connection);
                sqlCommand1.ExecuteNonQuery();
               
                connection.Close();



                lbInformation.Items.Add("This User Has Nothing To Return");

                return;
            }
            lbInformation.Items.Add("User with ID - " + userID + " deposited:");
            lbInformation.Items.Add(deposit + "$ for the following items:");
            lbInformation.Items.Add("Cameras: " + cameras.ToString());
            lbInformation.Items.Add("Phone Chargers: " + chargers.ToString());
            lbInformation.Items.Add("Laptops: " + laptops.ToString());
            lbInformation.Items.Add("USB Cabels: " + USB.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
