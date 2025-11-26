using Encapsulamento;

// ContaBancaria contaFi = new ContaBancaria();

// contaFi.Depositar(-100);
// contaFi.Depositar(20);

// contaFi.Depositar(-100);
// contaFi.Depositar(20);
// contaFi.Sacar(-200);
// contaMaria.Sacar(300);

// Console.WriteLine();

// Console.WriteLine($"Saldo atual do Fidalgo: R${contaFi.GetSaldo}");
// Console.WriteLine($"Saldo atual do Maria: R${contaFi.GetSaldo}");

Carro c1 = new Carro();

c1.DefinirMarca("Toyota");
c1.DefinirModelo("Corolla");

Console.WriteLine($"Carro: {c1.ObterMarca()} - {c1.ObterModelo()}");
Console.WriteLine("Velocidade inicial: " + c1.ObterVelocidade());

c1.Acelerar(30);
Console.WriteLine("Acelerou para: " + c1.ObterVelocidade());

c1.Acelerar(20);
Console.WriteLine("Acelerou para: " + c1.ObterVelocidade());

c1.Frear(40);
Console.WriteLine("Freou para: " + c1.ObterVelocidade());

c1.Frear(20); // não pode ficar negativo
Console.WriteLine("Freou para: " + c1.ObterVelocidade());
