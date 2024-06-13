using DBLayer;
using SRMS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMS.Reposatory
{
    public class ReceptRepository
    {
        public static List<Recept> GetAllRecepti()
        {
            List<Recept> recepti = new List<Recept>();
            string sql = "SELECT * FROM Recepti";
            try
            {
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Recept recept = CreateObject(reader);
                    recepti.Add(recept);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                throw new Exception($"Error retrieving data: {ex.Message}", ex);
            }
            finally
            {
                DB.CloseConnection();
            }
            return recepti;

        }

        public static void InsertRecept(Recept recept)
        {
            string sql = $"INSERT INTO Recepti (Jelo, Sastojak) VALUES ('{recept.Jelo}', '{recept.Sastojak}')";
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting data: {ex.Message}", ex);
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public static void DeleteRecept(int idMeni1)
        {
            string sql = $"DELETE FROM Recepti WHERE IdMeni1 = {idMeni1}";
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting data: {ex.Message}", ex);
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        private static Recept CreateObject(SqlDataReader reader)
        {
                int idMeni1 = int.Parse(reader["IdMeni1"].ToString());
                string jelo = reader["Jelo"].ToString();
                string sastojak = reader["Sastojak"].ToString();
                var recept = new Recept
                {
                IdMeni1 = idMeni1,
                Jelo = jelo,
                Sastojak = sastojak
                };
                return recept;
        }
    }
}
