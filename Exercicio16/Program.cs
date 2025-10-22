//int idade;
//string nome;

//Console.WriteLine("Olá, qual é seu nome?");//escreve um texto no console
//nome = Console.ReadLine();

//Console.WriteLine("Olá, qual é sua idade");
//idade = int.Parse(Console.ReadLine());

//Console.WriteLine($"{nome}, obrigado por responder");

//if (idade >= 18)
//{
//Console.WriteLine("Você é MAIOR de idade");

//} else
//{
//Console.WriteLine("Você é menor de idade");
//}
string cargo;
float salario, salarioNovo = 0;

Console.WriteLine($"Digite o cargo do funcionario producao, administrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do funcionario");
salario = float.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065)
}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075)
}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12)
}

else
{
    Console.WriteLine($"Cargo invalido");
    return;
}

Console.WriteLine($"O novo salario reajustado e {salarioNovo}");