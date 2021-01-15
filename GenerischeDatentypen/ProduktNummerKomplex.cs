using System;
using System.Collections.Generic;
using System.Text;

namespace GenerischeDatentypen
{
    class ProduktNummerKomplex<T,X>
    {
        public X Staat { get; set; }
        public int Kuerzel { get; set; }

        public T Kennzeichen { get; set; }
    }
}
