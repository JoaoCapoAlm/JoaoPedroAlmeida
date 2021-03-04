using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Caminhao :Transporte
    {
        public Caminhao(double valor, double peso) : base(valor, peso) { }

        public override double CalculaFrete(int distancia)
        {
            double valorFrete = (distancia * 2) + (carga.Valor / 0.03) + (carga.Peso / 0.02);

            if (carga.Valor > 40000)
                valorFrete -= valorFrete * 0.25;

            return valorFrete;
        }
    }
}
