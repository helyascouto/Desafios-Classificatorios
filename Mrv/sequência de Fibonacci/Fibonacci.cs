using System;

namespace sequência_de_Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int numero1 = 1;
            int numero2 = 0;
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma = numero1 + numero2;
                numero2 = numero1;
                numero2 = soma;
                soma = numero1 + numero2;

                Console.WriteLine(soma);
            }
            
        }
    }
}
