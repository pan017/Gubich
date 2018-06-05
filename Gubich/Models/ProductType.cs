using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models
{
    public class ProductType
    {
        public int id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public static List<ProductType> getProductTypesList()
        {
            string sqlExpression = "SELECT * FROM ProductTypes";
            List<ProductType> result = new List<ProductType>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductType productType = new ProductType();
                        productType.id = reader.GetInt32(0);
                        productType.Name = reader.GetString(1);
                        result.Add(productType);
                    }
                }
                reader.Close();
            }
            return result;
        }

        public static ProductType getProductType(int id)
        {
            string sqlExpression = "SELECT * FROM ProductTypes WHERE id =" + id;
            ProductType result = new ProductType();
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
                    }
                }
                reader.Close();
            }
            return result;
        }

        public static bool updateProductType(ProductType productType)
        {
            return SQLService.ExecuteSQLQuery(String.Format("UPDATE ProductTypes SET Name = '{0}' WHERE id ={1}", productType.Name, productType.id));
        }
        public static bool insertNewProductType(ProductType productType)
        {
            return SQLService.ExecuteSQLQuery(String.Format("INSERT INTO ProductTypes (Name) VALUES ('{0}')", productType.Name));
        }
    }
}
