using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Mail;
using CryptSharp;

namespace TicketScanApp
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

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public void sentEmail(string email, string origPass)
        {
            try
            {
                SmtpClient client = new SmtpClient("localhost", 25);
                MailMessage msg = new MailMessage("symphonyofdestruction2018@gmail.com", email);

                NetworkCredential cred = new NetworkCredential("symphonyofdestruction2018@gmail.com", "!Lovemetal45");

                client.Credentials = cred;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;

                msg.Subject = "account password";
                msg.Body = "Hello, thank you for purchasing a ticket!" +
                    "\nThis is your password you can use it to log into our website: " + origPass
                    + "\nHave fun!";

                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public bool findUser(IList repository, string ticketID)
        {
            string sqlStatement = "SELECT * FROM `visitor` WHERE userID = (SELECT userID FROM ticket WHERE ticketID = " + ticketID + ")";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

            string[] temp = new string[5];

            try
            {
                MySqlDataReader dbReader;

                connection.Open();
                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = "TicketID: " + ticketID;
                    temp[1] = "UserID: " + dbReader["userID"].ToString();
                    temp[2] = "First Name: " + dbReader["firstName"].ToString();
                    temp[3] = "Last Name:" + dbReader["lastName"].ToString();
                    temp[4] = "Email: " + dbReader["email"].ToString();
                }

                for (int n = 0; n <= 4; n++)
                {
                    repository.Add(temp[n]);
                }
                return true;

            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }

            catch (ArgumentNullException)
            {
                MessageBox.Show("This ticketID does not exist!");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool assignBracelet(string braceletId, string ticketId)
        {
            string sqlStatement = "UPDATE `ticket` SET `braceletID` = '" + braceletId + "' WHERE `ticket`.`ticketID` = " + ticketId + ";";
            //MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
          

            try
            {
                connection.Open();

                //create mysql command
                MySqlCommand cmd = new MySqlCommand();

                //Assign the query using CommandText
                cmd.CommandText = sqlStatement;

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

        public bool buyTicket(string fName, string lName, string email, string day)
        {
            string origPass = this.CreatePassword(8);

            string cryptedPassword = Crypter.Blowfish.Crypt(origPass, new CrypterOptions()
            { { CrypterOption.Variant, BlowfishCrypterVariant.Corrected }, { CrypterOption.Rounds, 10 } });

            string sqlStatementCrVisitor = "INSERT INTO `visitor`(`userID`, `password`, `firstName`, `lastName`, `email`, `balance`) " +
                "VALUES (NULL,'" + cryptedPassword + "','" + fName +"','" + lName + "','" + email + "', 0)";

            try
            {
                connection.Open();

                //create mysql command
                MySqlCommand cmd = new MySqlCommand();

                //Assign the query using CommandText
                cmd.CommandText = sqlStatementCrVisitor;

                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                //this.CloseConnection();
            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }
            finally { connection.Close(); }

            try
            {
                string sqlStatement = "INSERT INTO `ticket` (`ticketID`, `braceletID`, `days`, `userID`) " +
                    "SELECT NULL, NULL,'" + day + "', userID FROM  `visitor` WHERE `visitor`.`email` = '" + email + "';";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

                connection.Open();

                //assign connection to command
                sqlCommand.Connection = connection;

                //execute sql statement
                sqlCommand.ExecuteNonQuery();

                this.sentEmail(email, origPass);

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

        public string findTicket(string email)
        {
            string sqlStatement = "SELECT ticketID FROM `ticket` WHERE userID = (SELECT userID FROM `visitor` WHERE `visitor`.`email` = '" + email + "')";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);

            string ticket;

            try
            {
                string[] temp = new string[1];
                MySqlDataReader dbReader;

                connection.Open();
                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp[0] = dbReader["ticketID"].ToString();
                }

                ticket = temp[0];

                return ticket;

            }
            catch (MySqlException e) { MessageBox.Show(sqlExceptionMessage(e.Message)); }

            catch (ArgumentNullException)
            {
                MessageBox.Show("This ticketID does not exist!");
            }
            finally
            {
                connection.Close();
            }
            return "";
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
