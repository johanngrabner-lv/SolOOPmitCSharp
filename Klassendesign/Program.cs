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
