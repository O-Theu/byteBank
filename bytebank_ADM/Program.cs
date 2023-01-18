using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario pedro = new("123456789-00", 2000);
        pedro.Nome = "Pedro Souzas";

        Console.WriteLine($"Bonificação do {pedro.Nome} é {pedro.GetBonificacao()}");

        Diretor roberta = new("123456789-00", 5000);
        roberta.Nome = "Roberta Silas";

        Console.WriteLine($"Bonificação do {roberta.Nome} é {roberta.GetBonificacao()}");

        GerenciadorBonificacao gerenciador = new();

        gerenciador.Registrar(pedro);
        gerenciador.Registrar(roberta);

        Console.WriteLine($"Total da bonificações: {gerenciador.TotalBonificacao}");
        
        Console.WriteLine($"Total de funcionarios: {Funcionario.TotalFuncionarios}");

        pedro.AumentarSalario();
        roberta.AumentarSalario();

        Console.WriteLine($"Salario da roberta: {roberta.Salario}");
        Console.WriteLine($"Salario do pedro: {pedro.Salario}");

    }
}