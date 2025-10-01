using ContaCorrenteC_.Models;

Pessoa pessoa = new Pessoa();

pessoa.CadastrarPessoa(nome: "João Silva", cpf: "123.456.789-00", dataNascimento: new DateTime(1990, 5, 15), status: true, numeroConta: 004, saldoInicial: 1500);
pessoa.Depositar(1000);
pessoa.Sacar(200);
pessoa.ExibirSaldo();
pessoa.ExibirContaCorrente();