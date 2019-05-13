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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class PayPopUp : Form
    {
        DBConnect myConnection;
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
        }

        private void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            tbStatus.Text = "ready";
        }

        public PayPopUp()
        {
            InitializeComponent();
            myConnection = new DBConnect();
        }

        private void PayPopUp_Load(object sender, EventArgs e)
        {
            myConnection.OpenConnection();
            StartUp();
        }

        private void PayPopUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            FoodAndDrinksApp form = new FoodAndDrinksApp();

            myConnection.CloseConnection();

        }

        private void btnPayFinal_Click(object sender, EventArgs e)
        {
            var f = new FoodAndDrinksApp();
            double total = Convert.ToDouble(tbTotalFinal.Text);

            if (myConnection.payBill(tbBraceletId.Text, total) == true)
            {

                MessageBox.Show("Payment successful!");

                try
                {
                    Close();
                }
                catch (InvalidOperationException) { }
            }
            else
            {
                MessageBox.Show("Payment is not successful! Insufficient balance!");
            }
        }
    }
}
