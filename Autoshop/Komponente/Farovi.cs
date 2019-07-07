using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
   public class Farovi : Komponenta
    {
        public string Opis { get; set; }

        public override string ToString()
        {
            return string.Format("Opis: {0}", Opis);
        }
    }
}
