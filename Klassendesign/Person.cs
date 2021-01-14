using System;
using System.Collections.Generic;
using System.Text;

namespace Klassendesign
{
    class Person
    {
       // public int Alter; - public nicht empfohlen
       // public string Vorname;

        
        //Variante 1 - private Variable + public Property
        private int _Alter; //Encapsulation
        //.net property 
        public int Alter
        {
            get
            {
                return _Alter;
            }
            set
            {
                //check value, if value is less than 0, throw exception
                _Alter = value;
            }
        }
        //Variante 2 Automatic Properties - prop code-snippet, private wird automatisch erzeugt

        public string Vorname { get; set; }

        /*
         * public void setAlter(int value)
         * {
         *    _alter=value;
         * }
         * public int getAlter()
         * {
         *     return _alter;
         * }
        */


        public Person():this(0,"")
        {
            //Alter = 0;
            //Vorname ="";
        }

        //überladener Konstruktor - es gibt keinen Default-Konstruktor mehr
        public Person(int alter):this(alter,"")
        {
            //Alter = alter;
            //Vorname = "";
        }

        public Person(int alter, string vorname)
        {
            Alter = alter;
            Vorname = vorname;
        }


        public string GetBegruessung()
        {
            string ergebnis = "";

            if (Alter < 10)
                ergebnis = "Servus ";
            else
                ergebnis = "Hallo ";

            ergebnis += Vorname;

            return ergebnis;

        }

        public virtual void SayHello() //diese Methode ist polymorph
        {
            Console.WriteLine("Hallo");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Tschüß");
        }
    }
}
