using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab_4_zadanie
{
    class Ksiazka
    {
        public  string Tytul { get; set; }
        public  string Autor { get; set;}
        public static int Regal { get; set; }
        public static int Polka { get; set; }
        public static int Miejsce { get; set; }
        public Ksiazka() { }
        public Ksiazka(int r, int p, int m)
        {
            Regal = r;
            Polka = p;
            Miejsce = m;
        }

    }
}
