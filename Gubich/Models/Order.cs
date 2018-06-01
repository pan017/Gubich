using Gubich.Models.Account;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Count { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int ManagerId { get; set; }
        public virtual Manager Manager { get; set; }


        public static List<Order> getOrdersList()
        {
            string sqlExpression = "SELECT * FROM Orders";
            List<Order> result = new List<Order>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.id = reader.GetInt32(0);
                        order.Count = reader.GetInt32(1);
                        order.OrderDate = reader.GetDateTime(2);
                        order.ClientId = reader.GetInt32(3);
                        order.ProductId = reader.GetInt32(4);
                        order.ManagerId = reader.GetInt32(5);

                        order.Manager = Manager.getManagersList().FirstOrDefault(x => x.id == order.ManagerId);
                        order.Product = Product.getProduct(order.ProductId);
                        order.Client = Client.getClient(order.ClientId);
                        result.Add(order);
                    }
                }
                reader.Close();
            }
            return result;
        }
        public static bool updateOrder(Order order)
        {
            string sqlExpression = String.Format("UPDATE Orders SET Count = {0}, OrderDate = '{1}', ClientId = {2}, ProductId = {3} WHERE id ={4}",
                order.Count, order.OrderDate, order.ClientId, order.ProductId, order.id);
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
        static string GetUpdateStorageQuery(Order order)
        {
            Storage storageItem = Storage.getStorageList().FirstOrDefault(x => x.ProductId == order.ProductId);
            int newCount = storageItem.Count;
            newCount -= order.Count;
            return String.Format("UPDATE Storage SET [Count] = {0} WHERE id ={1}", newCount, storageItem.id);
        }
        public static bool insertNewOrder(Order order)
        {
            
            string sqlExpression = String.Format("INSERT INTO Orders (Count, OrderDate, ClientId, ProductId, ManagerId) VALUES ({0}, '{1}', {2}, {3}, {4})", 
                order.Count, order.OrderDate, order.ClientId, order.ProductId, order.ManagerId);
            SQLService.ExecuteSQLQuery(sqlExpression);
            return SQLService.ExecuteSQLQuery(GetUpdateStorageQuery(order));
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            //    {
            //        connection.Open();
            //        SqlCommand command = new SqlCommand(sqlExpression, connection);
            //        int number = command.ExecuteNonQuery();

            //    }
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}

        }
        public static Client getClient(int id)
        {
            string sqlExpression = "SELECT * FROM Orders WHERE id =" + id;
            Client result = new Client();
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
                        result.Name = reader.GetString(1);
                        result.Organization = reader.GetString(2);
                        result.Phone = reader.GetString(3);
                        result.Adres = reader.GetString(4);
                    }
                }
                reader.Close();
            }

            return result;
        }
    }
}

