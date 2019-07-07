using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Autoshop.Komponente
{
   public enum TipStakla { Vetrobransko, PrednjeDesno, PrednjeLevo, ZadnjeLevo,ZadnjeDesno, Zadnje};
   public class Stakla : Komponenta
    {
        public TipStakla Tip { get; set; }
        public string Dimenzije { get; set; }

        public override string ToString()
        {
            return string.Format("Dimenzije: {0}, Tip: {1}", Dimenzije, Tip.ToString());
        }
    }
}
