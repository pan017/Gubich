using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich
{
   public class SQLService
    {
        public static bool ExecuteSQLQuery(string sqlExpression)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
