using DBLayer;
using MicroBioManager.Classes;
using MicroBioManager.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroBioManager
{
    public partial class FrmAnalizaUrina : Form
    {
        private Nalog nalog;
        public Nalog oznaceniNalog { get => nalog; set => nalog = value; }
        public FrmAnalizaUrina(Nalog oznaceniNalog)
        {
            InitializeComponent();
            nalog = oznaceniNalog;
        }
        public FrmAnalizaUrina()
        {
            InitializeComponent();
            nalog = oznaceniNalog;
        }

        private void FrmAnalizaUrina_Load(object sender, EventArgs e)
        {
            var rezultati = RezultatiRepos.GetRezultati(oznaceniNalog.Id_rezultata);
            Pacijent.Text = oznaceniNalog.Sifra_pacijenta.ToString();
            SifraNaloga.Text = oznaceniNalog.Id.ToString();
            Glukoza.Text = rezultati.Glukoza;
            Bilirubin.Text = rezultati.Bilirubin;
            Ketoni.Text = rezultati.Ketoni;
            Nitriti.Text = rezultati.Nitriti;
            Eritrociti.Text=rezultati.Eritrociti;
            Leukociti.Text = rezultati.Leukociti;
            Cilindri.Text=rezultati.Cilindri;
            Bakterije.Text=rezultati.Bakterije;
            EptilneCelije.Text = rezultati.Eptilne_celije;
            UratiAmorfni.Text = rezultati.Urati_amorfni;
            Sluz.Text=rezultati.Sluz;
            Gljivice.Text = rezultati.Gljivice;
            Urea.Text = rezultati.Urea;
            Kristali_KO.Text =rezultati.Kristali_kalcij_oksalata;

        }

        private void SaveUr_Click(object sender, EventArgs e)
        {
            var sifra_pacijent = Pacijent.Text;
            var sifra_nalog = SifraNaloga.Text;
            var glukoza = Glukoza.Text;
            var bilirubin = Bilirubin.Text;
            var ketoni = Ketoni.Text;
            var nitriti = Nitriti.Text;
            var eritrociti = Eritrociti.Text;
            var leukociti = Leukociti.Text;
            var cilindri = Cilindri.Text;
            var bakterije = Bakterije.Text;
            var eptilne_celije = EptilneCelije.Text;
            var urati_amorfni = UratiAmorfni.Text;
            var sluz = Sluz.Text;
            var gljivice = Gljivice.Text;
            var urea = Urea.Text;
            var kristali_ko = Kristali_KO.Text;

            if (eritrociti != "")
            {
                string sql1 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Eritrociti ={eritrociti}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent }";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql1);
                DB.CloseConnection();
            }
            if (leukociti != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Leukociti={leukociti}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (glukoza != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Glukoza ={glukoza}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (bilirubin != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Bilirubin = {bilirubin}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (ketoni != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Ketoni={ketoni}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (nitriti != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Nitriti = {nitriti}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (cilindri != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Cilindri = {cilindri}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (bakterije != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Bakterije = {bakterije}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (eptilne_celije != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Eptilne_celije={eptilne_celije}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (urati_amorfni != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Urati_amorfni ={urati_amorfni}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (sluz != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Sluz = {sluz}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (gljivice != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Gljivice ={gljivice}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (urea != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Urea={urea}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }
            if (kristali_ko != "")
            {
                string sql2 = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Kristali_kalcij_oksalata={kristali_ko}" +
                    $"WHERE Sifra_pacijenta = { sifra_pacijent } ";
                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql2);
                DB.CloseConnection();
            }

            /*
            string sql = $"Update RezultatiDB SET Sifra_pacijenta = {sifra_pacijent}, Uzorak ='{"Urin"}', Eritrociti={eritrociti}, " +
                $"Leukociti={leukociti}, Glukoza ={glukoza}, Bilirubin = {bilirubin}, Ketoni={ketoni}, Nitriti = {nitriti}," +
                $"Cilindri = {cilindri}, Bakterije = {bakterije}, Eptilne_celije={eptilne_celije}, Urati_amorfni ={urati_amorfni}, Sluz = {sluz}," +
                $"Gljivice ={gljivice}, Urea={urea}, Kristali_kalcij_oksalata={kristali_ko} WHERE Sifra_pacijenta = { sifra_pacijent } ";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL"); 
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            */
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
