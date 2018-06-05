using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models
{
    class Storage
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Count { get; set; }

        public static List<Storage> getStorageList()
        {
            string sqlExpression = "SELECT * FROM Storage";
            List<Storage> result = new List<Storage>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Storage storage = new Storage();
                        storage.id = reader.GetInt32(0);
                        storage.ProductId = reader.GetInt32(1);
                        storage.Count = reader.GetInt32(2);  
                        storage.Product = Product.getProduct(storage.ProductId);
                        result.Add(storage);
                    }
                }
                reader.Close();
            }
            return result;
        }
        public static bool updateStorageItem(Storage storageItem)
        {

            return SQLService.ExecuteSQLQuery(String.Format("UPDATE Storage SET ProductId = {0}, [Count] = {1} WHERE id ={2}", 
                storageItem.ProductId, storageItem.Count, storageItem.id));          
        }
        public static bool insertNewStorageItem(Storage storageItem)
        {
            return SQLService.ExecuteSQLQuery(String.Format("INSERT INTO Storage (ProductId, Count) VALUES ({0}, {1})",
                storageItem.ProductId, storageItem.Count));
        }
    }
}