using System;

namespace AufgabeZwei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verkettete Konstruktoren :this(
            //.net Properties für Laenge und Breite, explizit get{.... , automatic properties
            Rechteck r1 = new Rechteck(10, 20); //Laenge Breite
            Rechteck r2 = new Rechteck(10); // Laenge == Breite

            int umfang = r1.GetUmfang();
            int flaeche = r1.Flaeche; // Get-Property
           // r1.Flaeche = 200; nicht möglich

            /*
             * public int Flaeche
            {
                get
                {
                    return _Laenge * Breite; 
                }

            }*/

            InfoAusgeben(r1); // Laenge, Breite, Umfang, Flaeche
            InfoAusgeben(r2);
        }

        private static void InfoAusgeben(Rechteck rechteck)
        {
            Console.WriteLine(rechteck.ToString());
        }
    }
}
