using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public class Akumulatori : Komponenta
    {
        public int Voltaza { get; set; }
        public int Kapacitet { get; set; }
        public int Snaga { get; set; }
        public string Dimenzije { get; set; }

        public override string ToString()
        {
            return string.Format("Voltaza: {0}, Kapacitet: {1}, Snaga: {2}, Dimenzije: {3}", Voltaza, Kapacitet, Snaga, Dimenzije);
        }
    }
}
