using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        #region
        //Funcionario pedro = new("123456789-00", 2000);
        //pedro.Nome = "Pedro Souzas";

        //Console.WriteLine($"Bonificação do {pedro.Nome} é {pedro.GetBonificacao()}");

        //Diretor roberta = new("123456789-00");
        //roberta.Nome = "Roberta Silas";

        //Console.WriteLine($"Bonificação do {roberta.Nome} é {roberta.GetBonificacao()}");

        //GerenciadorBonificacao gerenciador = new();

        //gerenciador.Registrar(pedro);
        //gerenciador.Registrar(roberta);

        //Console.WriteLine($"Total da bonificações: {gerenciador.TotalBonificacao}");

        //Console.WriteLine($"Total de funcionarios: {Funcionario.TotalFuncionarios}");

        //pedro.AumentarSalario();
        //roberta.AumentarSalario();

        //Console.WriteLine($"Salario da roberta: {roberta.Salario}");
        //Console.WriteLine($"Salario do pedro: {pedro.Salario}");
        #endregion

        CalcularBonificacao();

        void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer ulisses = new Designer("123456");
            ulisses.Nome = "Ulisses Souza";

            Diretor paula = new Diretor("123456");
            paula.Nome = "Paula Souza";

            Auxiliar igor = new Auxiliar("123456");
            igor.Nome = "Igor Dias";

            GerenteDeContas camila = new GerenteDeContas("123654");
            camila.Nome = "Camila Oliveira";

            gerenciador.Registrar(camila);
            gerenciador.Registrar(ulisses);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(paula);

            Console.WriteLine($"Total das bonificações: {gerenciador.TotalBonificacao}");
        }
    }
}