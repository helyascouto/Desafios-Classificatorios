using System;

namespace invvila
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalVolta, ComprimentoPista, Reabastecimentos, ConsumoCombustivel, MinimoLitros;

            Console.WriteLine("Digite o Comprimento da Pista...");
            ComprimentoPista = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Total de Volta do Grande Premio...");
            TotalVolta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de reabastecimento que gostaria de fazer?...");
            Reabastecimentos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustivel por KM/L...");
            ConsumoCombustivel = int.Parse(Console.ReadLine());

            ComprimentoPista = ComprimentoPista * TotalVolta;
            ConsumoCombustivel = ComprimentoPista  / ConsumoCombustivel;

            int IntervaloAbastecimento = ComprimentoPista / Reabastecimentos;

            MinimoLitros = IntervaloAbastecimento / ConsumoCombustivel;

            Console.WriteLine("A quatidade mínima de litros necessários" +
                " para percorrer até o primeiro reabastecimento è...{0}", MinimoLitros.ToString()); ;

        }
    }
}
