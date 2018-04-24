using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace cst323
{
    public class cstDAO
    {
        string connectionString = "Data Source=tcp:leeminesweeper.database.windows.net,1433;Initial Catalog=Users;User ID=natelee;Password=legoman27!";

        public bool CreateRow(string json)
        {
            bool select = false;
            try
            {
                // Setup SELECT query with parameters
                string query = "INSERT INTO dbo.WIFI (JSON) VALUES (@Json)";

                // Create connection and command
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Set query parameters and their values
                    cmd.Parameters.Add("@Json", SqlDbType.VarChar, 5000).Value = json;

                    // Open the connection
                    cn.Open();

                    // Using a DataReader see if query returns any rows
                    int rows = cmd.ExecuteNonQuery();
                    if (rows==1)
                        select = true;
                    else
                        select = false;

                    // Close the connection
                    cn.Close();
                }
            }
            //catch exception
            catch (SqlException e)
            {
                throw e;
            }
            return select;
        }

        public List<string> GetSpeeds()
        {
            List<string> result = new List<string>();
            try
            {
                // Setup SELECT query with parameters
                string query = "SELECT * FROM dbo.WIFI";

                // Create connection and command
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {

                    // Open the connection
                    cn.Open();

                    // Using a DataReader see if query returns any rows
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<string> speeds = new List<string>();
                    while(reader.HasRows)
                    {
                        reader.Read();
                        speeds.Add(reader.GetString(2));
                    }
                    result = speeds;
                    

                    // Close the connection
                    cn.Close();
                }
            }
            //catch exception
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
    }
}