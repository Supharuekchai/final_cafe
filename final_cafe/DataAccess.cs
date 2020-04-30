using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace final_cafe
{
    class DataAccess
    {
        string ConnectionString;

        public DataAccess()
        {
            ConnectionString = "server = localhost; user id = root; password = 1234567890; persistsecurityinfo=True; database = final_cafe; allowuservariables=True";
        }

        public bool AddNewCategoryToDatabase(string CategoryName, string CategoryDescription, PictureBox CategoryPictureBox)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                MySqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                /*THIS IS THE MAIN CODE FOR HASHING*/

                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                CategoryPictureBox.Image.Save(ms, CategoryPictureBox.Image.RawFormat);

                /*Array of Binary numbers that have been converted*/
                byte[] CategoryPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                /*HASHING END HERE*/

                /*now we will save this array into our database*/

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);
                    command.Parameters.AddWithValue("@CategoryDescription", CategoryDescription);
                    command.Parameters.AddWithValue("@CategoryPicture", CategoryPicture);

                    command.CommandText =
                       "Insert into categories (CategoryName, CategoryDescription, CategoryPicture) values (@CategoryName, @CategoryDescription, @CategoryPicture)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public ArrayList RetreiveAllCategoriesFromDatabase()
        {
            ArrayList CategoriesList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT CategoryID, CategoryName, CategoryPicture FROM categories;", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int CategoryID = reader.GetInt32(0);
                        string CategoryName = reader.GetString(1);
                        byte[] CategoryPicture = (byte[])reader[2];

                        CategoriesList.Add(new Details() { ID = CategoryID, Name = CategoryName, Picture = CategoryPicture });
                    }
                }
                reader.Close();

                return CategoriesList;
            }
        }

        public bool AddNewProductToDatabase(string ProductName, decimal ProductPrice, int ProductCategoryID, string ProductDescription, byte[] ProductPicture)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                MySqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                    command.Parameters.AddWithValue("@ProductDescription", ProductDescription);
                    command.Parameters.AddWithValue("@ProductImage", ProductPicture);

                    command.CommandText =
                       "Insert into products (ProductName, ProductPrice, ProductCategoryID, ProductDescription, ProductImage) values (@ProductName, @ProductPrice, @ProductCategoryID, @ProductDescription, @ProductImage)";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public ArrayList RetreiveAllProducts()
        {
            ArrayList ProductsList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ProductID, ProductName, ProductPrice, ProductCategoryID, ProductDescription, ProductImage FROM products;", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ProductID = reader.GetInt32(0);
                        string ProductName = reader.GetString(1);
                        decimal ProductPrice = reader.GetDecimal(2);
                        int ProductCategoryID = reader.GetInt32(3);
                        string ProductDescription = reader.GetString(4);
                        byte[] ProductPicture = (byte[])reader[5];

                        ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Description = ProductDescription, Picture = ProductPicture, ID = ProductID });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }

        public ArrayList RetreiveAllSaleDetail(int SaleID)
        {
            ArrayList SaleDetail = new ArrayList();
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleDateTime, StaffID, GrandTotal FROM sales where SaleID = '" + SaleID + "';", connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime SaleTime = reader.GetDateTime(0);
                        int SalesmanID = reader.GetInt32(1);
                        string SalesmanName = ReturnUserName(SalesmanID);
                        decimal TotalBill = reader.GetDecimal(2);

                        SaleDetail.Add(new Details() { SaleID = SaleID, SaleTime = SaleTime, Name = SalesmanName, Total = TotalBill });
                    }
                }
                reader.Close();
                return SaleDetail;
            }
        }

        public ArrayList RetreiveProductsFromCategory(int CategoryID)
        {
            ArrayList ProductsList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ProductID, ProductName, ProductPrice, ProductDescription, ProductImage FROM products where ProductCategoryID = '" + CategoryID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ProductID = reader.GetInt32(0);
                        string ProductName = reader.GetString(1);
                        decimal ProductPrice = reader.GetDecimal(2);
                        string ProductDescription = reader.GetString(3);
                        byte[] ProductPicture = (byte[])reader[4];

                        ProductsList.Add(new Details() { ID = ProductID, Name = ProductName, Price = ProductPrice, Picture = ProductPicture, Description = ProductDescription });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }

        public ArrayList ReturnDateTime()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleDateTime FROM sales", connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                ArrayList DateTime = new ArrayList();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime dateTime = reader.GetDateTime(0);
                        DateTime.Add(new Details() { SaleTime = dateTime });
                    }
                }
                reader.Close();

                return DateTime;
            }

        }

        public int ReturnSaleID(DateTime dateTime)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleID FROM sales where SaleDateTime = @DateTime;", connection);
                connection.Open();
                command.Parameters.Add("@DateTime", MySqlDbType.DateTime).Value = dateTime;
                MySqlDataReader reader = command.ExecuteReader();
                int SaleID = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SaleID = reader.GetInt32(0);
                    }
                }
                reader.Close();
                return SaleID;
            }
        }

        public int ReturnCategoryID(string CategoryName)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT CategoryID FROM categories where CategoryName = '" + CategoryName + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                int CategoryID = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CategoryID = reader.GetInt32(0);
                    }
                }
                reader.Close();

                return CategoryID;
            }
        }

        public string ReturnCategoryName(int CategoryID)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT CategoryName FROM categories where CategoryID = '" + CategoryID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                string CategoryName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CategoryName = reader.GetString(0);
                    }
                }
                reader.Close();

                return CategoryName;
            }
        }

        public Details RetreiveProductDetails(int ProductID)
        {
            Details ProductDetails = new Details();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ProductName, ProductPrice, ProductCategoryID, ProductDescription, ProductImage FROM products where ProductID = '" + ProductID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductDetails.Name = reader.GetString(0);
                        ProductDetails.Price = reader.GetDecimal(1);
                        int ProductCategoryID = reader.GetInt32(2);
                        ProductDetails.Category = ReturnCategoryName(ProductCategoryID);
                        ProductDetails.Description = reader.GetString(3);
                        ProductDetails.Picture = (byte[])reader[4];
                    }
                }
                reader.Close();

                return ProductDetails;
            }
        }

        public bool RecordASale(ArrayList ProductsList, DateTime SaleTime, int StaffID, decimal TotalBill, int CustomerID)
        {
            int SaleID = ReturnSaleID();


            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                MySqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@SaleTime", SaleTime);
                    command.Parameters.AddWithValue("@StaffID", StaffID);
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@TotalBill", TotalBill);

                    command.CommandText =
                       "Insert into sales (SaleDateTime, StaffID, GrandTotal, CustomerID) values (@SaleTime, @StaffID, @TotalBill, @CustomerID)";
                    command.ExecuteNonQuery();

                    foreach (Details ProductDetail in ProductsList)
                    {
                        int ProductID = ReturnProductID(ProductDetail.Name);
                        //// Execute separate commands.
                        //command.Parameters.AddWithValue("@ProductName", ProductDetail.Name);
                        //command.Parameters.AddWithValue("@ProductPrice", ProductDetail.Price);
                        //command.Parameters.AddWithValue("@ProductQuantity", ProductDetail.Quantity);
                        //command.Parameters.AddWithValue("@ProductTotal", ProductDetail.Total);
                        //command.Parameters.AddWithValue("@SaleID", SaleID);

                        command.CommandText =
                           "Insert into sale_details (ProductID, ProductPrice, ProductQuantity, ProductTotal, SaleID) values ('" + ProductID + "', '" + ProductDetail.Price + "', '" + ProductDetail.Quantity + "', '" + ProductDetail.Total + "', '" + SaleID + "')";
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public int ReturnProductID(string ProductName)
        {
            int ProductID = 0;
            try
            {

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT ProductID FROM products WHERE ProductName = '" + ProductName + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ProductID = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                    return ProductID;
                }
            }
            catch (Exception)
            {
                return ProductID;
            }
        }
        public int ReturnCustomerID(string username)
        {
            int CustomerID = 0;
            try
            {

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT CustomerID FROM customers WHERE UserName = '"+ username +"';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CustomerID = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                    return CustomerID;
                }
            }
            catch (Exception)
            {
                return CustomerID;
            }

        }

        public string ReturnCustomerName(string username)
        {
            string CustomerName = string.Empty;
            try
            {

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT CustomerName FROM customers WHERE UserName = '" + username + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CustomerName = reader.GetString(0);
                        }
                    }
                    reader.Close();
                    return CustomerName;
                }
            }
            catch (Exception)
            {
                return CustomerName;
            }
        }
        public string ReturnCustomerNameFromID(string CustomerID)
        {
            string CustomerName = string.Empty;
            try
            {

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT CustomerName FROM customers WHERE CustomerID = '" + CustomerID + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CustomerName = reader.GetString(0);
                        }
                    }
                    reader.Close();
                    return CustomerName;
                }
            }
            catch (Exception)
            {
                return CustomerName;
            }
        }

        public string UpdatePoint(int CustomerID, ArrayList ProductsList, string PointD)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                int Point = Convert.ToInt32(PointD);
                connection.Open();
                /*Start a local transaction*/
                MySqlTransaction sqlTran = connection.BeginTransaction();
                /*Enlist a command in the current transaction*/
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;
                int PointAdd = 0;
                foreach (Details ProductDetail in ProductsList)
                {
                    PointAdd = ProductDetail.Quantity;
                }
                PointAdd *= 2;
                Point = Point + PointAdd;
                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@Point", Point);
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.CommandText =
                       "Update customers set Point = @Point where CustomerID = @CustomerID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return PointD;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return PointD;
                }
            }
        }
        public int ReturnSaleID()
        {
            int SaleID = 0;
            try
            {

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT SaleID FROM sales;", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SaleID = reader.GetInt32(0);
                        }
                        SaleID++;
                    }
                    reader.Close();
                    return SaleID;
                }
            }
            catch (Exception)
            {
                return SaleID;
            }
        }

        public bool DeleteProduct(int ProductID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("Delete from products where ProductID = '" + ProductID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateProduct(int ProductID, string ProductName, decimal ProductPrice, int ProductCategoryID, string ProductDescription, byte[] ProductPicture)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                MySqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute separate commands.
                    command.Parameters.AddWithValue("@ProductID", ProductID);
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                    command.Parameters.AddWithValue("@ProductDescription", ProductDescription);
                    command.Parameters.AddWithValue("@ProductImage", ProductPicture);

                    command.CommandText =
                       "Update products set ProductName = @ProductName, ProductPrice = @ProductPrice, ProductCategoryID = @ProductCategoryID, ProductDescription = @ProductDescription, ProductImage=@ProductImage where ProductID = @ProductID";
                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ee)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public ArrayList RetreiveAllSales()
        {
            ArrayList SalesList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleID, SaleDateTime, StaffID, CustomerID, GrandTotal FROM sales;", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int SaleID = reader.GetInt32(0);
                        DateTime SaleTime = reader.GetDateTime(1);
                        int SalesmanID = reader.GetInt32(2);
                        string SalesmanName = ReturnUserName(SalesmanID);
                        string CustomerID = reader.GetString(3);
                        string CustomerName = ReturnCustomerNameFromID(CustomerID);
                        decimal TotalBill = reader.GetDecimal(4);


                        SalesList.Add(new Details() { SaleID = SaleID, SaleTime = SaleTime, Name = SalesmanName, CostomerName = CustomerName, Total = TotalBill});
                    }
                }
                reader.Close();

                return SalesList;
            }
        }

        public string ReturnUserName(int StaffID)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT StaffName FROM staffs where StaffID = '" + StaffID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                string UserName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserName = reader.GetString(0);
                    }
                }
                reader.Close();

                return UserName;
            }
        }

        public string ReturnProductName(string ProductID)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ProductName FROM products where ProductID = '" + ProductID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                string ProductName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductName = reader.GetString(0);
                    }
                }
                reader.Close();

                return ProductName;
            }
        }

        public int ReturnUserID(string StaffCode)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT StaffID FROM staffs where StaffID = '" + StaffCode + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                int StaffID = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StaffID = reader.GetInt32(0);
                    }
                }
                reader.Close();

                return StaffID;
            }
        }

        public bool ConfirmUser(string StaffCode, string StaffPassword)
        {
            string PasswordFromDatabase = string.Empty;

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT StaffPassword FROM staffs where StaffCode = '" + StaffCode + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PasswordFromDatabase = reader.GetString(0);
                    }
                }
                reader.Close();
            }

            if (StaffPassword == PasswordFromDatabase)
            {
                return true;
            }
            else return false;
        }

        public bool RegisterUser(string UserName, string UserEmail, string UserPassword)
        {
            UserPassword = SimpleHash.ComputeHash(UserPassword);

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("Insert into Users (Name, Role, Email, Password) values ('" + UserName + "', 'Salesman', '" + UserEmail + "', '" + UserPassword + "');", connection);
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return true;
                }
                else return false;
            }
        }

        public int ReturnStaffIDRandom()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT StaffID FROM sales", connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int num = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        num = reader.GetInt32(0);
                    }
                }
                reader.Close();
                Random random = new Random();
                return random.Next(1, num);
            }
        }
        public ArrayList RetreiveSaleItems(int SaleID)
        {
            ArrayList ProductsList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT ProductID, ProductPrice, ProductQuantity, ProductTotal FROM sale_details where SaleID = '" + SaleID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string ProductID = reader.GetString(0);
                        decimal ProductPrice = reader.GetDecimal(1);
                        int ProductQuantity = reader.GetInt32(2);
                        decimal ProductTotal = reader.GetDecimal(3);

                        string ProductName = this.ReturnProductName(ProductID);

                        ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Quantity = ProductQuantity, Total = ProductTotal });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }
    }
}
