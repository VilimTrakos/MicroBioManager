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

       
    }
}
