using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;

namespace Zadlab3
{
    class Program
    {
        static void sumowanie()
        {
            int[][] tablica = new int[4][];    //utworzenie tablicy
            for (int i = 0; i < 4; i++)
                tablica[i] = new int[i + 1];
            for (int y = 0; y < tablica.Length; y++)  // wypisanie wartości w tablicach
            {
                for (int x = 0; x < tablica[y].Length; x++)
                {
                    tablica[y][x] = x * y;
                }
            }
            /*for (int y = 0; y < tablica.Length; y++)    // wyświetlenie tablicy
            {
                for (int x = 0; x < tablica[y].Length; x++)
                    Console.Write(tablica[y][x] + "\t");
                Console.WriteLine();
            }*/
            int suma = 0;
            for (int y = 0; y < tablica.Length; y++)
                for (int x = 0; x < tablica[y].Length; x++)
                {
                    suma += tablica[y][x];
                }
            Console.WriteLine("Zadanie 1. Suma tablicy wynosi: " + suma);
            Console.WriteLine();
        }

        static void zmianaTeksu(string tekst)
        {
            tekst = tekst.Replace('k', 'K');
            string kropka = ".";
            int indeks = tekst.IndexOf(kropka);
            if(indeks >=0)
            {
                Console.WriteLine("Zadanie 2. Twoj poprawiony tekst to: " + tekst);
            }
            else
            {
                string modyfikacja = tekst.Insert(17, ".");
                Console.WriteLine("Zadanie 2. Twoj poprawiony tekst to: " + modyfikacja);
            }
            
        }
        static void Main(string[] args)
        {
            sumowanie();
            string tekst = "kot spi na fotelu";
            zmianaTeksu(tekst);
        }
    }
}
