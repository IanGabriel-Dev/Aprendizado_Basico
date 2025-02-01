
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace calculadora_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calcloop = true;
            string usuario = Environment.UserName;

            while (calcloop == true) {
                Console.Clear();
                Console.WriteLine("Olá " + usuario + "Seja Bem vindo!");
                Console.WriteLine();
                Console.WriteLine("Selecione a operação que deseja realizar:");
                Console.WriteLine();
                Console.WriteLine("1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Potenciação\n6- Radiciação\n7- Fatorial\n8- Porcentagem");
                Console.WriteLine();
                int choice = Convert.ToInt32(Console.ReadLine());

                double result = 0;
                
                if (choice == 1)
                {
                    Console.WriteLine("Escreva o primeiro Número:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o segundo Número:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    result = num1 + num2;
                    Console.WriteLine("O resultado é: " + result);
                }

                if (choice == 2)
                {
                    Console.WriteLine("Escreva o primeiro Número:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o segundo Número:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    result = num1 - num2;
                    Console.WriteLine("O resultado é: " + result);
                }

                if (choice == 3)
                {
                    Console.WriteLine("Escreva o primeiro Número:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o segundo Número:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    result = num1 * num2;
                    Console.WriteLine("O resultado é: " + result);
                }

                if (choice == 4)
                {
                    Console.WriteLine("Escreva o primeiro Número:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o segundo Número:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    result = num1 / num2;
                    Console.WriteLine("O resultado é: " + result);
                }

                if (choice == 5)
                {
                    Console.WriteLine("Escreva o primeiro Número:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o segundo Número:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    result = Math.Pow(num1, num2);
                    Console.WriteLine("O resultado é: " + result);
                }

                if (choice == 6)
                {
                    Console.WriteLine("Escreva o primeiro Número:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o segundo Número:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    result = Math.Pow(num1, 1.0 / num2);
                    Console.WriteLine("O resultado é: " + result);
                }

                if (choice == 7) 
                {
                    Console.WriteLine("Escreva o Número:");
                    double num1 = Convert.ToInt32(Console.ReadLine());

                   
                    if (num1 < 0)
                    {
                        Console.WriteLine("Fatorial não é definido para números negativos.");
                    }
                    else
                    {
                        long fatorial = 1;
                        int i = 1;

                      
                        while (i <= num1)
                        {
                            fatorial *= i;  
                            i++; 
                        }
                        result = fatorial;
                        Console.WriteLine();
                        Console.WriteLine("O resultado é: " + result);
                    }
                }

                if (choice == 8)
                {
                    Console.WriteLine("Escreva o número que deseja saber a porcentagem:");
                    Console.WriteLine();
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva o valor da porcentagem:");
                    Console.WriteLine();
                    double num2 = Convert.ToInt32(Console.ReadLine());

                    result = num1 * num2/100;
                    Console.WriteLine();
                    Console.WriteLine("O resultado é: " + result);
                }

                Console.WriteLine("Deseja realizar outra operação? " + "OBS: digite sim ou não");
                Console.WriteLine();
                string finalchoice = Console.ReadLine().ToLower();
                if (finalchoice == "sim")
                {
                    calcloop = true;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Obrigado por utilizar.  by Ian Gabriel");
                    Console.WriteLine();
                    Console.WriteLine("Encerrando o programa");
                    Thread.Sleep(2000);
                    calcloop = false;

                }

            }

        }
    }
}
