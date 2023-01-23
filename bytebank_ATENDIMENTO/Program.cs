using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Array em C#
////int[] idades = new int[5];

////for(int i = 0;i < idades.Length; i++)
////{
////    idades[i] = i;
////    Console.WriteLine(idades[i]);
////}

//// código anterior omitido

//Array amostra = Array.CreateInstance(typeof(double), 5); //Igual a new double[5]
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

////[5,9][1,8][7,1][10][6,9]
//TestaMediana(amostra);

//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);
//    //[1,8][5,9][6,9][7,1][10]

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                                             (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//int[] valores = { 10, 58, 36, 47 };

//for(int i = 0;i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}


//void TestaArrayDeContasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

//    var contaDoAndre = new ContaCorrente(963, "12345-X");
//    listaDeContas.Adicionar(contaDoAndre); 
//    var contaDoJoao = new ContaCorrente(965, "45-X");
//    listaDeContas.Adicionar(contaDoJoao);

//    //listaDeContas.ExibeLista();
//    //listaDeContas.Remover(contaDoAndre);
//    //Console.WriteLine("-----------------------");
//    //listaDeContas.ExibeLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] -- {conta.Conta}/{conta.Numero_agencia}");
//    }
//}

//TestaArrayDeContasCorrentes();
#endregion 

ArrayList _listaDeContas = new ArrayList();

AtendimentoCliente();

void AtendimentoCliente()
{
	char opcao = '0';
	while (opcao != '6')
	{
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("=== 1 - Cadastrar Conta      ===");
        Console.WriteLine("=== 2 - Listar Contas        ===");
        Console.WriteLine("=== 3 - Remover Conta        ===");
        Console.WriteLine("=== 4 - Ordenar Contas       ===");
        Console.WriteLine("=== 5 - Pesquisar Conta      ===");
        Console.WriteLine("=== 6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];

        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarContas();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente conta in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + conta.Conta);
        Console.WriteLine("Saldo da Conta : " + conta.Saldo);
        Console.WriteLine("Titular da Conta: " + conta.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + conta.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + conta.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}