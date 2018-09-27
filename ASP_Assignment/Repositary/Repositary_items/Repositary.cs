using Repositary_file.Products_items;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Repositary_file.Repositary_items
{
    public class BrandItems
    {
        public int BrandId;
        public String BrandName;
    }


//To get the data from the database
    public class Repositary
    {

        public List<Product> GetData()
        {
            List<Product> ProductList = new List<Product>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=ACUPC-111;Initial Catalog=Users;Integrated Security=True";
                connection.Open();

                string sql = "Select * From Products";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        ProductList.Add(new Product
                        {
                            Id = Convert.ToInt32(myDataReader["Id"].ToString()),
                            Name = myDataReader["Name"].ToString(),
                            Price = Convert.ToInt32(myDataReader["Price"].ToString()),
                            URL = myDataReader["URL"].ToString(),
                            Description = myDataReader["Description"].ToString(),
                            Bid = Convert.ToInt32(myDataReader["BID"].ToString())
                        });
                    }
                }
                connection.Close();
                return ProductList;
            }
        }
 //Search the item 
        public String[] SearchItem(String item)
        {
            String[] str = new string[100];
            int count = 0;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=ACUPC-111;Initial Catalog=Users;Integrated Security=True";
                connection.Open();

                String query = "select Name from products where Name like'%" + item + "%'";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader myDataReader = command.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        str[count++] = myDataReader["Name"].ToString();
                    }
                }
            }
            return str;
        }
 //Insert new item on the data base
        public String InsertNewProduct( String UName, int Brandid, int Price, String Dec)
        {
            String Str;
            String URL = "Please Provide URL Here";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=ACUPC-111;Initial Catalog=Users;Integrated Security=True";
                connection.Open();

                String query = "InsertProduct";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                
                SqlParameter parameter2 = command.Parameters.AddWithValue("@Uname", SqlDbType.VarChar); parameter2.Value = UName;
                SqlParameter parameter3 = command.Parameters.AddWithValue("@Uprice", SqlDbType.Int); parameter3.Value = Price;
                SqlParameter parameter4 = command.Parameters.AddWithValue("@URL", SqlDbType.VarChar); parameter4.Value = URL;
                SqlParameter parameter5 = command.Parameters.AddWithValue("@UDec", SqlDbType.VarChar); parameter5.Value = Dec;
                SqlParameter parameter6 = command.Parameters.AddWithValue("@bid", SqlDbType.Int); parameter6.Value = Brandid;

                int returnValue = command.ExecuteNonQuery();
                if (returnValue == 0)
                    Str = "Your Operation is Performed Unsuccessfully";
                else
                    Str = "Your operaction is Peformed........Successfully";
            }
            return Str;
        }
 //Update the existing product
        public String UpdateProduct(int Pid, String UName, int Brandid, int Price, String Dec)
        {
            String Str;
            String URL = "Please Provide URL Here";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=ACUPC-111;Initial Catalog=Users;Integrated Security=True";
                connection.Open();

                String query = "UpdateTheRecord";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter1  = command.Parameters.AddWithValue("@id", SqlDbType.Int); parameter1.Value = Pid;
                SqlParameter parameter2 = command.Parameters.AddWithValue("@Uname", SqlDbType.VarChar); parameter2.Value = UName;
                SqlParameter parameter3 = command.Parameters.AddWithValue("@Uprice", SqlDbType.Int); parameter3.Value = Price;
                SqlParameter parameter4 = command.Parameters.AddWithValue("@URL", SqlDbType.VarChar); parameter4.Value = URL;
                SqlParameter parameter5 = command.Parameters.AddWithValue("@UDec", SqlDbType.VarChar); parameter5.Value = Dec;
                SqlParameter parameter6 = command.Parameters.AddWithValue("@bid", SqlDbType.Int); parameter6.Value = Brandid;
                

                int returnValue = command.ExecuteNonQuery();
                if (returnValue == 0)
                    Str = "Your Operation is Performed Unsuccessfully";
                else
                    Str = "Your operaction is Peformed........Successfully";
            }
            return Str;
        }
        //delete the existing product from database 
        public String DeleteOperaction(int id)
        {
            String Str;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=ACUPC-111;Initial Catalog=Users;Integrated Security=True";
                connection.Open();

                String query = "DeleteOperaction";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = command.Parameters.AddWithValue("@id", SqlDbType.Int); p1.Value = id;
                int returnValue = command.ExecuteNonQuery();
                if (returnValue == 0)
                    Str = "Your Operation is Performed Unsuccessfully";
                else
                    Str = " Delete the product Successfully";
            }
            return Str;

        }



 //To get the Brand data from the Products table on the database
        public List<BrandItems> GetBrand()
        {
            List<BrandItems> BrandList = new List<BrandItems>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=ACUPC-111;Initial Catalog=Users;Integrated Security=True";
                connection.Open();

                string sql = "Select * From Brand";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        BrandList.Add(new BrandItems
                        {
                            BrandId = Convert.ToInt32(myDataReader["BrandId"].ToString()),
                            BrandName = myDataReader["BrandName"].ToString()
                        });
                    }
                }
                connection.Close();
                return BrandList;
            }
        }

    }
}
