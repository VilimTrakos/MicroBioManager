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
        public static Nalog GetNalog(Pacijent pacijent, Rezultati rezultati)
        {
            Nalog nalog = null;
            string sql = $"SELECT * FROM NalogDB WHERE sifra_pacijenta = {pacijent.Sifra} AND Rezultati_id = {rezultati.Id}";
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
        public static List<Nalog> GetNaloge(Pacijent pacijent)
        {
            var nalozi = new List<Nalog>();
            string sql = $"SELECT * FROM NaloziDB WHERE Sifra_pacijenta = {pacijent.Sifra}";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Nalog nalog = CreateObject(reader);
                nalozi.Add(nalog);
            }

            reader.Close();
            DB.CloseConnection();

            return nalozi;

        }

        public static List<Nalog> GetNaloge()
        {
            var nalozi = new List<Nalog>();
            string sql = $"SELECT * FROM NaloziDB";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Nalog nalog = CreateObject(reader);
                nalozi.Add(nalog);
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
           // var sPacijenta = PacijentRepos.GetpacijentS(sifraPacijenta);

            string nazivPretrage = reader["Uzorak"].ToString();
            int idZaposlenika = int.Parse(reader["Zaposlenik_id"].ToString());
           // var zaposlenik = ZaposlenikRepos.GetZaposlenik(idZaposlenika);
            int idRezultata = int.Parse(reader["Rezultati_id"].ToString());
            //var rezultati = RezultatiRepos.GetRezultati(idRezultata);
           

            var nalog = new Nalog
            {
               Id = id,
               Faza_pretrage = fazaPretrage,
               Komentari = komentari,
               Sifra_pacijenta = sifraPacijenta,
               Uzorak = nazivPretrage,
               Id_zaposlenika = idZaposlenika,
               Id_rezultata = idRezultata

            };

            return nalog;
        }

    }
}
