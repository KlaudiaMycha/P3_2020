using System;

namespace lab_2
{
    class Program
    {
        public enum Wynik
        {
            dwamz,
            jednomz,
            zeromz
        }
        static void Main()
        {
            double a;
            Console.WriteLine("Podaj liczbe a:");
            do
            {
                Console.WriteLine("Liczba a musi byc rozna od 0!");
                a = Convert.ToDouble(Console.ReadLine());
            } while (a == 0);
            Console.WriteLine("Podaj liczbe b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Twoje liczby a, b i c to: " + a + " , " + b + " , " + c);

            double delta = (b * b) - 4 * (a * c);
            Console.WriteLine("Delta wynosi: " + delta);

            Wynik wynik;
            double x = 0, x1 = 0, x2 = 0;
            if (delta == 0)
            {
                x = -b / (2.0 * a);
                wynik = Wynik.jednomz;
            }
            else if (delta > 0)
            {
                x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                wynik = Wynik.dwamz;
            }
            else
            {
                Console.Write("Blad! Delta jest ujemna. ");
                wynik = Wynik.zeromz;
            }

            switch (wynik)
            {
                case Wynik.dwamz:
                    Console.WriteLine("Dwa miejsca zerowe: x1 = " + x1.ToString() + " , x2 = " + x2.ToString());
                    break;
                case Wynik.jednomz:
                    Console.WriteLine("Jedno miejsce zerowe: x = " + x.ToString());
                    break;
                case Wynik.zeromz:
                    Console.WriteLine("Brak miejsc zerowych.");
                    break;
            }
        }
    }
}
