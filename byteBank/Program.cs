using byteBank;

ContaCorrente contaAndre = new ContaCorrente();    
contaAndre.titular = "Andre Silva";
contaAndre.numeroAgencia = 15;
contaAndre.conta = "1010-x";
contaAndre.saldo = 100;

contaAndre.Depositar(250);

Console.WriteLine($"Saldo da conta do andre {contaAndre.saldo}");

if (contaAndre.Sacar(20)) Console.WriteLine($"Saldo da conta do andre {contaAndre.saldo}");

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numeroAgencia = 17;
contaMaria.conta = "1005-x";
contaMaria.saldo = 350;

Console.WriteLine($"Saldo da conta da maria {contaMaria.saldo}");

contaAndre.Transferir(50, contaMaria);

Console.WriteLine($"Saldo da conta da maria {contaMaria.saldo}");

Console.WriteLine($"Saldo da conta do andre {contaAndre.saldo}");


