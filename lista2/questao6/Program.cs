using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
            {
                int s = a + c;
                Console.WriteLine($"A soma do maior com o menor número é {s}");
            }
            if (b > a && a > c)
            {
                int s = b + c;
                Console.WriteLine($"A soma do maior com o menor número é {s}");
            }
            if (a > c && c > b)
            {
                int s = a + c;
                Console.WriteLine($"A soma do maior com o menor número é {s}");
            }
            if (b > c && c > a)
            {
                int s = a + c;
                Console.WriteLine($"A soma do maior com o menor número é {s}");
            }
            if (c > b && b > a)
            {
                int s = a + c;
                Console.WriteLine($"A soma do maior com o menor número é {s}");
            }
            if (c > a && a > b)
            {
                int s = a + c;
                Console.WriteLine($"A soma do maior com o menor número é {s}");
            }
        }
    }
}
