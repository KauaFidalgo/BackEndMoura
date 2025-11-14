using Exemplos;
Console.Clear();

// Gato birobinha =  new Gato();
// Cachorro toto = new Cachorro();

//Pessoa julio = new Pessoa();
//julio.Nome = "Julio Cesar";
//julio.Idade = 17;

//Console.WriteLine($"Nome: {julio.Nome}");
//Console.WriteLine($"Idade: {julio.Idade}");

//Console.WriteLine($"Som do {julio.Nome}");
//julio.FazerSom();
//Console.WriteLine($"{julio.Nome}");
//julio.Mover();

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(100);
cc.Sacar(50);

cp.Depositar(200);
cp.Sacar(50);