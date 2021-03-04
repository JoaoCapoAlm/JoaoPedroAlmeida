using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva o peso da carga:");
                var peso = Console.ReadLine();

                if (!double.TryParse(peso, out double pesoParsed))
                    throw new Exception("Digite apenas números!");

                Console.WriteLine("Escreva o valor da carga:");
                var valor = Console.ReadLine();

                if (!double.TryParse(valor, out double valorParsed))
                    throw new Exception("Digite apenas números!");

                var caminhao = new Caminhao(valorParsed, pesoParsed);
                var vagao = new Vagao(valorParsed, pesoParsed);

                Console.WriteLine("Escreva a distancia em km:");
                var distancia = Console.ReadLine();

                if (!int.TryParse(distancia, out int distanciaParsed))
                    throw new Exception("Digite apenas números!");

                var freteCaminhao = caminhao.CalculaFrete(distanciaParsed);
                var freteVagao = vagao.CalculaFrete(distanciaParsed);

                Console.WriteLine($"Valor do frete para o caminão: {freteCaminhao:c}");
                Console.WriteLine($"Valor do frete para o vagão: {freteVagao:c}");

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Aperte alguma tecla para sair!");
            Console.ReadLine();
        }
    }
}
