using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace CheckInApp
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

        public bool CheckIn(string braceletId)
        {
            string sqlStatement1 = "UPDATE `visitor` SET `inside` = 1 WHERE `visitor`.`userID` = (SELECT userID FROM ticket WHERE braceletID = '" + braceletId + "')";

            try
            {

                connection.Open();

                //create mysql command
                MySqlCommand cmd = new MySqlCommand();

                //Assign the query using CommandText
                cmd.CommandText = sqlStatement1;

                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                //this.CloseConnection();

                return true;

            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }
            finally { connection.Close(); }
            return false;
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
