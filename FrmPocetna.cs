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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void DodajKrvna_Click(object sender, EventArgs e)
        {
            FrmKrvnaAnaliza frmKrvnaAnaliza = new FrmKrvnaAnaliza();
            Hide();
            frmKrvnaAnaliza.ShowDialog();
            Close();
        }

        private void DodajUrin_Click(object sender, EventArgs e)
        {
            FrmAnalizaUrina frmAnalizaUrina = new FrmAnalizaUrina();
            Hide();
            frmAnalizaUrina.ShowDialog();
            Close();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            ShowNaloge();
        }

        private void ShowNaloge()
        {
            var nalozi = NalogRepos.GetNaloge();
            dgvPopisNaloga.DataSource = nalozi;
            dgvPopisNaloga.Columns["Id"].DisplayIndex = 0;
            dgvPopisNaloga.Columns["Sifra_pacijenta"].DisplayIndex = 1;
            dgvPopisNaloga.Columns["Id_rezultata"].DisplayIndex = 2;
            dgvPopisNaloga.Columns["Faza_pretrage"].DisplayIndex = 3;
            dgvPopisNaloga.Columns["Naziv_pretrage"].DisplayIndex = 4;
            dgvPopisNaloga.Columns["Komentari"].DisplayIndex = 5;

            
        }
    }
}
