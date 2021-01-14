using System;

namespace Klassendesign
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string demoText = "Hallo";

            Person p1; //null 
            p1 = new Person(); //new forder speichert für das Objekt vom Typ Person
            p1.Alter = 7; //nullreference exception
           
            p1.Vorname = "Maria";

            Person p2 = new Person(30);
            //p2.Alter = 30;
            p2.Vorname = "Kurt";

            SayHello(p1);
            SayHello(p2);

            Person p3 = new Person() { Alter = 47, Vorname = "Sabine" };
            //Value-Variablen
            int zahl = 20;
            ChangeValue(zahl); //zahl? -- 20 / 17

            //Reference variable
            ChangeReference(p3);

            MusikerIn m = new MusikerIn();
            m.Vorname = "Willi";
            m.Instrument = "Gitarre";
            m.Spielen();

            Person p = m; //Up-Cast -- implizit 
            //p.Instrument - Property ist nur über MusikerIn verfügbar

            MusikerIn m2 = (MusikerIn)p;//Downcast würde zu InvalidCastException falls keine MusikerIn

            MitarbeiterIn mitarbeiterIn1 = new MitarbeiterIn();
            mitarbeiterIn1.Gehalt = 200;

            Person person = mitarbeiterIn1;

            Person[] meinePersonen = new Person[2];
            meinePersonen[0] = m;
            meinePersonen[1] = person;

            p2.SayHello();
            mitarbeiterIn1.SayHello();
            Person pUrsprungMitarbeteiterIn = mitarbeiterIn1;

            //Latebinding bei polymorphen Methoden-Aufrufen 
            pUrsprungMitarbeteiterIn.SayHello(); //Person oder MitarbeiterIn?
            m2.SayHello();

            //Early-Binding - Methode ist nicht als polymorph gekennzeichnet
            pUrsprungMitarbeteiterIn.SayGoodbye();

        }

        public static void ChangeValue(int z)
        {
            z = 17;
        }

        public static void ChangeReference(Person p)
        {
            p.Vorname = "Hans";
        }

        public static void SayHello(Person person)
        {
            string begr = person.GetBegruessung();
            Console.WriteLine(begr);
        }
    }
}
