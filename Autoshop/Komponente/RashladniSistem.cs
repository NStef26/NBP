using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum TipRashladnog { Hladnjak, Termostat,Ventilator };

    public class RashladniSistem : Komponenta
    {
        public string Dimenzija { get; set; }
        public TipRashladnog Tip { get; set; }

        public override string ToString()
        {
            return string.Format("Dimenzije: {0}, Tip: {1}", Dimenzija, Tip.ToString());
        }
    }
}
