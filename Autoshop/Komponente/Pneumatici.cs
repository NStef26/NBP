using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum TipGuma { Zimske , Letnje, MS };
    public enum Stanje { Polovni, Novi };

    public class Pneumatici : Komponenta
    {
        public string Dimenzije { get; set; }
        public TipGuma Tip { get; set; }
        public Stanje Stanje { get; set; }

        public override string ToString()
        {
            return string.Format("Dimenzije: {0}, Tip: {1}, Stanje: {2}", Dimenzije, Tip.ToString(), Stanje.ToString());
        }
    }
}
