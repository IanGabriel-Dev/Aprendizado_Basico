using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversordemedidas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = Environment.UserName;
            Console.Write("Seja Bem Vindo "); Console.Write(usuario);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione uma conversão:");
            Console.WriteLine("1 - MM para CM");
            Console.WriteLine("2 - CM para M");
            Console.WriteLine("3 - M para KM");

            Console.WriteLine();

            string escolha = Console.ReadLine();

            Console.WriteLine("Escreva o primeiro valor: ");
            double val = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (escolha)
            {

                case "1":
                    resultado = val / 10;
                    Console.WriteLine("Resultado da conversão: " + resultado);
                    break;

                case "2":
                    resultado = val / 100;
                    Console.WriteLine("Resultado da conversão: " + resultado);
                    break;

                case "3":
                    resultado = val / 1000;
                    Console.WriteLine("Resultado da conversão: " + resultado);
                    break;
            }

            Console.WriteLine("Obrigado por utilizar.  by Ian Gabriel");
        }
    }
}
