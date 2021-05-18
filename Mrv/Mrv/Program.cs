using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6; 
            double y = -2;

            x += (x % 4) + 1 * y;
            x = x + x * y;
            ++x;

            y = x / 2;
            y = x > 0 ? y + 1 : y - 5;
            Console.WriteLine(y);

        }
    }
}
