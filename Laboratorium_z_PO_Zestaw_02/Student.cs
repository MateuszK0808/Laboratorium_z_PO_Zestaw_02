using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_02
{
    public class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndexu;

        public Student(
            string imie_,
            string nazwisko_,
            string dataUrodzenia_,
            int rok_,
            int grupa_,
            int nrIndexu_
            ) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            Rok = rok_;
            Grupa = grupa_;
            NrIndexu = nrIndexu_;
        }

        public int Rok { get => rok; set => rok = value; }
        public int Grupa { get => grupa; set => grupa = value; }
        public int NrIndexu { get => nrIndexu; set => nrIndexu = value; }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok: " + Rok);
            Console.WriteLine("Grupa: " + Grupa);
            Console.WriteLine("Numer indexu: " + NrIndexu);
        }
    }
}
