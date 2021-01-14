using System;
using campus02.dotnet; //using direktive

namespace OOPmitCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(DateTime.Now.Second);
            int zz= random.Next(1, 10);

            Console.WriteLine("Hello Campus02!");

            //Full qualified name
            campus02.dotnet.Customer myFirstCustomer;
            Customer mySecondCustomer;

            /* das ist ein Beispiel
             * für einen Kommentar
             * ------
             */
            string ihrVorname = "";
            Console.WriteLine("What is your name?");
           // ihrVorname = Console.ReadLine(); //Waits for input
            Console.WriteLine($"Nice to meet you {ihrVorname}");

            {
                int i = 12;
                int erg = i + 10;

            }

            System.String text1 = "Hello";
            String text2 = "World"; //System wurde durch using hinzugefügt
            string text3 = "Hallo Campus02"; //string ist ein alias für String


            System.Int32 i1 = 12;
            int i2 = 12; //int ist ein alias für Int32

            System.Int64 l1 = 23423424234;
            Int64 l2 = 23423424234;
            long l3 = 23423424234; //long ist ein alias für System.Int64

            //Ein Buchstabe / Character 

            char buchstabe = 'c';

            string mehrereBuchstaben = "ein Wort";

            long grosseZahl = 0;
            grosseZahl= 42;

            int kleineZahl = 12;

            //implizit eine grössere Variable in eine kleinere konvertieren ist nicht möglich
            //kleineZahl = grosseZahl; 

            //explizite Typumwandlung - cast
            int antwortUniversum = (int)grosseZahl;

            long long1 = long.MaxValue;

            int int1 = (int)long1;

            checked
            {
                //int int2 = (int)long1;
            }

            float fliesskommazahl = 12.456F;
            double groessereZahlMitDez = 12342342323.234;


            if (FunctionA()>2 && FunctionB()<10)
            {
                Console.WriteLine("action");
            }

            if (FunctionA() > 2 & FunctionB() < 10)
            {
                Console.WriteLine("action");
            }

            //empfohlener weg
            int ergebnisFunctionA = FunctionA();
            int ergebnisFunctionB = FunctionB();

            if (ergebnisFunctionA>2 && ergebnisFunctionB<10)
            {
                Console.WriteLine("Action");
            }

            //wäre auch möglich, schlecht lesbar
            if (ergebnisFunctionA > 2 && ergebnisFunctionB < 10)
           
                Console.WriteLine("Action");
           


            int[] meineZahlen=new int[2];
            meineZahlen[0] = 7;
            meineZahlen[1] = 42;

        }

        static int FunctionA()
        {
            Console.WriteLine("Hello von A");
            return 1;
        }

        static int FunctionB()
        {
            Console.WriteLine("Hello von B");
            return 2;
        }
    }
}
//at.campus02.vorlesung -- java
//.net campus02.vorlesung

namespace FirmaA.EDVWaren
{
    class Kunde
    {

    }

}


/*Rätselaufgabe 
 *      Random random = new Random(DateTime.Now.Second);
         int zz= random.Next(1, 10);
 * Computer "überlegt sich eine zufällige Zahl im Bereich zwischen 0 und 100"
 * Benutzer gibt Tipp ab und bekommt Rückmeldung ob kleiner oder größer
 * Maximal 10 Versuche erlaubt
 * Beispiel: Zufällige Zahl 70
 * 1. Eingabe: 35 ---> Meine Zahl ist größer
 * 2. Eingabe: 80 --> Meine zahl ist kleiner
 * 3. Eingabe: 60 --> Meine Zahl ist größer
 * 4. Eingabe: 70 -- -Super Sie nur haben 4 Versuche benötigt
 * 
 * <5 Eingaben == super
 * 6 und 8 == ok
 * 9 == eher schlecht
 * >10 Versuchen --- Sie haben die Zahl nicht erraten
 * 
 * 
 * 
 * 
 */
