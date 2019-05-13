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
    class ProductInventory
    {
        DBConnect myConnection;
        Product p;
        //Order o;

        public ProductInventory()
        {
            myConnection = new DBConnect();
        }

        public List<object> GetAllFood()
        {
            List<object> temp = new List<object>();

            string sqlStatement = "SELECT name, price, inStock FROM `food_drinks` WHERE type = 'FOOD'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, myConnection.GetConnection());

            try
            {
                MySqlDataReader dbReader;

                myConnection.GetConnection().Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp.Add(p = new Product(dbReader["name"].ToString(), Convert.ToInt32(dbReader["price"]), Convert.ToInt32(dbReader["inStock"])));
                }
            }
            catch (MySqlException e) { MessageBox.Show(myConnection.sqlExceptionMessage(e.Message)); }
            finally
            {
                myConnection.GetConnection().Close();
            }
            return temp;
        }

        public List<object> GetAllDrinks()
        {
            List<object> temp = new List<object>();

            string sqlStatement = "SELECT name, price, inStock FROM `food_drinks` WHERE type = 'DRINK'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, myConnection.GetConnection());

            try
            {
                MySqlDataReader dbReader;

                myConnection.GetConnection().Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp.Add(p = new Product(dbReader["name"].ToString(), Convert.ToInt32(dbReader["price"]), Convert.ToInt32(dbReader["inStock"])));
                }
            }
            catch (MySqlException e) { MessageBox.Show(myConnection.sqlExceptionMessage(e.Message)); }
            finally
            {
                myConnection.GetConnection().Close();
            }
            return temp;
        }

        public List<object> GetAllProducts()
        {
            List<object> temp = new List<object>();

            string sqlStatement = "SELECT name, price, inStock FROM `food_drinks`";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, myConnection.GetConnection());

            try
            {
                MySqlDataReader dbReader;

                myConnection.GetConnection().Open();

                dbReader = sqlCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    temp.Add(p = new Product(dbReader["name"].ToString(), Convert.ToInt32(dbReader["price"]), Convert.ToInt32(dbReader["inStock"])));
                }
            }
            catch (MySqlException e) { MessageBox.Show(myConnection.sqlExceptionMessage(e.Message)); }
            finally
            {
                myConnection.GetConnection().Close();
            }
            return temp;
        }

        public void UpdateInStock(Order o)
        {
            int newQuantity;

            if (o.p.InStock > o.Quantity)
                newQuantity = p.InStock - o.Quantity;
            else { newQuantity = p.InStock;
                MessageBox.Show("You have run out of this product!");
            }

            try
            {

                string sqlStatement1 = "UPDATE `food_drinks` SET `inStock` = " + newQuantity + ", `quantitySold` = `quantitySold` + " 
                    + o.Quantity + " WHERE name = '" + o.p.Name + "'";

                MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, myConnection.connection);

                myConnection.GetConnection().Open();
                
                //execute sql statement
                sqlCommand1.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(myConnection.sqlExceptionMessage(e.Message));
            }
            finally
            {
                myConnection.GetConnection().Close();
            }
        }

        public void RemoveItemFromBill(Order o)
        {

            try
            {

                string sqlStatement1 = "UPDATE `food_drinks` SET `inStock` = `inStock` + " + o.Quantity + ", `quantitySold` = `quantitySold` - "
                    + o.Quantity + " WHERE name = '" + o.p.Name + "'";

                MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, myConnection.connection);

                myConnection.GetConnection().Open();

                //execute sql statement
                sqlCommand1.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(myConnection.sqlExceptionMessage(e.Message));
            }
            finally
            {
                myConnection.GetConnection().Close();
            }
        }

        public List<string> getFoodName()
        {
            List<string> temp = new List<string>();

            foreach (Product p in this.GetAllFood())
            {
                temp.Add(p.Name);
            }

            return temp;
        }

        public List<string> getDrinkName()
        {
            List<string> temp = new List<string>();

            foreach (Product p in this.GetAllDrinks())
            {
                temp.Add(p.Name);
            }

            return temp;
        }

        public Product GetProduct(string name)
        {
            foreach (Product p in this.GetAllProducts())
            {
                if (p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
