using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2DesignPattern
{
    public class Pagina
    {
        internal string testo = "";
        internal Pagina(string t)
        {
            testo = t + "\n";
        }

        public string StampaPagina()
        {
            return testo;
        }
    }
}
