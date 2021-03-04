using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    interface IImposto
    {
        double CalculaImposto(double valor);
        double PorcentImposto(double valor);
    }

    public class ICMS : IImposto
    {
        public double PorcentImposto(double valor)
        {
            return 27;
        }
        public double CalculaImposto(double valor)
        {
            return valor * (PorcentImposto(valor) / 100);
        }
    }

    public class IPI : IImposto
    {
        public double PorcentImposto(double valor)
        {
            if (valor < 20000)
                return 7;

            return 19;
        }

        public double CalculaImposto(double valor)
        {
            return valor * (PorcentImposto(valor) / 100);
        }
    }

    public class COFINS : IImposto
    {
        public double PorcentImposto(double valor)
        {
            if (valor > 12000)
                return 4;
            
            return 0;
        }
        public double CalculaImposto(double valor)
        {
            return valor * (PorcentImposto(valor) / 100);
        }
    }
}
