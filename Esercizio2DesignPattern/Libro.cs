using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2DesignPattern
{
    public class Libro
    {
        public List<Pagina> Pagine { get; private set; } = new List<Pagina>();
        List<Sezione> sezioni = new List<Sezione>();

        public Libro() { }

        public string StampaLibro()
        {
            string testo = "Libro\n";
            foreach (Pagina p in Pagine)
                testo += p.StampaPagina();
            testo = "Fine Libro\n";
            return testo;
        }

        public Sezione CreaSezione()
        {
            Sezione s = new Sezione();
            sezioni.Add(s);
            return s;
        }

        public Pagina CreaPagina(string testo)
        {
            Pagina p = new Pagina(testo);
            Pagine.Add(p);
            return p;
        }
    }
}
