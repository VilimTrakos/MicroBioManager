using DBLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MicroBioManager.Classes;

namespace MicroBioManager.Repos
{
    public class RezultatiRepos
    {
        public static Rezultati GetRezultati(int id)
        {
            Rezultati rezultati = null;
            string sql = $"SELECT * FROM RezultatiDB WHERE Id ={id}";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                reader.Read();
                rezultati = CreateObject(reader);
                reader.Close();
            }

            reader.Close();
            DB.CloseConnection();

            return rezultati;
        }
        public static List<Rezultati> GetRezultate()
        {
            List<Rezultati> rezultate = new List<Rezultati>();
            string sql = "SELECT * FROM RezultatiDB";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Rezultati rezultati = CreateObject(reader);
                rezultate.Add(rezultati);
            }
            reader.Close();
            DB.CloseConnection ();
            return rezultate;


        }


        private static Rezultati CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string uzorak = reader["Uzorak"].ToString();
            int sifra_pacijenta = int.Parse(reader["Sifra_pacijenta"].ToString());
            string glukoza = reader["Glukoza"].ToString();
            string bilirubin = reader["Bilirubin"].ToString();
            string ketoni = reader["Ketoni"].ToString();
            string nitriti = reader["Nitriti"].ToString();
            string eritrociti = reader["Eritrociti"].ToString();
            string leukociti = reader["Leukociti"].ToString();
            string cilindri = reader["Cilindri"].ToString();
            string bakterije = reader["Bakterije"].ToString();
            string eptilne_celije = reader["Eptilne_celije"].ToString();
            string urati_amorfni = reader["Urati_amorfni"].ToString();
            string sluz = reader["Sluz"].ToString();
            string gljivice = reader["Gljivice"].ToString();
            string urea = reader["Urea"].ToString();
            string kristali_kalcij_oksalata = reader["Kristali_kalcij_oksalata"].ToString();
            string mCV = reader["MCV"].ToString();
            string mCH = reader["MCH"].ToString();
            string mCHC = reader["MCHC"].ToString();
            string rDW = reader["RDW"].ToString();
            string mPV = reader["MPV"].ToString();
            string pDW = reader["PDW"].ToString();
            string eOS = reader["EOS"].ToString();
            string lYM = reader["LYM"].ToString();
            string bASO = reader["BASO"].ToString();
            string pLT = reader["PLT"].ToString();
            string nEU = reader["NEU"].ToString();
            string bazofili = reader["Bazofili"].ToString();
            string monociti = reader["Monociti"].ToString();
            string limfociti = reader["Limfociti"].ToString();
            string hemoglobin = reader["Hemoglobin"].ToString();
            string hematokrit = reader["Hematokrit"].ToString();
            string neutroliti = reader["Neutroliti"].ToString();
            string eozinofili = reader["Eozinofili"].ToString();

            var rezultati = new Rezultati
            {
                Id = id,
                Uzorak = uzorak,
                Sifra_pacijenta = sifra_pacijenta,
                Glukoza = glukoza,
                Bilirubin = bilirubin,
                Ketoni = ketoni,
                Nitriti = nitriti,
                Eritrociti = eritrociti,
                Leukociti = leukociti,
                Cilindri = cilindri,
                Bakterije = bakterije,
                Eptilne_celije = eptilne_celije,
                Urati_amorfni = urati_amorfni,
                Sluz = sluz,
                Gljivice = gljivice,
                Urea = urea,
                Kristali_kalcij_oksalata = kristali_kalcij_oksalata,
                MCV = mCV,
                MCH = mCH,
                MCHC = mCHC,
                RDW = rDW,
                MPV = mPV,
                PDW = pDW,
                EOS = eOS,
                LYM = lYM,
                BASO = bASO,
                PLT = pLT,
                NEU = nEU,
                Bazofili = bazofili,
                Monociti = monociti,
                Limfociti = limfociti,
                Hemoglobin = hemoglobin,
                Hematokrit = hematokrit,
                Neutroliti = neutroliti,
                Eozinofili = eozinofili
            };
            return rezultati;
        }
    }
}
