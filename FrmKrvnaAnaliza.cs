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
            var rezultati = RezultatiRepos.GetRezultati(oznaceniNalog.Id_rezultata);
            var pacijent = PacijentRepos.GetPacijent(oznaceniNalog.Sifra_pacijenta);
            MCV.Text = rezultati.MCV;
            MCH.Text = rezultati.MCH;
            MPV.Text = rezultati.MPV;
            MCHC.Text = rezultati.MCHC;
            RDW.Text=rezultati.RDW;
            PDW.Text = rezultati.PDW;
            EOS.Text = rezultati.EOS;
            LYM.Text = rezultati.LYM;
            BASO.Text = rezultati.BASO;
            PLT.Text=rezultati.PLT;
            NEU.Text=rezultati.NEU;
            Bazofili.Text=rezultati.Bazofili;
            Monociti.Text=rezultati.Monociti;
            Limfociti.Text = rezultati.Limfociti;
            Hemoglobin.Text=rezultati.Hemoglobin;
            Hematokrit.Text=rezultati.Hematokrit;
            Neutroliti.Text = rezultati.Neutroliti;
            Eozinofili.Text=rezultati.Eozinofili;
            Eritrociti.Text = rezultati.Eritrociti;
            Leukociti.Text = rezultati.Leukociti;

            
            Pacijent.Text = oznaceniNalog.Sifra_pacijenta.ToString();
            SifraNaloga.Text = oznaceniNalog.Id.ToString();
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
