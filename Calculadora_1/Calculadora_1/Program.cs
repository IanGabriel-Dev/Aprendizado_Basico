using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = Environment.UserName;
            Console.Write("Seja Bem Vindo "); Console.Write(usuario);
            Console.WriteLine();
            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Multiplicação");
            Console.WriteLine("2 - Adição");
            Console.WriteLine("3 - Subtração");
            Console.WriteLine("4 - Divisão");

            string escolha = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (escolha)
            {
                case "1":
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado da multiplicação: " + resultado);
                    break;
                case "2":
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado da adição: " + resultado);
                    break;
                case "3":
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado da subtração: " + resultado);
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado da divisão: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
                    break;
            }

            Console.WriteLine("Obrigado por utilizar.  by Ian Gabriel");
            }
    }
}
