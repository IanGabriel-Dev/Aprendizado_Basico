
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversordemedidas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string usuario = Environment.UserName;
            Boolean loopconver = true;

            while (loopconver = true)
            {
             Console.Clear();

             Console.WriteLine("Olá " + usuario + " Seja bem vindo");
             Console.WriteLine();
             Console.WriteLine("Escreva a unidade que deseja converter " + "EX:mm, cm, m, km");
             Console.WriteLine();
             string firstchoice = Console.ReadLine();
             Console.WriteLine();
             Console.WriteLine("Escreva o valor da medida: ");
             Console.WriteLine();
             double firstvalue = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine();
             Console.WriteLine("Escreva para qual unidade deseja converter " + "EX:mm, cm, m, km");
             Console.WriteLine();
             string secondchoice = Console.ReadLine();
                Console.WriteLine();
               
                double result = 0;

                if (firstchoice == "mm")
                {
                    switch (secondchoice)
                    {
                        case "mm":
                            result = firstvalue;
                            Console.WriteLine("Resultado da conversão: " + result);
                        break;

                        case "cm":
                            result = firstvalue / 10;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "m":
                            result = firstvalue / 100;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "km":
                            result = firstvalue / 1000;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Obrigado por utilizar.  by Ian Gabriel");
                Console.WriteLine();
                Console.WriteLine("Deseja realizar oura conversão? " + "Para responder, digite: sim ou não");

                string finalchoice = Console.ReadLine();

                if (finalchoice == "sim")
                {
                    loopconver = true;
                }
                else
                {
                    loopconver = false;
                }

                if ( firstchoice == "cm")
                {
                    switch (secondchoice)
                    {
                        case "mm":
                            result = firstvalue * 10;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "cm":
                            result = firstvalue;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "m":
                            result = firstvalue / 100;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "km":
                            result = firstvalue / 1000;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;
                    }
                }


                if (firstchoice == "m")
                {
                    switch (secondchoice)
                    {
                        case "mm":
                            result = firstvalue * 100;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "cm":
                            result = firstvalue / 100;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "m":
                            result = firstvalue;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "km":
                            result = firstvalue / 1000;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;
                    }
                }

                if (firstchoice == "km")
                {
                    switch (secondchoice)
                    {
                        case "mm":
                            result = firstvalue * 1000000;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "cm":
                            result = firstvalue * 100000;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "m":
                            result = firstvalue * 1000;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;

                        case "km":
                            result = firstvalue;
                            Console.WriteLine("Resultado da conversão: " + result);
                            break;
                    }
                }

            }
        }
    }
}
