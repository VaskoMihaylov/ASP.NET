using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using TestingWebApp.AppCode;

namespace TestingWebApp
{
    public static class ConnectionClass
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        static ConnectionClass()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["coffeeConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command= new SqlCommand("",conn);
        }

        public static ArrayList GetCoffeeByType(string coffeeType)
        {
            ArrayList list = new ArrayList();
            string query = string.Format("SELECT * FROM coffee WHERE type LIKE '{0}'", coffeeType);

            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string type = reader.GetString(2);
                    double price = reader.GetDouble(3);
                    string roast = reader.GetString(4);
                    string country = reader.GetString(5);
                    string image = reader.GetString(6);
                    string review = reader.GetString(7);

                    Coffee coffee =new Coffee(id, name, type, price, roast, country, image,review);
                    list.Add(coffee);
                }
            }
            finally 
            {
                  conn.Close();  
                
            }
            return list;
        }
    }


}