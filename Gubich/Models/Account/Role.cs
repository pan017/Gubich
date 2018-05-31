using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models.Account
{
    public class Role
    {
        public int id { get; set; }
        public string RoleName { get; set; }

        public static Role getRole(int id)
        {
            string sqlExpression = "SELECT * FROM Roles WHERE id =" + id;
            Role result = new Role();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.id = reader.GetInt32(0);
                        result.RoleName = reader.GetString(1);
                    }
                }
                reader.Close();
            }
            return result;
        }
    }
}
