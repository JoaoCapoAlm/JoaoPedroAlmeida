using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Exer01();
        }

        public static void Exer01 ()
        {
            try
            {
                decimal[] numbers = new decimal[5];
                decimal? larger = null;
                decimal? smaller = null;

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Escreva um número:");
                    var newInput = Console.ReadLine().Replace(".", ",");

                    if(!decimal.TryParse(newInput, out decimal number))
                        throw new Exception("Favor escrever apenas números!");

                    numbers[i] = number;
                    
                    if (larger == null && smaller == null)
                    {
                        larger = number;
                        smaller = number;
                    }
                    else if (number > larger)
                        larger = number;
                    else if (number < smaller)
                        smaller = number;
                }

                if (smaller == larger)
                    Console.WriteLine("Todos os números são iguais!");
                else
                {
                    Console.WriteLine($"O maior número é: {larger}");
                    Console.WriteLine($"O menor número é: {smaller}");
                }


            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Console.WriteLine("Aperte alguma tecla para sair!");
            Console.ReadLine();
        }
    }
}
