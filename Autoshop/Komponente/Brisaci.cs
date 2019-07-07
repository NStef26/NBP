using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum Tip { Prednji, Zadnji };

    public class Brisaci : Komponenta
    {
        public string Dimenzija { get; set; }
        public Tip Tip { get; set; }

        public override string ToString()
        {
            return string.Format("Dimenzija: {0}, Tip: {1}", Dimenzija, Tip.ToString());
        }
    }
}
