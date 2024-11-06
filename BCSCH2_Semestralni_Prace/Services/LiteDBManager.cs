using BCSCH2_Semestralni_Prace.Model;
using BCSCH2_Semestralni_Prace.ViewModel;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSCH2_Semestralni_Prace.Services
{
    internal class LiteDBManager
    {
        public LiteDBManager()
        {
                
        }

        public void SaveOsoba(ViewModelOsoba viewModelOsoba)
        {
            using (var db = new LiteDatabase(@"Filename=Data.db"))
            {
                var personCollection = db.GetCollection<Osoba>("osoby");

                personCollection.Insert(viewModelOsoba.Osoba);
            }
        }
    }
}
