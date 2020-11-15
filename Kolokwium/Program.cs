using System;

namespace Kolokwium
{
    class Program
    {
        public static void Zadanie1()
        {
            
            
            Console.WriteLine("Podaj promien: ");
            double promien = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc: ");
            double wysokosc = double.Parse(Console.ReadLine());
            double l = Math.Sqrt((Math.Pow(promien, 2)) + (Math.Pow(wysokosc, 2)));
            double PolePowierzchni = Math.PI * (Math.Pow(promien, 2)) + (Math.PI * promien * l);
            double objetoscStozka = ((PolePowierzchni * wysokosc) / 3);
            Console.WriteLine("Twoje r to: " + promien + " , h: " + wysokosc + " , l: " + l + " . Pole powierzchni wynosi: " + PolePowierzchni + " ,a objetosc stozka " + objetoscStozka);

        }
        public static void Zadanie2()
        {
            int[] wynik = new int[10];
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("Podaj wynik pomiaru: ");
                int a = int.Parse(Console.ReadLine());
                wynik[i] = a;
            }
            double z = 0;
            for (int i = 0; i < 10; i++)
            {
                double sredniaPomiarow = (wynik[i] / 2);
                sredniaPomiarow = z;
                Console.WriteLine("Srednia pomiarow wynosi: " + sredniaPomiarow);
            }
            
            if(z >= 300)
            {
                Console.WriteLine("Alarm zostal wlaczony!");
            }
            
        }
        
        class Bateria
        {
            public int Poziom;
            public enum Stan
            {
                Podlaczona,
                Odlaczona
            }
        }
         
        public static void Zadanie3()
        {
            Bateria bateria = new Bateria();
            Program.Bateria.Stan stan;
            
            void LadowanieStart()
            {
                stan = Program.Bateria.Stan.Podlaczona;
            }
            void  LadowanieStop()
            {
                stan = Program.Bateria.Stan.Odlaczona;
            }
            void Czas()
            {
                if(stan == Bateria.Stan.Odlaczona)
                {
                    bateria.Poziom--;
                    if (bateria.Poziom == 0)
                    {
                        Console.WriteLine("Bateria osiagnela poziom minimum!");
                    }
                }
                else if (stan == Bateria.Stan.Podlaczona)
                {
                    bateria.Poziom++;
                    if (bateria.Poziom == 100)
                    {
                        Console.WriteLine("Bateria osiagnela poziom maksimum!");
                    }
                }

                LadowanieStart();
                LadowanieStop();
                Czas();
            }
        }
        
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
        }
    }
}
