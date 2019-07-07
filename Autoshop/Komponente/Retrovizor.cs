using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum TipRetrovizora { Levi, Desni, Unutrasnji };

    public class Retrovizor : Komponenta
    {
        public TipRetrovizora Tip { get; set; }

        public override string ToString()
        {
            return string.Format("Tip: {0}", Tip.ToString());
        }
    }
}
