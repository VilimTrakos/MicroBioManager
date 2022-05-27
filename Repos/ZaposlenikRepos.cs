using MicroBioManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;

namespace MicroBioManager.Repos
{
    public class ZaposlenikRepos
    {
        public static Zaposlenik GetZaposlenik(int id)
        {
            Zaposlenik zaposlenik = null;
            string sql = $"SELECT * FROM Zaposlenici WHERE Id= {id}";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string uloga = reader["Uloga"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                Uloga = uloga
            };
            return zaposlenik;
        }

        public static Zaposlenik GetZaposlenik(string username)
        {
            string sql = $" SELECT * FROM Zaposlenici WHERE Username ='{username}'";
            Zaposlenik zaposlenik = null;
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }
    }
}
