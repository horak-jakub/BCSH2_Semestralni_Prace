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
    internal static class LiteDBManager
    {


        public static void SaveOsoba(Osoba osoba)
        {
            using (var db = new LiteDatabase(@"Filename=Data.db"))
            {
                var osoby = db.GetCollection<Osoba>("osoby");

                osoby.Insert(osoba);
            }
        }

        

        public static Osoba LoadOsoba(string username, string password)
        {
            if (PasswordServices.CheckPassword(password, "", ""))
            {
                using (var db = new LiteDatabase(@"Filename=Data.db"))
                {
                    var osoby = db.GetCollection<Osoba>("osoby");
                    var osoba = osoby.FindOne(x => x.UzivatelskeJmeno == username);
                    //var Id = new ObjectId("60a3c6f3e89a2b34e48f7e8e");  // Example ObjectId
                    //var person = persons.FindById(personId); // Finds the person by ObjectId

                    if (osoba != null)
                    {
                        return osoba;
                    }
                }
            }
            return null;
        }
    }
}
