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
            string sql = $"SELECT * FROM NaloziDB WHERE Sifra_pacijenta = {rezultati.Sifra_pacijenta} AND Rezultati_id = {rezultati.Id}";
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
        public static Nalog GetNalog(int sifra, int rez_id)
        {
            Nalog nalog = null;
            string sql = $"SELECT * FROM NaloziDB WHERE sifra_pacijenta = {sifra} AND Rezultati_id = {rez_id}";
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

        public static void InsertRezultati(Pacijent pacijent, Rezultati rezultati)
        {
            

            int input = 0;
            if (rezultati.Uzorak == "Krv")
            {
                 input = 1;
            }
            else
            {
                 input = 2;
            }
            string sql = $""+
                $"INSERT INTO RezultatiDB (Sifra_pacijenta, Uzorak,  Eritrociti, Leukociti, MCV, MCH, MCHC, RDW, MPV, PDW, EOS, LYM, BASO, PLT, NEU, Bazofili, Monociti, Limfociti, Hemoglobin, Hematokrit, Neutroliti, Eozinofili) VALUES " +
                $"(" +
                $"{rezultati.Sifra_pacijenta}," +
                $"{input}," +
                $"{rezultati.Eritrociti}," +
                $"{rezultati.Leukociti}," +
                $"{rezultati.MCV}," +
                $"{rezultati.MCH}," +
                $"{rezultati.MCHC}," +
                $"{rezultati.RDW}," +
                $"{rezultati.MPV}," +
                $"{rezultati.PDW}," +
                $"{rezultati.EOS}," +
                $"{rezultati.LYM}," +
                $"{rezultati.BASO}," +
                $"{rezultati.PLT}," +
                $"{rezultati.NEU}," +
                $"{rezultati.Bazofili}," +
                $"{rezultati.Monociti}," +
                $"{rezultati.Limfociti}," +
                $"{rezultati.Hemoglobin}," +
                $"{rezultati.Hematokrit}," +
                $"{rezultati.Neutroliti}," +
                $"{rezultati.Eozinofili})";

            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void UpdateRezultati(Rezultati rezultati, Pacijent pacijent)
        {
            string sql = $"UPDATE RezultatiDB SET Glukoza, Bilirubin, Ketoni, " +
                $"Nitriti, Eritrociti, Leukociti, Cilindri, " +
                $"Bakterije, Eptilne_celije, Urati_amorfni" +
                $"Sluz, Gljivice, Urea, Kristali_kalcij_oksalata, " +
                $"MCV, MCH, MCHC, RDW, MPV, PDW, EOS, LYM, BASO, PLT, NEU, " +
                $"Bazofili, Monociti, Limfociti, Hemoglobin, Hematokrit, Neutroliti, Eozinofili) VALUES {rezultati.Glukoza}," +
                $"{rezultati.Bilirubin},{rezultati.Ketoni}," +
                $"{rezultati.Nitriti},{rezultati.Eritrociti},{rezultati.Leukociti},{rezultati.Cilindri},{rezultati.Bakterije}," +
                $"{rezultati.Eptilne_celije}, {rezultati.Urati_amorfni},{rezultati.Sluz},{rezultati.Gljivice},{rezultati.Urea}," +
                $"{rezultati.Kristali_kalcij_oksalata},{rezultati.MCV},{rezultati.MCH},{rezultati.MCHC},{rezultati.RDW}," +
                $"{rezultati.MPV},{rezultati.PDW},{rezultati.EOS},{rezultati.LYM},{rezultati.BASO},{rezultati.PLT},{rezultati.NEU}," +
                $"{rezultati.Bazofili},{rezultati.Monociti},{rezultati.Limfociti},{rezultati.Hemoglobin},{rezultati.Hematokrit}," +
                $"{rezultati.Neutroliti},{rezultati.Eozinofili} WHERE Sifra_pacijenta ={rezultati.Sifra_pacijenta} AND Id={rezultati.Id}";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
