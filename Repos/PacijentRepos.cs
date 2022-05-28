using DBLayer;
using MicroBioManager.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBioManager.Repos
{
    public class PacijentRepos
    {
        public static Pacijent GetPacijent(int id)
        {
            Pacijent pacijent = null;
            string sql = $"SELECT * FROM Pacijenti_DB WHERE Id= {id}";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                pacijent = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return pacijent;
        }

        private static Pacijent CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();
            int sifra = int.Parse(reader["Sifra_pacijenta"].ToString());
      

            var pacijent = new Pacijent
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Sifra = sifra
            };
            return pacijent;
        }

        public static Pacijent GetpacijentS(int sifra)
        {
            string sql = $" SELECT * FROM Pacijenti_DB WHERE Sifra_pacijenta = '{sifra}'";
            Pacijent pacijent = null;
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                pacijent = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return pacijent;
        }
    }
}

