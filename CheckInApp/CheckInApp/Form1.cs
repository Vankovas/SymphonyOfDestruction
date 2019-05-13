using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

    namespace CheckInApp
    {
      public partial class Form1 : Form
      {

        DBConnect myConnection;
        RFID rfid;

        public Form1()
        {
            InitializeComponent();
            myConnection = new DBConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartUp();
            myConnection.OpenConnection();
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

            if (myConnection.CheckIn(tbBraceletId.Text) == true)
            {
                MessageBox.Show("User is admitted to enter!");
            }
            else { MessageBox.Show("BraceletID not real! Please proceed to the ticket counter to change your bracelet!"); }
        }

        private void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            tbStatus.Text = "ready";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.CloseConnection();
            rfid.Close();
        }
    }

    }


