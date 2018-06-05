using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubich.Models
{
    public class Unit
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Unit> getUnitsList()
        {
            string sqlExpression = "SELECT * FROM Units";
            List<Unit> result = new List<Unit>();
            using (SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["connectionString"]))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Unit unit = new Unit();
                        unit.id = reader.GetInt32(0);
                        unit.Name = reader.GetString(1);
                        unit.Description = reader.GetString(2);
                        result.Add(unit);
                    }
                }
                reader.Close();
            }
            return result;
        }
        public override string ToString()
        {
            return this.Name;
        }
        public static Unit getUnit (int id)
        {
            string sqlExpression = "SELECT * FROM Units WHERE id =" + id;
            Unit result = new Unit();
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
        public static bool updateUnit(Unit unit)
        {
            return SQLService.ExecuteSQLQuery(String.Format("UPDATE Units SET Name = '{0}', Description = '{2}'  WHERE id ={1}", unit.Name, unit.id, unit.Description));          
        }
        public static bool insertNewUnit(Unit unit)
        {
            return SQLService.ExecuteSQLQuery(String.Format("INSERT INTO Units (Name, Description) VALUES ('{0}', '{1}')", unit.Name, unit.Description));         
        }
    }
}
