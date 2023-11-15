using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Projeto
{
    public class Conta
    {
        public double SaldoCliente { get; protected set; }
        public double SaldoPrincipal { get; protected set; }
        public double Saidas { get; protected set; }
        public double Quantidade { get; protected set; }

        public bool AcrescentarCliente(double valor)
        {
            this.SaldoCliente += valor;
            return true;
        }

        public bool AcrescentarPrincipal(double valor)
        {
            this.SaldoPrincipal += valor;
            return true;
        }

        public bool AcrescentarSaidas(double valor)
        {
            this.Saidas += valor;
            return true;
        }


        public bool RetirarValor(double valor)
        {
            this.SaldoPrincipal -= valor;
            return true;
        }

        public bool ZerarConta(double valor)
        {
            this.SaldoCliente -= valor;
            return true;
        }
    }
}