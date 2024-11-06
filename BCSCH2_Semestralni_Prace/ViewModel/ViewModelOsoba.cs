using BCSCH2_Semestralni_Prace.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSCH2_Semestralni_Prace.ViewModel
{
    internal class ViewModelOsoba
    {
        public Osoba Osoba { get; set; }

        public ViewModelOsoba()
        {
            Osoba = new Osoba();
        }
    }

}
