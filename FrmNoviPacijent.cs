using DBLayer;
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
    public partial class FrmNoviPacijent : Form
    {
        public FrmNoviPacijent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
               
                int sifra = int.Parse(txtSifra.Text);

                string sql = $"INSERT INTO Pacijenti_DB (Ime, Prezime, Sifra_pacijenta) VALUES ('{ime}','{prezime}',{sifra})";


                DB.SetConfiguration("vtrakosta20_DB", "vtrakosta20", "6}m#UWqL");
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();

                MessageBox.Show("Uspješno dodan pacijent!");
            }
            catch (Exception)
            {
                MessageBox.Show("Šifra pacijenta već postoji!");

            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtSifra.Clear();
        }
    }
}


