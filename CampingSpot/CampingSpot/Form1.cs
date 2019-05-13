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
using Phidget22;
using Phidget22.Events;
using System.Media;
namespace CampingSpot
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                  "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();
         
            string sql = "Select braceletID FROM ticket tick join visitor vis ON(tick.userID = vis.userID) join camping_res camp ON(vis.userID = camp.userID) WHERE tick.userID = camp.userID;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            MySqlDataReader reader = command.ExecuteReader();
            string braceletId =tbBraceletId.Text;
           
            List<string> braceletIds = new List<string>();

            while (reader.Read())
            {
                
                int i = 0;
              
               
                    braceletIds.Add(reader[i].ToString());
                    i++;
                
            }
            bool yes = false;
            foreach (string item in braceletIds)
            {
                
                if(braceletId == item)
                {
                    yes = true;
                    
                    connection.Close();
                    break;
                    
                }
               
            }
            if(yes == true)
            {
                connection.Open();
                listBox1.Items.Clear();               
                string sql1 = "Select campingID FROM camping_res camp join visitor vis on (camp.userID = vis.userID) join ticket tick on( tick.userID = vis.userID) WHERE tick.braceletID = '" + tbBraceletId.Text.ToString() + "' ;";
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while(reader1.Read())
                {
                    listBox1.Items.Add("Welcome! Your Camping Spot is " + reader1[0] + " !!!");
                    SoundPlayer play1 = new SoundPlayer("E:\\uni stuff\\PrOP\\okay.wav");
                    play1.Play();
                }
                

            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("This ticket has no camping spot included.");
                SoundPlayer play = new SoundPlayer("E:\\uni stuff\\PrOP\\bad.wav");
                play.Play();
            }
            connection.Close();
        }
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
 
            GiveInfo();

        }

        private void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            tbStatus.Text = "ready";
        }

        public void GiveInfo()
        {
            MySqlConnection connection;
            connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi388520;" + "user id=dbi388520;" +
                  "password=Fan.win-45;" + "connect timeout=30;" + "SslMode=none");
            connection.Open();

            string sql = "Select braceletID FROM ticket tick join visitor vis ON(tick.userID = vis.userID) join camping_res camp ON(vis.userID = camp.userID) WHERE tick.userID = camp.userID;";
            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader reader = command.ExecuteReader();
            string braceletId = tbBraceletId.Text;

            List<string> braceletIds = new List<string>();

            while (reader.Read())
            {

                int i = 0;


                braceletIds.Add(reader[i].ToString());
                i++;

            }
            bool yes = false;
            foreach (string item in braceletIds)
            {

                if (braceletId == item)
                {
                    yes = true;

                    connection.Close();
                    break;

                }

            }
            if (yes == true)
            {
                connection.Open();
                listBox1.Items.Clear();
                string sql1 = "Select campingID FROM camping_res camp join visitor vis on (camp.userID = vis.userID) join ticket tick on( tick.userID = vis.userID) WHERE tick.braceletID = '" + tbBraceletId.Text.ToString() + "' ;";
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    listBox1.Items.Add("Welcome!" +
                        " Your Camping Spot is " + reader1[0] + " !!!");
                    SoundPlayer play1 = new SoundPlayer("E:\\uni stuff\\PrOP\\okay.wav");
                    play1.Play();
                }

            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("This ticket has no camping spot included.");
                SoundPlayer play = new SoundPlayer("E:\\uni stuff\\PrOP\\bad.wav");
                play.Play();
            }
            connection.Close();
        }
    }
}
