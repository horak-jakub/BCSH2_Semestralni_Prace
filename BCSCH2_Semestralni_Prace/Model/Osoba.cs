using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCSCH2_Semestralni_Prace.ViewModel;
using LiteDB;

namespace BCSCH2_Semestralni_Prace.Model
{
    enum TypOsoby { Bezec, Organizator }

    internal class Osoba : INotifyPropertyChanged
    {
        public ObjectId Id { get; set; }
        public TypOsoby TypOsoby { get; protected set; }


        private string jmeno;
        public string Jmeno
        {
            get => jmeno;
            set
            {
                if (jmeno != value)
                {
                    jmeno = value;
                    OnPropertyChanged(nameof(Jmeno));
                }
            }
        }

        private string prijmeni;
        public string Prijmeni
        {
            get => prijmeni;
            set
            {
                if (prijmeni != value)
                {
                    prijmeni = value;
                    OnPropertyChanged(nameof(Prijmeni));
                }
            }
        }

        private string email;
        public string Email
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private string _cislo;
        public string Cislo
        {
            get => _cislo;
            set
            {
                if (_cislo != value)
                {
                    _cislo = value;
                    OnPropertyChanged(nameof(Cislo));
                }
            }
        }

        private string uzivatelskeJmeno;
        public string UzivatelskeJmeno
        {
            get => uzivatelskeJmeno;
            set
            {
                if (uzivatelskeJmeno != value)
                {
                    uzivatelskeJmeno = value;
                    OnPropertyChanged(nameof(UzivatelskeJmeno));
                }
            }
        }

        private string hesloHash;
        private string _hesloSalt;
        public string HesloHash {
            get => hesloHash;
            set
            {
                if (hesloHash != value)
                {
                    (hesloHash, _hesloSalt) = Services.PasswordServices.HashPassword(value);
                }
            }
        }

        public string HesloSalt { get => _hesloSalt; }

        private DateTime _datum;
        public DateTime Datum
        {
            get => _datum;
            set
            {
                if (_datum != value)
                {
                    _datum = value;
                    OnPropertyChanged(nameof(Datum));
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyJmeno)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyJmeno));
        }
    }

    enum Kategorie { od15do18, od18do30, od30do45, nad45 }
    
    internal class Bezec : Osoba
    {
        public ObjectId Id { get; set; }
        public Kategorie Kategorie { get; set; }

        public Bezec()
        {
            TypOsoby = TypOsoby.Bezec;
        }
    }

    internal class Organizator : Osoba
    {
        public ObjectId Id { get; set; }
        //public string Pozice { get; set; }
        //public double Plat {  get; set; }
        private string pozice;
        public string Pozice
        {
            get => pozice;
            set
            {
                if (pozice != value)
                {
                    pozice = value;
                    OnPropertyChanged(nameof(Pozice));
                }
            }
        }

        public Organizator()
        {
            TypOsoby = TypOsoby.Organizator;
        }

        

    }

    internal class Administrator
    {

    }
}
