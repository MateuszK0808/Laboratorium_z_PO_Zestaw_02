using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_02
{
    public class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;
        public Pilkarz(
            string imie_,
            string nazwisko_,
            string dataUrodzenia_,
            string pozycja_,
            string klub_
            ) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            Pozycja = pozycja_;
            Klub = klub_;
        }

        public string Pozycja { get => pozycja; set => pozycja = value; }
        public string Klub { get => klub; set => klub = value; }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Pozycja: {0}", Pozycja);
            Console.WriteLine("Klub: {0}", Klub);
            Console.WriteLine("Liczba goli: {0}", liczbaGoli);
        }

        public virtual void StrzelGola()
        {
            liczbaGoli++;
        }
    }
}
