using ExercicioBancoApp;
using System.Drawing;

Conta x;

Console.Write("Entre o número da conta:");
int numeroConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta:");
string titular = Console.ReadLine();

Console.Write("Haverá um depósito inicial (s/n)?");
string opcao = Console.ReadLine();

if (opcao == "s")
{
    Console.Write("Entre o valor de depósito inicial:");
    double valor = int.Parse(Console.ReadLine());

    x = new Conta(numeroConta, titular, valor);
    Console.WriteLine(x);

    Console.Write("Entre um valor para depósito: ");
    double deposito = double.Parse(Console.ReadLine());
    x.Deposito(deposito);
    Console.WriteLine("Dados da conta atualizados:");
    Console.WriteLine(x);

    Console.Write("Entre um valor para saque: ");
    double saque = double.Parse(Console.ReadLine());
    x.Saque(saque);
    Console.WriteLine("Dados da conta atualizados:");
    Console.WriteLine(x);
}
else if (opcao == "n")
{
    x = new Conta(numeroConta, titular);
    Console.WriteLine(x);

    Console.Write("Entre um valor para depósito: ");
    double deposito = double.Parse(Console.ReadLine());
    x.Deposito(deposito);

    Console.WriteLine("Dados da conta atualizados:");
    Console.WriteLine(x);

    Console.Write("Entre um valor para saque: ");
    double saque = double.Parse(Console.ReadLine());
    x.Saque(saque);

    Console.WriteLine("Dados da conta atualizados:");
    Console.WriteLine(x);
}

