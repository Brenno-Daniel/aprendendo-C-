using System;

namespace Entrada_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma de valores digitados pelo usuário
            string nome;
            double num1, num2, res;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o primeiro valor: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            num2 = double.Parse(Console.ReadLine());

            res = num1 + num2;

            Console.WriteLine(nome + " soma dos valores é: " + res);
            
            



        }
    }
}
