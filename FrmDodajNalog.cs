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
    public partial class FrmDodajNalog : Form
    {
        public FrmDodajNalog()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnAddRezultate_Click_1(object sender, EventArgs e)
        {
            var sifra_pacijenta = txtSifraPacijenta.Text;
            var uzorak = cboUzorak.Text;
            



            string sql = $"INSERT INTO RezultatiDB (Sifra_pacijenta, Uzorak) VALUES ({sifra_pacijenta}, '{uzorak}')";


            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            ShowRezultate();
        }

        private void FrmDodajNalog_Load(object sender, EventArgs e)
        {
            ShowRezultate();
        }
        private void ShowRezultate()
        {
            var rezultati = RezultatiRepos.GetRezultate();
            dgvPrikazRezultata.DataSource = rezultati;
            dgvPrikazRezultata.Columns["Id"].DisplayIndex = 0;
        }

        private void btnDodajNalog_Click(object sender, EventArgs e)
        {
            try
            {
                var sifra_pacijenta = txtSifraNalog.Text;
                var uzorak = cboUzorakNalog.Text;
                var ZaposlenikUpisi = FrmLogin.LoggedZaposlenik;
                var Faza = "Pocetak";
                var rezultatiId = txtIdRezultata.Text;

                string sql = $"INSERT INTO NaloziDB (Faza_pretrage, Sifra_pacijenta, Uzorak, Zaposlenik_id, Rezultati_id) VALUES ('{Faza}', {sifra_pacijenta}," +
                    $" '{uzorak}', {ZaposlenikUpisi}, {rezultatiId})";


                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                FrmPocetna osvjezi = new FrmPocetna();
                osvjezi.ShowNaloge();
            }
            catch (Exception)
            {
                MessageBox.Show("Nalog s odabranim rezultatima vec postoji!");
            }
        }

        private void btnPocetak_Click(object sender, EventArgs e)
        {
            FrmPocetna frmPocetna=new FrmPocetna();
            Hide();
            frmPocetna.ShowDialog();
            Close();

        }

       
    }
    
}
