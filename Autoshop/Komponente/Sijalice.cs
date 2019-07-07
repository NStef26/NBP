using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum TipSijalice { Zmigavac, Kratko ,Dugo,Maglenke};

    public class Sijalice : Komponenta
    {
        public int Vati { get; set; }
        public TipSijalice Tip { get; set; }

        public override string ToString()
        {
            return string.Format("Vati: {0}, Tip: {1}", Vati, Tip.ToString());
        }
    }
}
