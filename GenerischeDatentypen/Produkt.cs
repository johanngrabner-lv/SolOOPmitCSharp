using System;
using System.Collections.Generic;
using System.Text;

namespace GenerischeDatentypen
{
    class Produkt<T>
    {
        public T Produktnummer { get; set; }

        public string Beschreibung { get; set; }

        public double Preis { get; set; }
    }
}
