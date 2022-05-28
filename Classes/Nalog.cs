using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBioManager.Classes
{
    public class Nalog
    {
        public int Id { get; set; }
        public string Faza_pretrage { get; set; }
        public string Komentari { get; set; }
        public int Sifra_pacijenta { get; set; }
        public string Uzorak { get; set; }
        public int Id_zaposlenika { get; set; }
        public int Id_rezultata { get; set; }

    }
}
