using byteBank.Contas;
using byteBank.Titular;

//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = ;
//contaAndre.numeroAgencia = 15;
//contaAndre.conta = "1010-x";
//contaAndre.saldo = 100;


//contaAndre.Depositar(250);

//Console.WriteLine($"Saldo da conta do andre {contaAndre.saldo}");

//if (contaAndre.Sacar(20)) Console.WriteLine($"Saldo da conta do andre {contaAndre.saldo}");

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.numeroAgencia = 17;
//contaMaria.conta = "1005-x";
//contaMaria.saldo = 350;

//Console.WriteLine($"Saldo da conta da maria {contaMaria.saldo}");

//contaAndre.Transferir(50, contaMaria);

//Console.WriteLine($"Saldo da conta da maria {contaMaria.saldo}");

//Console.WriteLine($"Saldo da conta do andre {contaAndre.saldo}");

//Cliente cliente = new Cliente();

//cliente.Nome = "Mateus Conceição";
//cliente.Cpf = "123456789-00";
//cliente.Profissao = "Dev";

//ContaCorrente conta = new ContaCorrente();
//conta.Titular = cliente;
//conta.Conta = "1010-x";
//conta.NumeroAgencia = 15;
//conta.SetSaldo(100);

//Console.WriteLine($"Titular: {conta.Titular.Nome}");
//Console.WriteLine($"Saldo: {conta.GetSaldo()}");

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.NumeroAgencia);

ContaCorrente conta5 = new ContaCorrente(18, "1010-X");
Console.WriteLine(ContaCorrente.TotalContasCriadas);

ContaCorrente conta6 = new ContaCorrente(20, "1010-X");
Console.WriteLine(ContaCorrente.TotalContasCriadas);

