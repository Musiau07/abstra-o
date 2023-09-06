using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_9
{
    class ContaBancaria
    {
        public string NomeTitular;
        public string nConta;
        public string nAgencia;
        public string nomeBanco;

        private double saldo;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public void Sacar(double valorSq)
        {
            if (valorSq > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente na sua conta bancária");
                Console.ReadKey();
            }
            else if (valorSq < Saldo || valorSq == Saldo)
            {
                double calcularValorSaldo = Saldo - valorSq;
                Console.WriteLine("O valor do saque efetuado foi de " + valorSq);
                Console.WriteLine("Então o valor de seu novo saldo ficou " + calcularValorSaldo);
                Console.ReadKey();
            }
        }
        public void Depositar(double valorDp)
        {
            this.saldo = valorDp;
        }
    }


}
}
