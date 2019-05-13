using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace TransactionsApp
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        private void ShowBrowse()
        {
            btnBrowse.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
        private void ShowButtons()
        {
            btnBrowse.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();
            ShowBrowse();
            
        }

        private void lbFilepath_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            users.Clear();
            FileDialog openFileDialog1 = new OpenFileDialog();
            FileStream fs = null;
            StreamReader sr = null;
            string filePath = null;
            string counterString = null;
            //OpenFileDialog Settings
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //If ok was clicked
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShowButtons();
                try
                {
                    filePath = openFileDialog1.FileName;
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    string bankAcc = sr.ReadLine();
                    string startDate = sr.ReadLine();
                    string endDate = sr.ReadLine();
                    string amountDeposits = sr.ReadLine();

                    lbBankAccount.Text = bankAcc;
                    lbStartDate.Text = startDate;
                    lbEndDate.Text = endDate;
                    lbNumberDeposits.Text = amountDeposits;
                    lbFilepath.Text = filePath;

                    while ((counterString = sr.ReadLine()) != null)
                    {
                        string s = counterString;
                        string[] sArray = new string[2];
                        sArray = s.Split(' ');
                        string userID = sArray[0];
                        string userBalance = sArray[1];
                        users.Add(new User(Convert.ToInt32(userID), Convert.ToDouble(userBalance)));
                    }

                    foreach (User item in users)
                    {
                        listboxDeposits.Items.Add(item.ToString());
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null) sr.Close();
                }
            }
            else
            {
                MessageBox.Show("You didn't select a file to open.");
                ShowBrowse();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowse_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionInfo = "server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
               "password=Fan.win-45;" + "connect timeout=30;";
            MySqlConnection connection = new MySqlConnection(connectionInfo);

            try
            {
                connection.Open();

                string sql = "SELECT * FROM visitor WHERE userID = @userId;";
                int nrOfRecords = 0;
                foreach (var item in users)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@userId", item.UserId);
                    nrOfRecords = Convert.ToInt32(cmd.ExecuteScalar());
                    if (nrOfRecords == 0)
                    {
                        ShowBrowse();
                        MessageBox.Show("User " + item.UserId + " does not exist in the database. The accounts were NOT updated!");
                        break;
                    }
                }
                if (nrOfRecords != 0)
                {

                    string sql0 = "SELECT balance FROM visitor WHERE userID = @userId;";
                    string sqlUpdate = "UPDATE `visitor` SET `balance` = @balance WHERE `visitor`.`userID` = @userId;";
                    int nrOfRecordsChanged = 0;

                    foreach (var item in users)
                    {                     
                        MySqlCommand command = new MySqlCommand(sql0, connection);
                        command.Parameters.AddWithValue("@userId", item.UserId);
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        double n = Convert.ToDouble(reader[0]);
                        connection.Close();
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(sqlUpdate, connection);
                        cmd.Parameters.AddWithValue("@balance", item.Balance + n);
                        cmd.Parameters.AddWithValue("@userId", item.UserId);
                        nrOfRecordsChanged = cmd.ExecuteNonQuery();
                    }
                    ShowBrowse();
                    ClearInfo();
                    MessageBox.Show("Records updated.");
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("A problem occurred.");
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearInfo()
        {
            listboxDeposits.Items.Clear();
            users.Clear();
            lbBankAccount.Text = "---";
            lbStartDate.Text = "---";
            lbEndDate.Text = "---";
            lbNumberDeposits.Text = "---";
            lbFilepath.Text = "Select Transaction log";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInfo();
            btnBrowse.Visible = true;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionInfo = "server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
   "password=Fan.win-45;" + "connect timeout=30;";
            MySqlConnection connection = new MySqlConnection(connectionInfo);

            try
            {
                connection.Open();

                string sql = "SELECT * FROM visitor WHERE userID = @userId;";
                int nrOfRecords = 0;
                foreach (var item in users)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@userId", item.UserId);
                    nrOfRecords = Convert.ToInt32(cmd.ExecuteScalar());
                    if (nrOfRecords == 0)
                    {
                        ShowBrowse();
                        MessageBox.Show("User " + item.UserId + " does not exist in the database. The accounts were NOT updated!");
                        break;
                    }
                }
                if (nrOfRecords != 0)
                {

                    string sql0 = "SELECT balance FROM visitor WHERE userID = @userId;";
                    string sqlUpdate = "UPDATE `visitor` SET `balance` = @balance WHERE `visitor`.`userID` = @userId;";
                    int nrOfRecordsChanged = 0;

                    foreach (var item in users)
                    {
                        MySqlCommand command = new MySqlCommand(sql0, connection);
                        command.Parameters.AddWithValue("@userId", item.UserId);
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        double n = Convert.ToDouble(reader[0]);
                        connection.Close();
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(sqlUpdate, connection);

                        cmd.Parameters.AddWithValue("@balance", n - item.Balance);
                        cmd.Parameters.AddWithValue("@userId", item.UserId);
                        nrOfRecordsChanged = cmd.ExecuteNonQuery();

                    }
                    ShowBrowse();
                    ClearInfo();
                    MessageBox.Show("Records updated.");
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("A problem occurred.");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "Browse - Select a transaction log.\n\nCancel - Clear the selected transaction log\n\nUpdate - " +
                "Add the records from the selected transaction log to the user accounts.\n\nUndo Update - " +
                "If you have updated the incorrect transaction log by accident, undo the changes.";
            MessageBox.Show(s);
        }
    }
}
