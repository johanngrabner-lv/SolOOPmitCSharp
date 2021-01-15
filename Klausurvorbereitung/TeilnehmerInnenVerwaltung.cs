using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Klausurvorbereitung
{
    class TeilnehmerInnenVerwaltung
    {
        public TeilnehmerInnenVerwaltung()
        {
            MeineTeilnehmerInnen = new List<TeilnehmerIn>();
        }
        public List<TeilnehmerIn> MeineTeilnehmerInnen{ get; set; }

        public void FillTeilnehmerInnenWithSampleValues()
        {
            MeineTeilnehmerInnen.Add(new TeilnehmerIn() { Vorname = "Leonie", Urlaubstage = 12 });
            MeineTeilnehmerInnen.Add(new TeilnehmerIn() { Vorname = "Magdalena", Urlaubstage = 17 });
            MeineTeilnehmerInnen.Add(new TeilnehmerIn() { Vorname = "Silke", Urlaubstage = 9 });
        }

        public List<TeilnehmerIn> AlleTeilnehmer(double maxUrlaubstage)
        {
            List<TeilnehmerIn> ergebnis = new List<TeilnehmerIn>();
            foreach (TeilnehmerIn teilnehmerIn in MeineTeilnehmerInnen)
            {
                if (teilnehmerIn.Urlaubstage > maxUrlaubstage)
                    ergebnis.Add(teilnehmerIn);
            }

            return ergebnis;
        }

        public List<TeilnehmerIn> AlleTeilnehmerMitLinq(double maxUrlaubstage)
        {
            //LINQ Language integrated query
            return MeineTeilnehmerInnen.Where(t => t.Urlaubstage > maxUrlaubstage).ToList();
        }
    }
}
