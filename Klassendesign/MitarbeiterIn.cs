using System;
using System.Collections.Generic;
using System.Text;

namespace Klassendesign
{
    class MitarbeiterIn: Person
    {
        public double Gehalt { get; set; }

        public override void SayHello()
        {
            Console.WriteLine("Guten Tag");
        }
    }
}
