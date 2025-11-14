using Exercicio02;

Funcionario funcionario = new Funcionario("João", 3000);
Gerente gerente = new Gerente("Maria", 5000, 2000);

Console.WriteLine($"{funcionario.Nome} - Salário: R$ {funcionario.CalcularSalario()}");
Console.WriteLine($"{gerente.Nome} - Salário: R$ {gerente.CalcularSalario()}");

Console.ReadLine();