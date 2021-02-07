using System;

//Realize um algoritmo que ordene em ordem crescente um vetor “ZX” de 100 posições. 
namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int[] numeros = new int[100]; ;
            int i, j, atual;

            Console.WriteLine("Digite 100 numeros:");
            for (i = 1; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            for (i = 1; i < numeros.Length; i++)
            {
                for (j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        atual = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = atual;
                    }
                }
            }

            Console.WriteLine("Ordernação por order crescente");
            for (i = 1; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

        }
    }
}
