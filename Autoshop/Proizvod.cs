using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    public class Proizvod
    {
        public object Id { get; set; }
        public string ImeKolekcije { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }

        public override string ToString()
        {
            return string.Format("Tip:{0}, Ukupna cena:{1}, Kolicina:{2}", ImeKolekcije, Cena.ToString(), Kolicina.ToString());
        }
    }
}
