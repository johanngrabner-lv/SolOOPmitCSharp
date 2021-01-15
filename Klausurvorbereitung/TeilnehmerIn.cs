using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Klausurvorbereitung
{
    class TeilnehmerIn: IKlausurLog
    {
        public int TeilnehmerID { get; set; }
        public string Vorname { get; set; }
       //public string Nachname { get { }; set; }

        private string _Nachname;

        public string Nachname
        {
            get
            {
                return _Nachname;
            }
            set
            {
                if (value.Length > 15)
                    throw new NachnameException("zu lang");

                _Nachname = value;

            }
        }
        public double Urlaubstage { get; set; }

        public int CompareTo([AllowNull] TeilnehmerIn other)
        {
            throw new NotImplementedException();
        }

        public  bool Equals([AllowNull] TeilnehmerIn x, [AllowNull] TeilnehmerIn y)
        {
            return x.Vorname == y.Vorname && x.Urlaubstage == y.Urlaubstage;
        }

        public int GetHashCode([DisallowNull] TeilnehmerIn obj)
        {
            return TeilnehmerID;
        }

        public override string ToString()
        {
            return $"Vorname:{Vorname} Urlaubstage: {Urlaubstage}";
        }

        public void TraceInfo()
        {
            Console.WriteLine("Interface");
        }
    }

  
}
