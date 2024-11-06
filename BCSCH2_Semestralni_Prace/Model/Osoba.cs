using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSCH2_Semestralni_Prace.Model
{
    internal class Osoba
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }
        public string Cislo { get; set; }
        public DateTime Date { get; set; }
    }

    internal class Bezec
    {
        public int Id { get; set; }
        public string Kategorie { get; set; }

    }

    internal class Organizator
    {
        public int Id { get; set; }
        public string Pozice { get; set; }
        public double Plat {  get; set; }
    }
}
