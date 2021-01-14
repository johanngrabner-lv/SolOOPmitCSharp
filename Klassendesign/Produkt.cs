using System;
using System.Collections.Generic;
using System.Text;

namespace Klassendesign
{
    class Produkt : ISaveAndLoad
    {
        public void Load(string filename)
        {
            Console.WriteLine($"Produkt wurde gelanden {filename}");
        }

        public void Save()
        {
            Console.WriteLine("Produkt wurde gespeichert");
        }
    }
}
