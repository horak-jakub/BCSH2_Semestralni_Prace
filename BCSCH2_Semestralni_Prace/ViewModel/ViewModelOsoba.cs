using BCSCH2_Semestralni_Prace.Model;
using BCSCH2_Semestralni_Prace.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSCH2_Semestralni_Prace.ViewModel
{


    internal class ViewModelOrganizator 
    {
        public Organizator Organizator { get; }

        public ViewModelOrganizator()
        {
            Organizator = new Organizator();
        }

        public ViewModelOrganizator(string uzivatelskeJmeno, string heslo)
        {
            Organizator = Load(uzivatelskeJmeno, heslo);
        }

        public void Save()
        {
            LiteDBManager.SaveOsoba(Organizator);
        }

        private Organizator Load(string uzivatelskeJmeno, string heslo)
        {
            var o = LiteDBManager.LoadOsoba(uzivatelskeJmeno, heslo);
            if (o is Organizator)
            {
                return (Organizator)o;
            }
            throw new Exception("Nacteni spatneho typu entity.");
        }
    }

}
