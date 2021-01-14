using System;

namespace ZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich Willkommen zum Zahlenraten");
            int zufaelligeZahl = 0;
            int benutzerEingabe=0;
            string ausgabe = "";
            int counter = 0;
            Random random = new Random();
            zufaelligeZahl = random.Next(1, 10);

            do
            {
                counter++;
                Console.WriteLine($"Bitte geben Sie {counter}. ab");
                benutzerEingabe = int.Parse(Console.ReadLine());

                if (benutzerEingabe < zufaelligeZahl)
                {
                    Console.WriteLine("Die zufällige Zahl ist größer");
                }
                else if (benutzerEingabe>zufaelligeZahl)
                {
                    Console.WriteLine("Die zufällige Zahl kleiner");
                }
              

            } while (benutzerEingabe != zufaelligeZahl && counter<10);

            if (counter<5)
            {
                ausgabe =$"Juhu perfekt in {counter} Versuchen die richtige Zahl erraten";
            }
            else if (counter < 8)
            {
                ausgabe = $"OK,  in {counter} Versuchen die richtige Zahl erraten";
            }
            else if (counter==9)
            {
                ausgabe = $"schlecht, in {counter} Versuchen die richtige Zahl erraten";
            }
            else
            {
                ausgabe = $"nicht erraten, die richtige Zahl wäre {zufaelligeZahl}";
            }

            Console.WriteLine(ausgabe);
        }
    }
}
