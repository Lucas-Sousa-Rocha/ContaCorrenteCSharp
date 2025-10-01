using ContaCorrenteC_.Models;
using System;

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();

        Console.WriteLine("=== Cadastro de Pessoa ===");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.Write("Nome não pode ser vazio. Digite novamente: ");
            nome = Console.ReadLine();
        }

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(cpf))
        {
            Console.Write("CPF não pode ser vazio. Digite novamente: ");
            cpf = Console.ReadLine();
        }

        Console.Write("Data de Nascimento (dd/MM/yyyy): ");
        DateTime dataNascimento;
        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.Write("Data inválida. Digite novamente (dd/MM/yyyy): ");
        }

        Console.Write("Status:");
        Console.Write("\n  Digite 1 para ativo e 2 para inativo");
        Console.Write("\n Digite:");
        int codStatus = int.Parse(Console.ReadLine());
        bool status;
        while(codStatus != 1 && codStatus != 2)
        {
            Console.Write("Código inválido. Digite 1 para ativo e 2 para inativo: ");
            codStatus = int.Parse(Console.ReadLine());
        }
        status = (codStatus == 1) ? true : false;

        Console.Write("Número da Conta: ");
        int numeroConta;
        while (!int.TryParse(Console.ReadLine(), out numeroConta))
        {
            Console.Write("Número inválido. Digite novamente: ");
        }

        Console.Write("Saldo Inicial: ");
        decimal saldoInicial;
        while (!decimal.TryParse(Console.ReadLine(), out saldoInicial))
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        // Cadastrar pessoa com os dados fornecidos
        pessoa.CadastrarPessoa(nome, cpf, dataNascimento, status, numeroConta, saldoInicial);

        // ===== Menu de Operações =====
        bool menuAtivo = true;

        while (menuAtivo)
        {
            Console.WriteLine("\n=== Menu ===");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Exibir Saldo");
            Console.WriteLine("4. Exibir Dados da Conta");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o valor para depósito: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
                        pessoa.Depositar(valorDeposito);
                    else
                        Console.WriteLine("Valor inválido.");
                    break;

                case "2":
                    Console.Write("Digite o valor para saque: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
                        pessoa.Sacar(valorSaque);
                    else
                        Console.WriteLine("Valor inválido.");
                    break;

                case "3":
                    pessoa.ExibirSaldo();
                    break;

                case "4":
                    pessoa.ExibirContaCorrente();
                    break;

                case "5":
                    menuAtivo = false;
                    Console.WriteLine("Saindo do sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
