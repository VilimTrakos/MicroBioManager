using MicroBioManager.Classes;
using MicroBioManager.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroBioManager
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            ShowNaloge();
        }

        public void ShowNaloge()
        {
            var nalozi = NalogRepos.GetNaloge();
            dgvPopisNaloga.DataSource = nalozi;
            dgvPopisNaloga.Columns["Id"].DisplayIndex = 0;
            dgvPopisNaloga.Columns["Sifra_pacijenta"].DisplayIndex = 1;
            dgvPopisNaloga.Columns["Id_rezultata"].DisplayIndex = 2;
            dgvPopisNaloga.Columns["Faza_pretrage"].DisplayIndex = 3;
            dgvPopisNaloga.Columns["Uzorak"].DisplayIndex = 4;
            dgvPopisNaloga.Columns["Komentari"].DisplayIndex = 5;

            
        }

        private void OtvoriNalog_Click(object sender, EventArgs e)
        {
           
            Nalog oznaceniNalog = dgvPopisNaloga.CurrentRow.DataBoundItem as Nalog;
            if (oznaceniNalog != null)
            {
                if (oznaceniNalog.Uzorak == "Urin")
                {
                    FrmAnalizaUrina frmAnalizaUrina = new FrmAnalizaUrina(oznaceniNalog);
                    frmAnalizaUrina.ShowDialog();
                }
                else
                {
                    FrmKrvnaAnaliza frmKrvnaAnaliza = new FrmKrvnaAnaliza(oznaceniNalog);
                    frmKrvnaAnaliza.ShowDialog();
                }

            }
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            FrmPretraga frmpretraga = new FrmPretraga();
            frmpretraga.ShowDialog();
        }

        private void btnNoviPacijent_Click(object sender, EventArgs e)
        {
            FrmNoviPacijent frmNoviPacijent = new FrmNoviPacijent();
            frmNoviPacijent.ShowDialog();
        }

        private void btnNalog_Click(object sender, EventArgs e)
        {
            FrmDodajNalog frmDodajNalog = new FrmDodajNalog();
            Hide();
            frmDodajNalog.ShowDialog();
            Close();

        }
    }
}
