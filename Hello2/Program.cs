//Pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario, e quanto investiu esse ano

//Camel Case - Letra maiúscula a partir da segunda palavra
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

//Pasca Case - primeira letra de cada palavra sempre maiúscula
Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é seu idade?");
idade = int.Parse( Console.ReadLine() );//converte o texto em int antes de jogar na variável

Console.WriteLine("Qual é o seu saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine()); //converte o texto digitado no console em float

Console.WriteLine("Qual é o investimento para este ano?");
investimentos = float.Parse(Console.ReadLine());


//Receber o investimento do usuário

Console.Clear();//limpa o console
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo Bancario: {saldoBancario}");
Console.WriteLine($"Investimento este ano: {investimentos}");