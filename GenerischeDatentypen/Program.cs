using System;
using System.Collections;
using System.Collections.Generic;

namespace GenerischeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt<string> produkt1 = new Produkt<string>();
            produkt1.Produktnummer = "A234ks";

            Produkt<int> produkt2 = new Produkt<int>();
            produkt2.Produktnummer = 12;

            Produkt<ProduktNummerKomplex<int,double>> produkt3 = new Produkt<ProduktNummerKomplex<int,double >>();

            produkt3.Produktnummer = new ProduktNummerKomplex<int,double >();
            produkt3.Produktnummer.Kuerzel = 2323;
            produkt3.Produktnummer.Staat = 23.234;

            
            Fahrzeug<string> f1 = new Fahrzeug<string>();
            f1.Kennzeichen = new LicensePlate<string>();
            f1.Kennzeichen.Staat  = "AT"; //49;
            f1.Kennzeichen.Nummerntafel = "GU-234B";

            Fahrzeug<int> f2 = new Fahrzeug<int>();
            f2.Kennzeichen = new LicensePlate<int>();
            f2.Kennzeichen.Staat = 12;

            Dictionary<int, string> meineTeilnehmerInnen = new Dictionary<int, string>();
            meineTeilnehmerInnen.Add(1, "Aiste");
            meineTeilnehmerInnen.Add(2, "Britta");
            meineTeilnehmerInnen.Add(3, "Emina");

            List<string> listOfTeilnehmerInnen = new List<string>();
            listOfTeilnehmerInnen.Add("Iro");
            listOfTeilnehmerInnen.Add("Jayanthi");
            listOfTeilnehmerInnen.Add("Kerstin");

            Console.WriteLine("Liste der TeilnehmerInnen");
            foreach (String item in listOfTeilnehmerInnen)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Liste der TeilnehmerInnen - Dictionary");
            foreach (KeyValuePair<int,string> item in meineTeilnehmerInnen)
            {
                Console.WriteLine($"Nr:{item.Key} Name: {item.Value}");
            }






        }
    }
}
