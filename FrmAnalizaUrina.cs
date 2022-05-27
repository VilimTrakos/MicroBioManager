using MicroBioManager.Classes;
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
        public FrmAnalizaUrina(Nalog oznaceniNalog)
        {
            InitializeComponent();
            nalog = oznaceniNalog;
        }

        private void FrmAnalizaUrina_Load(object sender, EventArgs e)
        {

        }
    }
}
