using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_02
{
    public class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu_, string  data_, double wartosc_)
        {
            NazwaPrzedmiotu = nazwaPrzedmiotu_;
            Data = data_;
            Wartosc = wartosc_;
        }

        public string NazwaPrzedmiotu { get => nazwaPrzedmiotu; set => nazwaPrzedmiotu = value; }
        public string Data { get => data; set => data = value; }
        public double Wartosc { get => wartosc; set => wartosc = value; }

        public void WypiszInfo()
        {
            Console.WriteLine("   Nazwa przedmiotu: {0}", NazwaPrzedmiotu);
            Console.WriteLine("   Data: {0}", Data);
            Console.WriteLine("   Wartość: {0}", Wartosc);
            Console.WriteLine(" ");
        }
    }
}
