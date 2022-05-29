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
    public partial class FrmPretraga : Form
    {
        public FrmPretraga()
        {
            InitializeComponent();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text != "")
            {
                int unesenaSifra = int.Parse(txtSearch.Text);

                
                var nalozi = NalogRepos.GetNalogeSifra(unesenaSifra);
                dgvRezultatiPretrage.DataSource = nalozi;
                dgvRezultatiPretrage.Columns["Id"].DisplayIndex = 0;
                dgvRezultatiPretrage.Columns["Sifra_pacijenta"].DisplayIndex = 1;
                dgvRezultatiPretrage.Columns["Id_rezultata"].DisplayIndex = 2;
                dgvRezultatiPretrage.Columns["Faza_pretrage"].DisplayIndex = 3;
                dgvRezultatiPretrage.Columns["Uzorak"].DisplayIndex = 4;
                dgvRezultatiPretrage.Columns["Komentari"].DisplayIndex = 5;

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Nalog oznaceniNalog = dgvRezultatiPretrage.CurrentRow.DataBoundItem as Nalog;
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
    }
}
