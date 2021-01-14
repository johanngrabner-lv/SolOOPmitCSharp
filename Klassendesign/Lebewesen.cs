using System;
using System.Collections.Generic;
using System.Text;

namespace Klassendesign
{
    abstract class Lebewesen
    {
        //abstract ersetzt das Schlüsselwort virtual 
        public abstract void PrintInfo();

        public void Atmen()
        {
            Console.WriteLine("Sauerstoff");
        }
    }
}
