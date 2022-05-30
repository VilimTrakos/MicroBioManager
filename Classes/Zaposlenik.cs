using MicroBioManager.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBioManager.Classes
{
    public class Zaposlenik :Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Uloga { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
