using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum TipOpreme { PrvaPomoc, Presvlaka, Patosnica };

    public class DodatnaOprema : Komponenta
    {
        public string Opis { get; set; }
        public TipOpreme Tip { get; set; }

        public override string ToString()
        {
            return string.Format("Opis: {0}, Tip: {1}", Opis, Tip.ToString());
        }
    }
}
