using System;
using System.Collections.Generic;
using System.Text;

namespace GenerischeDatentypen
{
    class Fahrzeug<T>
    {
        public LicensePlate<T> Kennzeichen{ get; set; }
    }
}
