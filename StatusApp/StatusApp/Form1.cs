using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusApp
{
    public partial class Form1 : Form
    {
        DBConnect myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection = new DBConnect();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMostBought.Text = myConnection.MostBoughtItem();
            lblTicketsBought.Text = myConnection.TicketsBought().ToString();
            lblVisitorsInside.Text = myConnection.VisitorsInside().ToString();
            tbItem.Text = "";
            lblSpecificItem.Text = "#####";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbItem.Text;
                int quantity = myConnection.QuantitySpecificItem(name);

                lblSpecificItem.Text = quantity.ToString();
            }
            catch (FormatException ex)
            { MessageBox.Show(ex.Message); }
            catch (ArgumentException ex)
            { MessageBox.Show(ex.Message); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection.OpenConnection();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.CloseConnection();
        }
    }
}
