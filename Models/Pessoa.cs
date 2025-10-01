using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteC_.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Status { get; set; }

        public ContaCorrente Conta { get; set; }

        public Pessoa(string nome, string cpf, DateTime dataNascimento, bool status, int numeroConta, decimal saldoInicial = 0)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Status = status;
            Conta = new ContaCorrente(numeroConta, saldoInicial);
        }

        public Pessoa() { }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Conta.Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Conta.Saldo)
            {
                Conta.Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Conta.Saldo:C}");
        }

        public void ExibirContaCorrente()
        {
            Console.WriteLine("=== Dados da Conta ===");
            Console.WriteLine($"Titular: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Número da Conta: {Conta.NumeroConta}");
            Console.WriteLine($"Saldo: {Conta.Saldo:C}");
            Console.WriteLine($"Status: {(Status ? "Ativo" : "Inativo")}");
            Console.WriteLine("=====================");
        }

        public void CadastrarPessoa(string nome, string cpf, DateTime dataNascimento, bool status, int numeroConta, decimal saldoInicial = 0)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Status = status;
            Conta = new ContaCorrente(numeroConta, saldoInicial);
        }
    }
}
