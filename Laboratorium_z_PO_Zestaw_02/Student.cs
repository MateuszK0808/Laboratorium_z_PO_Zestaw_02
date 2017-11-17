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
        private List<Ocena> oceny = new List<Ocena>();

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
            Console.WriteLine(" ");
            WypiszOceny();
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) => oceny.Add(new Ocena(nazwaPrzedmiotu, data, wartosc));

        public void WypiszOceny() => oceny.ForEach(o => o.WypiszInfo());

        public void WypiszOceny(string nazwaPrzedmiotu) {
            oceny.ForEach(o =>
            {
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu) o.WypiszInfo();
            });
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) =>
            oceny.RemoveAll(o => o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc);

        public void UsunOceny() => oceny.Clear();

        public void UsunOceny(string nazwaPrzedmiotu) => oceny.RemoveAll(o => o.NazwaPrzedmiotu == nazwaPrzedmiotu);
    }
}
