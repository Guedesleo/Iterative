using System;


// Disciplina   : [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 

// Leia nome, salário e categoria de um funcionário,
//se a categoria for = “m” de mensalista,conceder 10% de aumento,
//se for = “h” de horista, conceder 20% de aumento,
//se não for “m” nem “h”, exibir a mensagem categoria inválida.
namespace Exercicio2
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string nome;
            string categoria;
            int salario;
         

            Console.WriteLine("Qua é o seu nome?");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual e o seu salario?");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite m se for mensalista ou h se for horista:");
            categoria = Convert.ToString(Console.ReadLine());
            double aumento = salario;
            if (categoria == "m")
            {
                categoria = "mensalista";
                aumento = (0.1* salario);
            }
            else
            {
                if (categoria == "h")
                {
                    categoria = "horista";
                    aumento = (0.2 * salario);
                }
                else
                {
                    Console.WriteLine("Categoria inválida");
                }
            }
            Console.WriteLine($"Olá {nome}, o seu salario hoje e de {salario}, por ser { categoria} ouve um aumento no seu salario de {aumento}.");
        }
    }
}
