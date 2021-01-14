using System;
using System.Collections.Generic;
using System.Text;

namespace Klassendesign
{
    class MusikerIn: Person
    {
        public string Instrument { get; set; }

        public void Spielen()
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("Haaalllooooo "); ;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Ich bin eine MusikerIn");
        }
    }
}
