using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_combustivel_1
{
    class Tipo_de_combustivel
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;
            do
            {

                Console.WriteLine(" 1-Álcool | 2-Gasolina | 3-Diesel |4-Sair");
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        alcool += +1;
                        break;

                    case 2:
                        gasolina += +1;
                        break;

                    case 3:
                        diesel += +1;
                        break;

                    case 4:
                        Console.WriteLine($" Obrigado por utilizar nosso sistema! \n Alcool: {alcool} Gasolina: {gasolina} Diesel: {diesel})");

                        break;

                    default:
                        Console.WriteLine("Código inválido (fora da faixa de 1 a 4)");
                        break;
                }
            }

            while (escolha != 4);

        }
    }

}
