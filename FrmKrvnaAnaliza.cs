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
    public partial class FrmKrvnaAnaliza : Form
    {
        private Nalog nalog;

        public Nalog oznaceniNalog { get => nalog; set => nalog = value; }

        public FrmKrvnaAnaliza(Nalog oznaceniNalog)
        {
            InitializeComponent();
            nalog = oznaceniNalog;
        }

        private void FrmKrvnaAnaliza_Load(object sender, EventArgs e)
        {
            SetFormText();
            var rezultati = RezultatiRepos.GetRezultate();
            
           
            

        }

        private void SetFormText()
        {
            Text = nalog.Sifra_pacijenta + " " + nalog.Id_rezultata;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
