using System;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, max;
            Console.Write("Podaj pierwszą wartość: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą wartość: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj trzecią wartość: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj czwartą wartość: ");
            d = Convert.ToInt32(Console.ReadLine());
            max = a > b ? a : b;
            max = b > c ? b : c;
            max = c > d ? c : d;
            


            Console.WriteLine("Wartość maksymalna wynosi: {0}.", max);
                    Console.ReadKey();
                }
            }
        } 
