using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace WindowsFormsApp1
{
    class DBConnect
    {
        string connectionString;
        public MySqlConnection connection;

        public DBConnect()
        {
            connectionString = "server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
               "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open) { MessageBox.Show("Connection is successful!"); }
                return true;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
            return false;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                if (connection.State == System.Data.ConnectionState.Closed) { MessageBox.Show("Connection is closed!"); }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool payBill(string braceletId, double total)
        {
            double newBalance;

            double[] temp = new double[1];

            string sqlBalance = "SELECT `balance` FROM `visitor` WHERE `visitor`.`userID` = (SELECT `userID` FROM `ticket` WHERE `ticket`.`braceletID` = '" 
                + braceletId + "');";

            MySqlCommand sqlCommand1 = new MySqlCommand(sqlBalance, connection);


            try
            {
                MySqlDataReader dbReader;

                connection.Open();

                dbReader = sqlCommand1.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = Convert.ToDouble(dbReader["balance"]);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            if (temp[0] > total)
            {
                newBalance = temp[0] - total;
            }
            else { return false; }

            try
            {
                string sqlStatement = "UPDATE `visitor` SET `balance` = '" + newBalance + "' WHERE `visitor`.`userID` = " +
                    "(SELECT `userID` FROM `ticket` WHERE `ticket`.`braceletID` = '" + braceletId + "');";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

                connection.Open();

                //assign connection to command
                sqlCommand.Connection = connection;

                //execute sql statement
                sqlCommand.ExecuteNonQuery();

                return true;
            
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public string sqlExceptionMessage(string originalExceptionMessage)
        {
            return (
                "For regular users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }   
    }
}  
