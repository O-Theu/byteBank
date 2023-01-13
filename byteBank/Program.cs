using byteBank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "Andre Silva";
contaAndre.numeroAgencia = 15;
contaAndre.conta = "1010-x";
contaAndre.saldo = 100;

contaAndre.Depositar(250);

Console.WriteLine(contaAndre.saldo);