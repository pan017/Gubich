using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models.Account
{
    public class Manager
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public DateTime BrithDay { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public static List<Manager> getManagersList()
        {
            string sqlExpression = "SELECT * FROM Managers";
            List<Manager> result = new List<Manager>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Manager manager = new Manager();
                        manager.id = reader.GetInt32(0);
                        manager.FullName = reader.GetString(1);
                        manager.BrithDay = reader.GetDateTime(2);
                        manager.AccountId = reader.GetInt32(3);
                        if (manager.AccountId != null)
                            manager.Account = Account.getAccount(manager.AccountId);
                        result.Add(manager);
                    }
                }
                reader.Close();
            }
            return result;
        }
        public static bool updateManager(Manager manager)
        {
            SQLService.ExecuteSQLQuery(String.Format("UPDATE [Managers] SET [FullName] = '{0}', [BrithDay] = '{1}', WHERE id ={2}",
                manager.FullName, manager.BrithDay.ToShortDateString(), manager.id));
            return SQLService.ExecuteSQLQuery(String.Format("UPDATE [Account] SET [Login] = '{0}', [Password] = '{1}', [Email] = '{2}', RoleId = {3} WHERE id ={4}",
                manager.Account.Login, manager.Account.Password, manager.Account.email, manager.Account.RoleId, manager.AccountId));
         
        }
        public static bool insertNewManager(Manager manager)
        {
            string sqlExpression = "InsertNewManager";

            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FullName", manager.FullName);
                command.Parameters.AddWithValue("@BrithDay", manager.BrithDay.ToShortDateString());
                command.Parameters.AddWithValue("@Login", manager.Account.Login);
                command.Parameters.AddWithValue("@Password", manager.Account.Password);
                command.Parameters.AddWithValue("@Email", manager.Account.email);
                command.Parameters.AddWithValue("@RoleId", manager.Account.RoleId);

                var result = command.ExecuteScalar();

                return true; // SQLService.ExecuteSQLQuery(sqlExpression);

            }
        }
    }
}
