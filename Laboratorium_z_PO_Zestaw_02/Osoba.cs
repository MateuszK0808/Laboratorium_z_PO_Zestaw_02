using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_02
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private string dataUrodzenia;

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            Imie = imie_;
            Nazwisko = nazwisko_;
            DataUrodzenia = dataUrodzenia_;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("______________________________________");
            Console.WriteLine("Imie: {0}", Imie);
            Console.WriteLine("Nazwisko: {0}", Nazwisko);
            Console.WriteLine("Data urodzenia: {0}", DataUrodzenia);
        }

        
    }
}
