# 💳 Conta Corrente em C#

Um projeto simples em **C# .NET** que simula o cadastro de uma pessoa com conta corrente e permite realizar operações bancárias básicas.

---

## 🚀 Como Executar

Clone este repositório:

```bash
git clone https://github.com/seu-usuario/ContaCorrenteCSharp.git
cd ContaCorrenteCSharp
```

Compile e execute o projeto:

```bash
dotnet run
```

---

## 📖 Fluxo do Programa

1. O usuário deve cadastrar uma **Pessoa** informando:
   - **Nome** (não pode ser vazio)
   - **CPF** (não pode ser vazio)
   - **Data de nascimento** (validada no formato `dd/MM/yyyy`)
   - **Status** (1 = Ativo, 2 = Inativo)
   - **Número da conta** (inteiro)
   - **Saldo inicial** (decimal)

2. Após o cadastro, o sistema exibe um **menu interativo** com as opções:

```text
=== Menu ===
1. Depositar
2. Sacar
3. Exibir Saldo
4. Exibir Dados da Conta
5. Sair
```

3. O usuário pode realizar operações até escolher a opção **Sair**.

---

## 💻 Exemplo de Uso

```yaml
=== Cadastro de Pessoa ===
Nome: João Silva
CPF: 123.456.789-00
Data de Nascimento (dd/MM/yyyy): 15/05/1990
Status:
  Digite 1 para ativo e 2 para inativo
Digite: 1
Número da Conta: 1001
Saldo Inicial: 1500

=== Menu ===
1. Depositar
2. Sacar
3. Exibir Saldo
4. Exibir Dados da Conta
5. Sair
```

---

## 📜 Licença

Este projeto é apenas para fins **educacionais** e não possui licença comercial.

---
