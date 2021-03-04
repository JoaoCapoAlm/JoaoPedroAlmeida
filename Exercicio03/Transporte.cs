using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public abstract class Transporte
    {
        public Carga carga { get; set; }
        
        public Transporte(double valor, double peso)
        {
            carga = new Carga()
            {
                Valor = valor,
                Peso = peso,
            };
        }

        public abstract double CalculaFrete(int distancia);

    }
}
