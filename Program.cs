using System;
using System.Globalization;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite dois valores:");
            float x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float y = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo y");
            }
            else 
            {
                Console.WriteLine("Eixo x");
            }
        }
    }
}
