﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeZwei
{
    class Rechteck
    {
        private int _Laenge;
        public int Laenge
        {
            get
            {
                return _Laenge;
            }
            set
            {
                if (Laenge < 0)
                {
                    Console.WriteLine("Negativer Wert nicht erlaubt");
                    throw new Exception("Laenge darf nicht negativ sein");
                }
                else
                {
                    _Laenge = value;
                }                  

                
            }
        }
        public int Breite { get; set; }

        public Rechteck():this(10,20)
        {
            Console.WriteLine("Nach dem Aufruf des Konstruktors mit 2 Parametern");
        }
        public Rechteck(int laengeUndBreite):this(laengeUndBreite,laengeUndBreite)
        {
            
        }
        public Rechteck(int laenge, int breite)
        {
            Console.WriteLine("Der Konstruktor wurde aufgerufen!");
            Laenge = laenge;
            Breite = breite;
        }


        public int GetUmfang()
        {
            return (Laenge + Breite) * 2;
        }

        public int Flaeche
        {
            get
            {
                return Laenge * Breite;
            }
        }

        public override string ToString()
        {
            return $"Laenge: {Laenge} Breite {Breite} Umfang: {GetUmfang()} Fläche: {Flaeche} ";
        }
    }
}
