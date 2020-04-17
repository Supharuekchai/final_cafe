using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_cafe.GUI
{
    class Products
    {
        public String productID;
        public String productname;
        public String price;
        public String productdetail;

        public string conn = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True";

        public Products(String CustomerID)
        {
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT ProductID , ProductName, Price, ProductDetail FROM products";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@product", CustomerID);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.productID = rdr["ProductID"].ToString();
                    this.productname = rdr["ProductName"].ToString();
                    this.price = rdr["Price"].ToString();
                    this.productdetail = rdr["ProductDetail"].ToString();

                    string ProductID = this.productID;
                    string ProductName = this.productname;
                    string Price = this.price;
                    string ProductDetail = this.productdetail;

                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public ArrayList RetreiveAllCategoriesFromDatabase()
        {
            ArrayList CategoriesList = new ArrayList();
            MySqlConnection connection = new MySqlConnection(conn);
            MySqlCommand command = new MySqlCommand("SELECT ProductID , ProductName, Price, ProductDetail FROM products;", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ProductID = reader.GetInt32(0);
                        string ProductName = reader.GetString(1);
                        decimal Price = reader.GetDecimal(2);
                        byte[] CategoryPicture = (byte[])reader[3];

                    CategoriesList.Add(new Details() { ID = ProductID, Name = ProductName, Price = Price, Picture = CategoryPicture});
                    }
                }
                reader.Close();

                return CategoriesList;
            
        }
    }
}
