using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models.Account
{
    public class Account
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public static List<Account> getAccountsList()
        {
            string sqlExpression = "SELECT * FROM Account";
            List<Account> result = new List<Account>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Account account = new Account();
                        account.id = reader.GetInt32(0);
                        account.Login = reader.GetString(1);
                        account.Password = reader.GetString(2);
                        account.email = reader.GetString(3);
                        account.RoleId = reader.GetInt32(4);
                        if (account.RoleId != null)
                            account.Role = Role.getRole(account.RoleId);
                        result.Add(account);
                    }
                }
                reader.Close();
            }
            
            return result;
        }

        public static Account getAccount(int id)
        {

            string sqlExpression = "SELECT * FROM Account WHERE id =" + id;
            Account result = new Account();
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
                        result.Login = reader.GetString(1);
                        result.Password = reader.GetString(2);
                        result.email = reader.GetString(3);
                        result.RoleId = reader.GetInt32(4);                    
                    }
                }
                reader.Close();
            }
            if (result.RoleId != null)
                result.Role = Role.getRole(result.RoleId);
            return result;
        }
    }
}
