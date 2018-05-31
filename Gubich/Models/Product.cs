using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }
        public string Characteristic { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }

        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} руб.", Name, Cost);
        }
        public static bool updateProduct(Product product)
        {
            string sqlExpression =
                String.Format(
                    "UPDATE Product SET Name = '{0}', Cost = {1}, Desciption = '{2}', Characteristic = '{3}', UnitId = {4}, ProductTypeId = {5} " +
                    " WHERE id = {6} ", product.Name, product.Cost, product.Description, product.Characteristic, product.UnitId, product.ProductTypeId, product.id);
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
        public static bool insertNewProduct(Product product)
        {
            string sqlExpression = 
                String.Format(
                    "INSERT INTO Product (Name, Cost, Desciption, Characteristic, UnitId, ProductTypeId)" +
                    " VALUES ('{0}', {1}, '{2}', '{3}', {4}, {5})",
                    product.Name, product.Cost, product.Description, product.Characteristic, product.UnitId, product.ProductTypeId);
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
        public static List<Product> getProductsList()
        {
            string sqlExpression = "SELECT * FROM Product";
            List<Product> result = new List<Product>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.id = reader.GetInt32(0);
                        product.Name = reader.GetString(1);
                        product.Cost = reader.GetFloat(2);
                        product.Description = reader.GetString(3);
                        product.Characteristic = reader.GetString(4);
                        product.UnitId = reader.GetInt32(5);
                        product.ProductTypeId = reader.GetInt32(6);
                        if (product.UnitId != null)
                            product.Unit = Unit.getUnit(product.UnitId);
                        if (product.ProductTypeId != null)
                            product.ProductType = ProductType.getProductType(product.ProductTypeId);
                        result.Add(product);
                    }
                }
                reader.Close();
            }
            
            return result;
        }

        public static Product getProduct(int id)
        {
            string sqlExpression = "SELECT * FROM Product WHERE id =" + id;
            Product result = new Product();
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
                        result.Cost = reader.GetFloat(2);
                        result.Description = reader.GetString(3);
                        result.Characteristic = reader.GetString(4);
                        result.UnitId = reader.GetInt32(5);
                        result.ProductTypeId = reader.GetInt32(6);
                    }
                }
                reader.Close();
            }
            if (result.UnitId != null)
                result.Unit = Unit.getUnit(result.UnitId);
            if (result.ProductTypeId != null)
                result.ProductType = ProductType.getProductType(result.ProductTypeId);
            return result;
        }
        void GetUnit()
        {
            if (UnitId != null)
                Unit = Unit.getUnit(UnitId);
        }

        void GetProductType()
        {
            if (ProductTypeId != null)
                ProductType = ProductType.getProductType(ProductTypeId);
        }
        public void GetForigenKeys()
        {
            GetUnit();
            GetProductType();
        }
    }
}
