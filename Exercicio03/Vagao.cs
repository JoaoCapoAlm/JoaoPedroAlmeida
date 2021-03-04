using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Vagao : Transporte
    {
        public Vagao(double valor, double peso) : base(valor, peso) {}

        public override double CalculaFrete(int distancia)
        {
            double valorFrete = (distancia * 0.5) + (carga.Valor / 0.01) + (carga.Peso / 0.07);

            if (carga.Peso < 15000)
                valorFrete += 5000;

            return valorFrete;
        }
    }
}
