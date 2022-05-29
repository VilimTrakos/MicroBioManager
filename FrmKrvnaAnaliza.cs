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
    public partial class FrmKrvnaAnaliza : Form
    {
        private Nalog nalog;

        public Nalog oznaceniNalog { get => nalog; set => nalog = value; }

        public FrmKrvnaAnaliza(Nalog oznaceniNalog)
        {
            InitializeComponent();
            nalog = oznaceniNalog;
        }
        public FrmKrvnaAnaliza()
        {
            InitializeComponent();
        }

        private void FrmKrvnaAnaliza_Load(object sender, EventArgs e)
        {
            
            var rezultati = RezultatiRepos.GetRezultati(oznaceniNalog.Id_rezultata);
           
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

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveKr_Click(object sender, EventArgs e)
        {
           
            var mcv = MCV.Text;
            var mch= MCH.Text;
            var mpv= MPV.Text;
            var mchc= MCHC.Text;
            var rdw= RDW.Text;
            var pdw= PDW.Text;
            var eos= EOS.Text;
            var lym= LYM.Text;
            var baso= BASO.Text;
            var plt= PLT.Text;
            var neu= NEU.Text;
            var bazofili= Bazofili.Text;
            var monociti= Monociti.Text;
            var limfociti= Limfociti.Text;
            var hemoglobin= Hemoglobin.Text;
            var hematokrit= Hematokrit.Text;
            var neutroliti= Neutroliti.Text;
            var eozinofili= Eozinofili.Text;
            var eritrociti= Eritrociti.Text;
            var leukociti= Leukociti.Text;
            var sifra_pacijenta = Pacijent.Text;
            var sifra_naloga = SifraNaloga.Text;

            string sql = $"" +
                $"UPDATE RezultatiDB SET Sifra_pacijenta ={sifra_pacijenta}, Uzorak ={1},  Eritrociti={eritrociti}" +
                $", Leukociti= {leukociti}, MCV={mcv}, MCH={mch}, MCHC={mchc}, RDW={rdw}, MPV={mpv}, PDW={pdw}, EOS={eos}," +
                $" LYM={lym}, BASO={baso}, PLT={plt}, NEU={neu}, Bazofili={bazofili}, Monociti={monociti}, Limfociti={limfociti}," +
                $" Hemoglobin={hemoglobin}, Hematokrit={hematokrit}, Neutroliti={neutroliti}, Eozinofili ={eozinofili} WHERE Sifra_pacijenta ={sifra_pacijenta} ";
            DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
