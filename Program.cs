using System;

Console.WriteLine("POO - Conta");

string[] opcao = ["(D)", "(S)"];

Conta conta = new Conta();

Console.WriteLine(conta.Saldo);
Console.WriteLine(conta.Limite);

Console.WriteLine("Olá bem vindo ao banco do Nicolau poderia informar seu saldo?");
float saldoDigitado = float.Parse(Console.ReadLine());
conta.Saldo = saldoDigitado + conta.Saldo;

string continuar;
float valor;

etq1:
Console.WriteLine($"\nEscolha uma opção\n\n{opcao[0]} Deposito.\n{opcao[1]} Saque.\n");
string escolha = Console.ReadLine();

switch (escolha.ToUpper())
{
    case "D":
        Console.WriteLine("\nVocê escolheu fazer um depósito.");
        Console.WriteLine($"\nSeu saldo é de: R${conta.Saldo.ToString("c")}\n Qual a Quantia do Depósito?");
        valor = float.Parse(Console.ReadLine());
        conta.Depositar(valor);
        Console.WriteLine($"\nSeu saldo é de: R${conta.Saldo.ToString("c")}\n é voce depositou {valor.ToString("c")} (Descontamos uma tarifa)");
        Console.WriteLine($"\nQuer continuar?\n(1)Sim\n(2)Não\n");
        continuar = Console.ReadLine();
        if(continuar == "1")
        {
            goto etq1;
        }
        break;
    case "S":
        Console.WriteLine("\nVocê escolheu fazer um saque.");
    etq2:
        Console.WriteLine($"\nSeu saldo é de: R${conta.Saldo.ToString("c")}\n Qual a Quantia do Saque?");
        valor = float.Parse(Console.ReadLine());
        if (valor >= conta.Limite)
        {
            Console.WriteLine($"\nO Seu limite foi atingido.");
            goto etq2;
        }
        else
        {
            conta.Sacar(valor); Console.WriteLine($"\nSeu saldo é de: {conta.Saldo.ToString("c")}\n é voce Sacou {valor.ToString("c")} (Descontamos uma tarifa)");
        }
        Console.WriteLine($"\nQuer continuar?\n(1)Sim\n(2)Não\n");
        continuar = Console.ReadLine();
        if(continuar == "1")
        {
            goto etq1;
        }
        break;
    default:
        Console.WriteLine("Opção inválida.");
        goto etq1;
}

Console.WriteLine("...Pressione qualquer tecla para encerrar.");

Console.ReadKey();