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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik LoggedZaposlenik { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Zaposlenik zaposlenik = ZaposlenikRepos.GetZaposlenik(txtUsername.Text);
                if (zaposlenik!=null && txtPassword.Text == zaposlenik.Password)
                {
                    LoggedZaposlenik = zaposlenik;
                    FrmPocetna frmPocetna = new FrmPocetna();
                    Hide();
                    frmPocetna.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


                }
            }
        }

        
    }
}
