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
    public class NalogRepos
    {
        public static Nalog GetNalog(int id)
        {
            Nalog nalog = null;
            string sql = $"SELECT * FROM NalogDB Where Id = {id}";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                nalog = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return nalog;

        }
        public static List<Nalog> GetNaloge()
        {
            var nalozi = new List<Nalog>();
            string sql = "SELECT * FROM NaloziDB";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Nalog student = CreateObject(reader);
                nalozi.Add(student);
            }

            reader.Close();
            DB.CloseConnection();

            return nalozi;

        }

        private static Nalog CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string fazaPretrage = reader["Faza_pretrage"].ToString();
            string komentari = reader["Komentari"].ToString();
            int sifraPacijenta = int.Parse(reader["Sifra_pacijenta"].ToString());
            string nazivPretrage = reader["Uzorak"].ToString();
            int idZaposlenika = int.Parse(reader["Zaposlenik_id"].ToString());
            int idRezultata = int.Parse(reader["Rezultati_id"].ToString());

            var nalog = new Nalog
            {
                Id = id,
                Faza_pretrage = fazaPretrage,
                Komentari = komentari,
                Sifra_pacijenta = sifraPacijenta,
                Uzorak= nazivPretrage,
                Id_rezultata = idRezultata,
                Id_zaposlenika = idZaposlenika
            };

            return nalog;
        }

    }
}
