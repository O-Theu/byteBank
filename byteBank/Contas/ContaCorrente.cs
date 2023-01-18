using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using byteBank.Titular;

namespace byteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }

        private int numeroAgencia;
            
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set 
            {
                if (value < 0) return;

                this.numeroAgencia = value; 
            }
        }

        public string Conta { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            Sacar(valor);
            destino.Depositar(valor);
            return true;
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0) return;

            this.Saldo = valor;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.NumeroAgencia = numero_agencia;
            this.Conta = numero_conta;
            TotalContasCriadas++;
        }
    }
}
