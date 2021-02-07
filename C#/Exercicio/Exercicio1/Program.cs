using System;

// Faça um algoritmo que conte de 1 a 100 e a cada múltiplo de 10 emita uma mensagem:
// “Múltiplo de 10”.


namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"Esse e multiplo de 10:{i}");
                }
            }
        }
    }
}
