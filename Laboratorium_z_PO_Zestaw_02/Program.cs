using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_02
{
    class Program
    {
        static void Main(string[] args)
        {
            rysujGwiazdki();
            Console.WriteLine("Zadanie 1");
            rysujGwiazdki();

            Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");
            o.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

            s.WypiszInfo();
            p.WypiszInfo();

            ((Pilkarz)o3).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o3.WypiszInfo();
            p.WypiszInfo();

            rysujGwiazdki();
            Console.WriteLine("Zadanie 2");
            rysujGwiazdki();

            ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy danych", "13.02.2011", 4.0);

            o2.WypiszInfo();

            s.DodajOcene("Bazy danych", "01.05.2011", 5.0);
            s.DodajOcene("AWW", "11.05.2011", 5.0);
            s.DodajOcene("AWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.UsunOcene("AWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.DodajOcene("AWW", "02.04.2011", 4.5);
            s.UsunOceny("AWW");

            s.WypiszInfo();

            s.DodajOcene("AWW", "02.04.2011", 4.5);
            s.UsunOceny();

            s.WypiszInfo();

            rysujGwiazdki();
            Console.WriteLine("Zadanie Domowe");
            rysujGwiazdki();

            PilkarzNozny pilkarzNozny = new PilkarzNozny("Adam", "Nowak", "12.03.1996", "pomocnik", "FC Jakisklub");
            PilkarzReczny pilkarzReczny = new PilkarzReczny("Jan", "Kowalski", "07.12.1993", "bramkarz", "Inny klub");

            pilkarzNozny.StrzelGola();
            pilkarzReczny.StrzelGola();

            pilkarzNozny.WypiszInfo();
            pilkarzReczny.WypiszInfo();

            Console.Read();
        }

        private static void rysujGwiazdki()
        {
            Console.WriteLine("****************");
        }
    }
}
