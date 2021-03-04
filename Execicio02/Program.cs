using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva um valor:");
                var valor = Console.ReadLine();

                if (!double.TryParse(valor, out double valorParsed))
                    throw new Exception("Favor escrever apenas números!");


                var icms = new ICMS();
                var ipi = new IPI();
                var cofins = new COFINS();

                Console.WriteLine($"Será cobrado R${icms.PorcentImposto(valorParsed)} de ICMS");
                Console.WriteLine($"Será cobrado R${ipi.PorcentImposto(valorParsed)} de IPI");
                Console.WriteLine($"Será cobrado R${cofins.PorcentImposto(valorParsed)} de COFINS");

                double valorComImposto = valorParsed + icms.CalculaImposto(valorParsed) + ipi.CalculaImposto(valorParsed) + cofins.CalculaImposto(valorParsed);
                
                Console.WriteLine($"O valor final com os impostos será de {valorComImposto:C}");

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Aperte alguma tecla para sair!");
            Console.ReadLine();
        }
    }
}
