using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Restrurent_Application_WPF.Model;

namespace Restrurent_Application_WPF.DB_Layer
{
    public class DataAccessLayer
    {
        public static String ConnectionString;
        SqlConnection conn;
        public int InsertNewFoodItem(FoodItems newfoodItem)
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "Insert into FoodItems (FoodName,Description,Price) values (@FoodName,@Description,@Price) select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FoodName", newfoodItem.FoodName);
            cmd.Parameters.AddWithValue("@Description", newfoodItem.Description);
            cmd.Parameters.AddWithValue("@Price", newfoodItem.Price);
            //cmd.ExecuteScalar();
            
            int foodid = Convert.ToInt32(cmd.ExecuteScalar());

            return foodid;
        }
    }
}
