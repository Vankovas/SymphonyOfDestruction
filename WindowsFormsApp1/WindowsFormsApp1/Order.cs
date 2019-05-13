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
    class Order
    {
        public int Quantity { get; set; }
        
        public Product p;
        public double totalPrice { get; set; }

        public Order(Product p, int quantity, double total)
        {
            this.p = p;
            this.Quantity = quantity;
            this.totalPrice = total;
        }

        public override string ToString()
        {
            return "(" + Quantity + "x) " + p.Name + ", price: " + this.totalPrice + "€";
        }

    }
}
