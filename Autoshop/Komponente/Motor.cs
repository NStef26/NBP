using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop.Komponente
{
    public enum VrstaGoriva { Dizel, Benzin, TNG };

    public class Motor : Komponenta
    {
        public int KonjskeSnage { get; set; }
        public int Kubikaza { get; set; }
        public int Kilovati { get; set; }
        public VrstaGoriva VrstaGoriva { get; set; }

        public override string ToString()
        {
            return string.Format("Konjske snage: {0}, Kubikaza: {1}, Kilovati: {2}, Vrsta goriva: {3}", KonjskeSnage, Kubikaza, Kilovati, VrstaGoriva.ToString());
        }
    }
}
