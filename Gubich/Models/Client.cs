using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models
{
    public class Client
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Phone { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return String.Format("{0}: {1}", Name, Organization);
        }
        public static List<Client> getClientList()
        {
            string sqlExpression = "SELECT * FROM Clients";
            List<Client> result = new List<Client>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Client client = new Client();
                        client.id = reader.GetInt32(0);
                        client.Name = reader.GetString(1);
                        client.Organization = reader.GetString(2);
                        client.Phone = reader.GetString(3);
                        client.Adres = reader.GetString(4);
                        result.Add(client);
                    }
                }
                reader.Close();
            }
            return result;
        }
        public static bool updateClient(Client client)
        {
            string sqlExpression = String.Format("UPDATE Clients SET Name = '{0}', Organization = '{1}', Phone = '{2}', Adres = '{3}' WHERE id ={4}", client.Name, client.Organization, client.Phone, client.Adres, client.id);
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
        public static bool insertNewClient(Client client)
        {
            string sqlExpression = String.Format("INSERT INTO Clients (Name, Organization, Phone, Adres) VALUES ('{0}', '{1}', '{2}', '{3}')", client.Name, client.Organization, client.Phone, client.Adres);
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
            catch(Exception e)
            {
                return false;
            }
            
        }
        public static Client getClient(int id)
        {
            string sqlExpression = "SELECT * FROM Clients WHERE id =" + id;
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
