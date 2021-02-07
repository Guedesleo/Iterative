using System;

//Elabore um algoritmo  para Imprimir a tabuada de qualquer número informado. 
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero;
                int resultado;
                Console.WriteLine("Qual e a tabuada que voce precisa saber?");
                numero = Convert.ToInt32(Console.ReadLine());

                for (var i = 0; i <= 10; i++)
                {
                    if (numero >= 0)
                    {
                        resultado = i * numero;
                        Console.WriteLine($"{numero} x {i} = {resultado}");
                    }
                }
                if(numero< 0)
                {
                        Console.WriteLine("Por favor digite um numero maior que 0 !");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Por favor digite um numero que seja inteiro !");
            }
        }
    }
}
