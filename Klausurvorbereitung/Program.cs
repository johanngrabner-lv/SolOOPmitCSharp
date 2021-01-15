using System;

namespace Klausurvorbereitung
{
    class Program
    {
        static void Main(string[] args)
        {
            TeilnehmerIn t1 = new TeilnehmerIn() {Nachname="Huber", Vorname = "Johann", Urlaubstage = 5 };
            var t2 = new TeilnehmerIn() {Nachname="Grabner", Vorname = "Johann", Urlaubstage = 5 };

            IKlausurLog klausurLog = t1; //implizite Typumwandlung - Upcast

            klausurLog.TraceInfo();

            if (klausurLog is TeilnehmerIn)
            {
                TeilnehmerIn t = (TeilnehmerIn)klausurLog; //Downcast - explizit
                t.TraceInfo();
            }

            try
            {
                t1.Nachname = "Grabner Demo Test Dummy Nocheinmal Test";
            }
            catch(NachnameException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("ToString\n");
                Console.WriteLine(ex.ToString()) ;
            }
            catch (Exception)
            {

                throw;
            }

            TeilnehmerInnenVerwaltung teilnehmerInnenVerwaltung = new TeilnehmerInnenVerwaltung();
            teilnehmerInnenVerwaltung.FillTeilnehmerInnenWithSampleValues();

            var listeVonTn = teilnehmerInnenVerwaltung.AlleTeilnehmer(10);

           
        }
    }
}
