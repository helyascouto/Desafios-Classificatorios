using System;
using System.Collections.Generic;

namespace Aceleração_Global_Dev_9_Avanade
{
    class GlobalDev9
    {
        static void Main(string[] args)
        {
            int TotalTartaruga;
            int TartarugaRapida = 0;
            string Grupo = "";
            List<int> Tartaruga = new List<int>();

            Boolean Op = false;
            try
            {
                do
                {
                    int resposta = 0;
                    Console.WriteLine("Velocidade da Tartaruga...");
                    resposta = int.Parse(Console.ReadLine());
                    Tartaruga.Add(resposta);
                    Console.WriteLine("Dejeja adicionar outra Tartaruga?");
                    Console.WriteLine("1-SIM || 2-NÃO");
                    resposta = int.Parse(Console.ReadLine());
                    if (resposta == 1 || resposta  == 2)
                    {
                        if (resposta == 2)
                        {
                            Op = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opsão invalida!");
                        Console.WriteLine("1-SIM || 2-NÃO");
                    }
                   

                   

                } while (Op != true);
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }

            for (int i = 0; i < Tartaruga.Count; i++)
            {
                if (TartarugaRapida <= Tartaruga[i])
                {
                    TartarugaRapida = Tartaruga[i];
                }

                //foreach (var item in Tartaruga)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                if (TartarugaRapida < 10)
                {
                    Grupo = "Grupo 1";
                }

                else if (TartarugaRapida >= 10 && TartarugaRapida < 20)
                {
                    Grupo = "Grupo 2";
                }

                else
                {
                    Grupo = "Grupo 3";
                }

            }

            Console.WriteLine("A tartaruga mais veloz pertence ao grupo{0}, com a velocidade de... {1}cm/h", Grupo, TartarugaRapida);
        }
    }
}
