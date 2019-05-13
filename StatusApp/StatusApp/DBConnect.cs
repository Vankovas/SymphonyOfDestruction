using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace StatusApp
{
    class DBConnect
    {
        string connectionString;
        MySqlConnection connection;

        public DBConnect()
        {
            connectionString = "server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
               "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none";
            connection = new MySqlConnection(connectionString);
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

        public string MostBoughtItem()
        {
            string[] temp = new string[1];
            string item;
            string sqlStatement = "SELECT name FROM food_drinks WHERE quantitySold = (SELECT MAX(quantitySold) FROM food_drinks)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);


            try
            {

                MySqlDataReader dbReader;

                connection.Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = dbReader["name"].ToString();
                }

                item = temp[0];

                return item;
            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }
            finally { connection.Close(); }
            return "";
        }

        public int TicketsBought()
        {
            int[] temp = new int[1];
            int number;
            string sqlStatement = "SELECT COUNT(*) AS Tickets FROM ticket";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

            try
            {

                MySqlDataReader dbReader;

                connection.Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = Convert.ToInt32(dbReader["Tickets"]);
                }

                number = temp[0];

                return number;
            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }
            finally { connection.Close(); }
            return -1;

        }

        public int VisitorsInside()
        {
            int[] temp = new int[1];
            int number;
            string sqlStatement = "SELECT COUNT(*) AS Visitors FROM ticket WHERE inside = 1";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

            try
            {

                MySqlDataReader dbReader;

                connection.Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = Convert.ToInt32(dbReader["Visitors"]);
                }

                number = temp[0];

                return number;
            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }
            finally { connection.Close(); }
            return -1;
        }

        public int QuantitySpecificItem(string name)
        {
            int[] temp = new int[1];
            int number;
            string sqlStatement = "SELECT quantitySold FROM food_drinks WHERE name = '" + name + "'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

            try
            {

                MySqlDataReader dbReader;

                connection.Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = Convert.ToInt32(dbReader["quantitySold"]);
                }

                number = temp[0];

                return number;
            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }
            finally { connection.Close(); }
            return -1;
        }

        private string sqlExceptionMessage(string originalExceptionMessage)
        {
            return (
                "For regular users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }
    }
}
