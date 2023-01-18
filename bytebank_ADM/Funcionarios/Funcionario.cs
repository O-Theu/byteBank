using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; private set; }
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;

            TotalFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }

        public void AumentarSalario()
        {
            this.Salario += (this.Salario * 0.1);
        }
    }
}
