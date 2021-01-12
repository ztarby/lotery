using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loteria_mensa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int a = ran.Next(1, 20);
            int b = ran.Next(1, 20);
            int c = ran.Next(20);
            int d = ran.Next(10, 30);
            int p = 0;

            int result = a + b + c;
            if (a == b || a == c || c == b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("eres piscopata");
                    p += 9;
                }
                else
                {
                    p += 6;
                    Console.WriteLine("eres dios");
                }
            }
            if (result >= d)
            {
                Console.WriteLine("ganaste wey");
                p = p + result;
            }
            else
            {
                Console.WriteLine("loser");
                p = p - result;
            }

            //em
            if (p >= 59)
            {
                Console.WriteLine("Ganaste un trofeo de oro!");
            }
            else if (p >= 39)
            {
                Console.WriteLine("Ganaste trofeo de plata");
            }
            else if (p >= 20)
            {
                Console.WriteLine("Ganaste un trofeo de bronce");
            }
            else
            {
                Console.WriteLine("loser x 2");
            }

            Console.WriteLine($" a: {a} b: {b} c: {c} d: {d} result: {result} P: {p}");
            Console.ReadKey();
        }
    }
}
