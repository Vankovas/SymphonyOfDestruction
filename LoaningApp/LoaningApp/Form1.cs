using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22.Events;
using Phidget22;

namespace LoaningApp
{
    public partial class Form1 : Form
    {
        public string item;
        List<string> loans = new List<string>();

        double total;
        double balance;
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }
        private double priceLine(object price)
        {
            return (Convert.ToDouble(price));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userID = "";
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                  "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT balance, tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletId.Text + "';";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader;
            try
            {
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    balance = priceLine(reader["balance"]);
                    userID = reader["userID"].ToString();

                }
                connection.Close();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Please enter valid information.");
                return;
            }
            if (balance < total)
            {
               
                MessageBox.Show("This User doesn't have enough money.");
                lbSHOP.Items.Clear();
                loans.Clear();
                lbTotal.Text = "Loan: 0 $";
                total = 0;
                return;
            }
            else
            {
                connection.Open();
                string sqlStatement2 = "UPDATE `visitor`,`ticket` SET `balance` = " + (balance - total) + " WHERE `visitor`.`userID` = `ticket`.`userID` AND `ticket`.`braceletID` = '" + tbBraceletId.Text + "' ;";
                MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, connection);
                sqlCommand2.ExecuteNonQuery();


                lbSHOP.Items.Clear();
                total = 0;
                lbTotal.Text = "Loan: 0 $";
                RegisterItems(userID);
                tbBraceletId.Clear();
                MessageBox.Show("Transaction Successful!");
            }
            connection.Close();
            loans.Clear();

        }
        int quantity5 = 0;
        int quantity6 = 0;
        int quantity7 = 0;
        int quantity8 = 0;
        double deposit5;
        double deposit6;
        double deposit7;
        double deposit8;
        public void RegisterItems(string addUserID)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");

            //int quantity5 = 0;  
            //int quantity6 = 0;  
            //int quantity7 = 0;  
            //int quantity8 = 0;  

            foreach (string itemID in loans)
            {
                if (itemID == "5")
                {
                    quantity5++;
                }
                if (itemID == "6")
                {
                    quantity6++;
                }
                if (itemID == "7")
                {
                    quantity7++;

                }
                if (itemID == "8")
                {
                    quantity8++;
                }
            }
            deposit5 = depositCamera * quantity5;
            deposit6 = depositCharger * quantity6;
            deposit7 = depositAcer * quantity7;
            deposit8 = depositUSB * quantity8;

            if (quantity5 != 0)
            {
                connection.Open();
                string sqlStatement3 = "INSERT INTO `loaning` (`loanID`, `userID`, `itemID`, `quantityLoaned`, `deposit`, `loanDate`, `returnDate`) VALUES(NULL, '" + addUserID + "' , '5', '" + quantity5.ToString() + "', '" + deposit5.ToString() + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "' );";
                MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
                try
                {
                    sqlCommand3.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid user Id1");
                    connection.Close();
                    return;
                }

            }
            if (quantity6 != 0)
            {
                connection.Open();
                string sqlStatement3 = "INSERT INTO `loaning` (`loanID`, `userID`, `itemID`, `quantityLoaned`, `deposit`, `loanDate`, `returnDate`) VALUES(NULL, '" + addUserID + "' , '6', '" + quantity6.ToString() + "', '" + deposit6.ToString() + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "' );";
                MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
                sqlCommand3.ExecuteNonQuery();
                connection.Close();
            }
            if (quantity7 != 0)
            {
                connection.Open();
                string sqlStatement3 = "INSERT INTO `loaning` (`loanID`, `userID`, `itemID`, `quantityLoaned`, `deposit`, `loanDate`, `returnDate`) VALUES(NULL, '" + addUserID + "' , '7', '" + quantity7.ToString() + "', '" + deposit7.ToString() + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "' );";
                MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
                sqlCommand3.ExecuteNonQuery();
                connection.Close();
            }
            if (quantity8 != 0)
            {
                connection.Open();
                string sqlStatement3 = "INSERT INTO `loaning` (`loanID`, `userID`, `itemID`, `quantityLoaned`, `deposit`, `loanDate`, `returnDate`) VALUES(NULL, '" + addUserID + "' , '8', '" + quantity8.ToString() + "', '" + deposit8.ToString() + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "' );";
                MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
                sqlCommand3.ExecuteNonQuery();
                connection.Close();
            }
            quantity5 = 0;
            quantity6 = 0;
            quantity7 = 0;
            quantity8 = 0;
        }

        double depositCamera = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            item = "Sony Video Camera";
            double price = 0;

            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT price,itemID FROM `items` WHERE name = '" + item + "'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //loans.Add(reader["itemID"].ToString());
                price = priceLine(reader["price"]);

                depositCamera = price * 0.1;

            }

            connection.Close();
            //
            connection.Open();
            string sqlStatement3 = "UPDATE `items` SET `inStock` = inStock - 1 WHERE `items`.`itemID`= 5 ;";
            MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
            try
            {
                sqlCommand3.ExecuteNonQuery();
                lbSHOP.Items.Add("Sony Pro Camera : " + depositCamera + "$.");
                total = total + depositCamera;
                loans.Add("5");
                lbTotal.Text = "Loan: " + total.ToString() + "$";
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We are out of stock.");
                connection.Close();
            }

        }
        double depositCharger = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            item = "Phone Charger";
            double price = 0;

            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                  "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT price,itemID FROM `items` WHERE name = '" + item + "'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //loans.Add(reader["itemID"].ToString());
                price = priceLine(reader["price"]);

                depositCharger = price * 0.1;
            }

            connection.Close();
            //
            connection.Open();
            string sqlStatement3 = "UPDATE `items` SET `inStock` = inStock - 1 WHERE `items`.`itemID`= 6 ;";
            MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
            try
            {
                sqlCommand3.ExecuteNonQuery();
                lbSHOP.Items.Add("Phone Charger : " + depositCharger + "$.");
                total = total + depositCharger;
                loans.Add("6");
                lbTotal.Text = "Loan: " + total.ToString() + "$";
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("We are out of stock.");
                connection.Close();
            }
        }


        double depositAcer = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            item = "Laptop Acer";
            double price = 0;

            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                 "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT price,itemID FROM `items` WHERE name = '" + item + "'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //loans.Add(reader["itemID"].ToString());
                price = priceLine(reader["price"]);

                depositAcer = price * 0.1;
            }
            connection.Close();
            //
            connection.Open();
            string sqlStatement3 = "UPDATE `items` SET `inStock` = inStock - 1 WHERE `items`.`itemID`= 7 ;";
            MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
            try
            {
                sqlCommand3.ExecuteNonQuery();
                lbSHOP.Items.Add("Laptop Acer : " + depositAcer + "$.");
                total = total + depositAcer;
                loans.Add("7");
                lbTotal.Text = "Loan: " + total.ToString() + "$";
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We are out of stock.");
                connection.Close();
            }

        }



        double depositUSB = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            item = "USB Charger";
            double price = 0;
            double deposit = 0;
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT price,itemID FROM `items` WHERE name = '" + item + "'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //loans.Add(reader["itemID"].ToString());
                price = priceLine(reader["price"]);

                deposit = price * 0.1;
            }

            connection.Close();
            //
            connection.Open();

            string sqlStatement3 = "UPDATE `items` SET `inStock` = inStock - 1 WHERE `items`.`itemID`= 8 ;";
            MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);

            try
            {
                sqlCommand3.ExecuteNonQuery();
                loans.Add("8");
                lbSHOP.Items.Add("USB Charger : " + deposit + "$.");
                total = total + deposit;
                lbTotal.Text = "Loan: " + total.ToString() + "$";
                depositUSB = deposit;
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We are out of stock.");
                connection.Close();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int index = lbSHOP.SelectedIndex;
            double priceRemove = 0;

            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            try
            {
                string sqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID`= " + loans[index].ToString() + " ;";
                MySqlCommand sqlCommand3 = new MySqlCommand(sqlStatement3, connection);
                sqlCommand3.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item to return.");
                return;

            }




            lbSHOP.Items.RemoveAt(index);

            connection.Open();
            string sqlStatement4 = "SELECT price FROM `items` WHERE itemID = '" + loans[index].ToString() + "';";
            MySqlCommand sqlCommand4 = new MySqlCommand(sqlStatement4, connection);
            MySqlDataReader reader;
            reader = sqlCommand4.ExecuteReader();

            while (reader.Read())
            {
                priceRemove = Convert.ToDouble(reader["price"]) * 0.1;
            }
            connection.Close();

            loans.RemoveAt(index);
            MessageBox.Show("Removed successfully");
            total = total - priceRemove;
            lbTotal.Text = "Loan: " + total.ToString() + "$";

        }
        string userID = "";
        string deposit = "";
        int USB = 0;  // how much USB cabels
        int cameras = 0;// how much camers?
        int laptops = 0;  // how much Laptops
        int chargers = 0;  // how much PhoneChargers


        private void button6_Click(object sender, EventArgs e)
        {

            lbInformation.Items.Clear();

            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletID2.Text.ToString() + "';";
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
                MessageBox.Show("Please enter valid information.");

            }

            string deposit = "0";
            List<int> items = new List<int>();
            connection.Open();
            string sqlStatement1 = "SELECT SUM(deposit) as `ASD` FROM `loaning` WHERE `userID` = '" + userID.ToString() + "' ;";
            MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, connection);
            MySqlDataReader reader1;
            try
            {
                reader1 = sqlCommand1.ExecuteReader();
                while (reader1.Read())
                {
                    
                    deposit = reader1["ASD"].ToString();
                    if(deposit == "")
                    {
                        deposit = "0";
                    }
                }
                connection.Close();
            }

            catch
            {
                connection.Close();
                MessageBox.Show("Operation Failed 1:( .");

            }



            connection.Open();
            string mySqlStatement3 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 5;";
            MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
            MySqlDataReader reader3;
            try
            {
                reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    cameras = Convert.ToInt32(reader3["ASD"]);
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


            lbInformation.Items.Add("User with ID - " + userID + " deposited:");
            lbInformation.Items.Add(deposit + "$ for the following items:");
            lbInformation.Items.Add("Cameras: " + cameras.ToString());
            lbInformation.Items.Add("Phone Chargers: " + chargers.ToString());
            lbInformation.Items.Add("Laptops: " + laptops.ToString());
            lbInformation.Items.Add("USB Cabels: " + USB.ToString());
            button7.Visible = true;


        }



        double moneyToGiveBack;

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string mySqlStatement = "DELETE FROM loaning WHERE userID =" + userID.ToString() + ";";
            MySqlCommand command = new MySqlCommand(mySqlStatement, connection);
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + " + cameras.ToString() + " WHERE `items`.`itemID` = 5;";
            MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
            command3.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string mySqlStatement4 = "UPDATE `items` SET `inStock` = inStock + " + laptops.ToString() + " WHERE `items`.`itemID` = 7;";
            MySqlCommand command4 = new MySqlCommand(mySqlStatement4, connection);
            command4.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string mySqlStatement5 = "UPDATE `items` SET `inStock` = inStock + " + chargers.ToString() + " WHERE `items`.`itemID` = 6;";
            MySqlCommand command5 = new MySqlCommand(mySqlStatement5, connection);
            command5.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string mySqlStatement6 = "UPDATE `items` SET `inStock` = inStock + " + USB.ToString() + " WHERE `items`.`itemID` = 8;";
            MySqlCommand command6 = new MySqlCommand(mySqlStatement6, connection);
            command6.ExecuteNonQuery();
            connection.Close();


            moneyToGiveBack = deposit5 + deposit6 + deposit7 + deposit8;
            connection.Open();
            string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + " + moneyToGiveBack.ToString() + " WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
            MySqlCommand command1 = new MySqlCommand(mySqlStatement2, connection);
            command1.ExecuteNonQuery();
            connection.Close();
            lbInformation.Items.Clear();
            tbBraceletID2.Clear();
            button7.Visible = false;
            

            quantityCameras = 0;
            quantityChargers = 0;
            quantityLaptops = 0;
            quantityUSBs = 0;
            deposit6 = 0;
            deposit7 = 0;
            deposit8 = 0;
            deposit5 = 0;
            cameras = 0;
            laptops = 0;
            USB = 0;
            chargers = 0;

        }
        int quantityCameras = 0;
        string loanID = "";
        private void btnCameraReturn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                  "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();

            string mySqlStatement = "SELECT quantityLoaned,loanID FROM loaning WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemID = 5;";
            MySqlCommand command = new MySqlCommand(mySqlStatement, connection);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantityCameras = Convert.ToInt32(reader[0]);
                loanID = reader[1].ToString();
            }
            lbInformation.Items.Add(quantityCameras);
            lbInformation.Items.Add(loanID);
            connection.Close();

            if (quantityCameras > 1)
            {
                connection.Open();

                string mySqlStatement1 = "UPDATE `loaning` SET `quantityLoaned` = quantityLoaned - 1 , deposit = deposit - 80 WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemId = '5';";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityCameras--;
                deposit5 -= 80;
                cameras--;
                


                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 5;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 80 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();

            }
            else if (quantityCameras == 1)
            {
                connection.Open();

                string mySqlStatement1 = "DELETE FROM `loaning` WHERE `loaning`.`loanID` = " + loanID.ToString() + ";";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityCameras--;
                deposit5 -= 80;
                cameras--;
                


                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 5;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 80 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();
            }

            lbInformation.Items.Clear();
            tbBraceletID2.Clear();
           

        }
        int quantityLaptops;
        private void btnLaptopReturn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();

            string mySqlStatement = "SELECT quantityLoaned,loanID FROM loaning WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemID = 7;";
            MySqlCommand command = new MySqlCommand(mySqlStatement, connection);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantityLaptops = Convert.ToInt32(reader[0]);
                loanID = reader[1].ToString();
            }
            lbInformation.Items.Add(quantityLaptops);
            lbInformation.Items.Add(loanID);
            connection.Close();

            if (quantityLaptops > 1)
            {
                connection.Open();

                string mySqlStatement1 = "UPDATE `loaning` SET `quantityLoaned` = quantityLoaned - 1 , deposit = deposit - 150 WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemId = '7';";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityLaptops--;
                deposit7 -= 150;
                laptops--;
                

                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 7;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 150 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();

            }
            else if (quantityLaptops == 1)
            {
                connection.Open();

                string mySqlStatement1 = "DELETE FROM `loaning` WHERE `loaning`.`loanID` = " + loanID.ToString() + ";";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityLaptops--;
                deposit7 -= 150;
                laptops--;
                


                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 7;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 150 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();
            }

            lbInformation.Items.Clear();
            tbBraceletID2.Clear();
            
        }
        int quantityChargers;
        private void btnChargerReturn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();

            string mySqlStatement = "SELECT quantityLoaned,loanID FROM loaning WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemID = 6;";
            MySqlCommand command = new MySqlCommand(mySqlStatement, connection);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantityChargers = Convert.ToInt32(reader[0]);
                loanID = reader[1].ToString();
            }
            lbInformation.Items.Add(quantityChargers);
            lbInformation.Items.Add(loanID);
            connection.Close();

            if (quantityChargers > 1)
            {
                connection.Open();

                string mySqlStatement1 = "UPDATE `loaning` SET `quantityLoaned` = quantityLoaned - 1 , deposit = deposit - 4 WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemId = '6';";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityChargers--;
                deposit6 -= 4;
                chargers--;
                

                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 6;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 4 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();

            }
            else if (quantityChargers == 1)
            {
                connection.Open();

                string mySqlStatement1 = "DELETE FROM `loaning` WHERE `loaning`.`loanID` = " + loanID.ToString() + ";";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityChargers--;
                deposit6 -= 4;
                chargers--;
                


                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 6;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 4 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();
            }
            lbInformation.Items.Clear();
            tbBraceletID2.Clear();
        }


        int quantityUSBs;
        private void btnReturnUSB_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();

            string mySqlStatement = "SELECT quantityLoaned,loanID FROM loaning WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemID = 8;";
            MySqlCommand command = new MySqlCommand(mySqlStatement, connection);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantityUSBs = Convert.ToInt32(reader[0]);
                loanID = reader[1].ToString();
            }
            lbInformation.Items.Add(quantityUSBs);
            lbInformation.Items.Add(loanID);
            connection.Close();

            if (quantityUSBs > 1)
            {
                connection.Open();

                string mySqlStatement1 = "UPDATE `loaning` SET `quantityLoaned` = quantityLoaned - 1 , deposit = deposit - 2 WHERE `loaning`.userID = '" + userID.ToString() + "' AND itemId = '8';";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityUSBs--;
                deposit8 -= 2;
                USB--;
              

                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 8;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 2 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();

            }
            else if (quantityUSBs == 1)
            {
                connection.Open();

                string mySqlStatement1 = "DELETE FROM `loaning` WHERE `loaning`.`loanID` = " + loanID.ToString() + ";";
                MySqlCommand command1 = new MySqlCommand(mySqlStatement1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                quantityUSBs--;
                deposit8 -= 2;
                USB--;
              

                connection.Open();
                string mySqlStatement3 = "UPDATE `items` SET `inStock` = inStock + 1 WHERE `items`.`itemID` = 8;";
                MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
                command3.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string mySqlStatement2 = "UPDATE `visitor` SET `balance` = balance + 2 WHERE `visitor`.`userID` = '" + userID.ToString() + "';";
                MySqlCommand command2 = new MySqlCommand(mySqlStatement2, connection);
                command2.ExecuteNonQuery();
                connection.Close();
            }
            lbInformation.Items.Clear();
            tbBraceletID2.Clear();

        }

        // RFID thing

        RFID rfid;
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

                rfid.Open(5000);
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

            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                tbBraceletID2.Text = reg;

                GiveInfo(tbBraceletID2.Text);
            }
                
            
             
        }

        private void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            tbStatus.Text = "ready";
        }


        public void GiveInfo(string ID)
        {
            lbInformation.Items.Clear();
            laptops = 0;
            cameras = 0;
            USB = 0;
            chargers = 0;

            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
            string sqlStatement = "SELECT tick.userID FROM visitor vis Join ticket tick on (tick.userID = vis.userID)  Where tick.braceletID = '" + tbBraceletID2.Text.ToString() + "';";
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
                MessageBox.Show("Please enter valid information.");
               
            }

            string deposit = "0";
            List<int> items = new List<int>();
            connection.Open();
            string sqlStatement1 = "SELECT SUM(deposit) as `ASD` FROM `loaning` WHERE `userID` = '" + userID.ToString() + "' ;";
            MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, connection);
            MySqlDataReader reader1;
            try
            {
                reader1 = sqlCommand1.ExecuteReader();
                while (reader1.Read())
                {
                    deposit = reader1["ASD"].ToString();
                    if (deposit == "")
                    {
                        deposit = "0";
                    }
                }
                connection.Close();
            }

            catch
            {
                connection.Close();
                MessageBox.Show("Operation Failed 1:( .");
               
            }



            connection.Open();
            string mySqlStatement3 = "SELECT SUM(quantityLoaned) as `ASD` from loaning where userID = '" + userID.ToString() + "' AND itemID = 5;";
            MySqlCommand command3 = new MySqlCommand(mySqlStatement3, connection);
            MySqlDataReader reader3;
            try
            {
                reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    cameras = Convert.ToInt32(reader3["ASD"]);
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

            lbInformation.Items.Add("User with ID - " + userID + " deposited:");
            lbInformation.Items.Add(deposit + "$ for the following items:");
            lbInformation.Items.Add("Cameras: " + cameras.ToString());
            lbInformation.Items.Add("Phone Chargers: " + chargers.ToString());
            lbInformation.Items.Add("Laptops: " + laptops.ToString());
            lbInformation.Items.Add("USB Cabels: " + USB.ToString());
            button7.Visible = true;


        }

        
    }
}
