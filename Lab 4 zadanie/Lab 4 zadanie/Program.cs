using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Lab_4_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ksiazka = new Ksiazka();
            bool wynik = false;
            Console.WriteLine("Podaj tytul lub autora ksiazki");
            string tekst = Console.ReadLine();
            Ksiazka[,,] lokalizacja = new Ksiazka[3, 6, 10];
            for (int r = 0; r < 3; r++)
            {
                for (int p = 0; p < 6; p++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        ksiazka = new Ksiazka(r, p, m);
                        ksiazka.Tytul = "Akademia Pana Kleksa";
                        ksiazka.Autor = "J. Brzechwa";
                        if (Ksiazka.Regal == 2 && Ksiazka.Polka == 2 && Ksiazka.Miejsce == 2)
                        {
                            ksiazka.Autor = "A. Mickiewicz";
                            ksiazka.Tytul = "Pan Tadeusz";
                        }
                    }
                }
            }
            if (ksiazka.Tytul.Contains(tekst, StringComparison.OrdinalIgnoreCase) || ksiazka.Autor.Contains(tekst, StringComparison.OrdinalIgnoreCase))
            {
                wynik = true;
            }
            else wynik = false;
            void szukajKsiazki()
            {
                if (wynik == true)
                {
                    Console.WriteLine("Twoja ksiazka znajduje sie na regale " + (Ksiazka.Regal+1) + ", polka " + (Ksiazka.Polka+1) +
                        " miejsce " + (Ksiazka.Miejsce+1) + ". Zyczymy milego czytania.");
                }
                else Console.WriteLine("Nie znaleziono takiej pozycji.");
            }
            szukajKsiazki();
        }

    }
}