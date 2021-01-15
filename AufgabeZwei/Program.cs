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

            try
            {
                r1.Laenge = -20;
            }
            catch (LaengeBreiteException ex)
            {

                Console.WriteLine($"Ein Fehler {ex.Message} " ); ;
            }
            catch(Exception ex)
            {

            }

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

            Rechteck r3 = new Rechteck();
            r3.Print();
            r3.GetUmfang();

            IPrintable iPrint = r3; //implizite Zuweisung, Up-Cast
            iPrint.Print();

            GeometrischeFigur geometrischeFigur = r3; //Up-Cast
            geometrischeFigur.GetUmfang(); //polymorph


            Kreis kr = new Kreis();

            GeometrischeFigur figur = kr;

            //if (figur is Rechteck

            try
            {
                Rechteck rNichtMoeglich = (Rechteck)figur;
            }
            catch (Exception ex)
            {

                string meldung = ex.Message;
            }
          
            
            Rechteck rechteck;

            if (iPrint is Rechteck)
            {
                rechteck = (Rechteck)iPrint; //Downcast
            }

            if (geometrischeFigur is Rechteck)
            {
                rechteck = (Rechteck)geometrischeFigur;//Downcast
            }
        }

        private static void InfoAusgeben(Rechteck rechteck)
        {
            Console.WriteLine(rechteck.ToString());
        }
    }
}
