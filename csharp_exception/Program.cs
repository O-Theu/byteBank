using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

try
{
    ContaCorrente conta1 = new ContaCorrente(10, "1234-X");
    conta1.GetSaldo();
    conta1.Sacar(400);
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex.Message);
}

