using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int fatorial = 1;
            int cont = 1;
            Console.WriteLine("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("| A seguir escolha qual figura deseja, digitando o número correspondente a figura correspondente.|");
            Console.WriteLine("|         1 ==> Calcular o Fatorial para o numero lido                                           |");
            Console.WriteLine("|         2 ==> Verificar se o numero é Primo                                                    |");
            Console.WriteLine("|         3 ==> Verificar se é Par ou Impar                                                      |");
            Console.WriteLine("|         4 ==>  Calcular o número ao cubo                                                       |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Qual dessa opções voce deseja executar?");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    for (var i = 1; i < numero; i++)
                    {
                        fatorial += fatorial * i;
                    }
                    Console.WriteLine($"O Valor do fatorial que você digitou e:{fatorial}");
                    break;
                case "2":
                    for (var i = 1; i < numero; i++)
                    {
                        if (numero % i == 0)
                            cont++;
                    }
                    if (cont == 2)
                        Console.WriteLine($"O numero {numero} e primo!");
                    else
                        Console.WriteLine($"O numero {numero} nao primo!");
                    break;
                case "3":
                    if (numero % 2 == 0)
                        Console.WriteLine($"O numero que voce digitou e par {numero}.");
                    else
                        Console.WriteLine($"O numero que voce digitou e impar {numero}.");
                    break;
                case "4":
                    if (numero > 0)
                    {
                        double cubo;
                        cubo = Math.Pow(numero, 3);
                        Console.WriteLine($"O valor do numero elevado ao cubo {cubo}.");
                    }
                    break;
                default:
                    Console.WriteLine("Opcao Invalida!");
                    break;
            }
                    

        }
    }
}
