using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WiFiMonitor.Models;

namespace WiFiMonitor.Services
{
    public class ServerDAO
    {
        string connectionString = "Data Source=tcp:leeminesweeper.database.windows.net,1433;Initial Catalog=Users;User ID=natelee;Password=legoman27!";

        public List<WiFiModel> GetSpeeds()
        {
            List<WiFiModel> result = new List<WiFiModel>();
            try
            {
                // Setup SELECT query with parameters
                string query = "SELECT TOP(10) JSON FROM dbo.WIFI ORDER BY ID DESC";

                // Create connection and command
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {

                    // Open the connection
                    cn.Open();

                    // Using a DataReader see if query returns any rows
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<WiFiModel>(reader.GetString(0)));
                    }


                    // Close the connection
                    cn.Close();
                }
            }
            //catch exception
            catch (Exception e)
            {
                WiFiModel test = new WiFiModel();
                test.timestamp = e.Message;
                test.upload = 0;
                test.download = 0;
                test.ping = 0;
                result.Add(test);            
            }
            return result;
        }
    }
}