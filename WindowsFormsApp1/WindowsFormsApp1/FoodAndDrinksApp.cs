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

namespace WindowsFormsApp1
{
    public partial class FoodAndDrinksApp : Form
    {

        private double total;
        DBConnect myConnection;
        ProductInventory myInventory;

        public double Total
        {
            get { return total; }
            set { if (value < 0) { total = 0; }
                else { total = value; }
            }
        }

        public void assignNameToButton()
        {
            int index = 0;

            foreach (Button b in tabPageFood.Controls)
            {
                if (index <= myInventory.GetAllFood().Count)
                {
                    b.Tag = myInventory.GetAllFood()[index];
                    b.Text = myInventory.getFoodName()[index];
                }
                index++;
            }

            int index1 = 0;

            foreach (Button b in tabPageDrinks.Controls)
            {
                if (index1 <= myInventory.GetAllDrinks().Count)
                {
                    b.Tag = myInventory.GetAllDrinks()[index1];
                    b.Text = myInventory.getDrinkName()[index1];
                }
                index1++;
            }
        }

        public FoodAndDrinksApp()
        {
            InitializeComponent();
            myConnection = new DBConnect();
            myInventory = new ProductInventory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection.OpenConnection();
            this.assignNameToButton();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbBill.Items.Clear();
        }

        private void btnBavaria_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var form = new PayPopUp();

            form.tbTotalFinal.Text = this.Total.ToString();

            
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            foreach (Object o in lbBill.Items)
            {
                Order order = o as Order;
                myInventory.RemoveItemFromBill(order);
            }

            Total = 0;
            lbBill.Items.Clear();
            lblTotal.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Order o = lbBill.SelectedItem as Order;

            Total -= o.totalPrice;

            myInventory.RemoveItemFromBill(o);
            lbBill.Items.Remove(lbBill.SelectedItem);
            lblTotal.Text = this.Total.ToString() + "€";
        }

        private void lbBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;

        }
        private void btnBavaria_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void btnJupiler_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            int numberItems = Convert.ToInt32(numericUpDown1.Value);

            Product p = myInventory.GetProduct(s);

            Order o = new Order(p, numberItems, numberItems * p.Price);

            myInventory.UpdateInStock(o);

            lbBill.Items.Add(o);

            Total += o.totalPrice;

            lblTotal.Text = this.Total.ToString() + "€";

            numericUpDown1.Value = 1;
        }
    }
}
