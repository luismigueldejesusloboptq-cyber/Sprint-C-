using estudo_sprint.entities;
using System;
using static estudo_sprint.entities.Poupanca;

namespace estudo_sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA BANCÁRIO ===\n");

            Console.WriteLine("Escolha o tipo da conta:");
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
            Console.WriteLine("3 - Conta Empresarial");

            int tipo = int.Parse(Console.ReadLine());

            Console.Write("\nNúmero da conta: ");
            string numero = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();

            Contabancaria conta = null;

            switch (tipo)
            {
                case 1:
                    conta = new ContaCorrente(numero, senha, titular);
                    break;

                case 2:
                    conta = new ContaouPanca(numero, senha, titular);
                    break;

                case 3:
                    Console.Write("Limite de empréstimo: ");
                    decimal limite = decimal.Parse(Console.ReadLine());
                    conta = new ContaEmpresarial(numero, senha, titular, limite);
                    break;

                default:
                    Console.WriteLine("Tipo inválido!");
                    return;
            }

            Console.WriteLine("\nConta criada com sucesso!");
            Console.WriteLine($"Titular: {conta.Pessoatitular}");
            Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
            Console.WriteLine($"Saldo: {conta.Saldo}");

            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Valor para depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        conta.Depositar(deposito);
                        Console.WriteLine("Depósito realizado!");
                        break;

                    case 2:
                        Console.Write("Valor para sacar: ");
                        decimal saque = decimal.Parse(Console.ReadLine());
                        conta.Sacar(saque);
                        Console.WriteLine("Saque realizado!");
                        break;

                    case 3:
                        Console.WriteLine($"Saldo atual: {conta.Saldo}");
                        break;

                    case 4:
                        Console.WriteLine("Encerrando sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
