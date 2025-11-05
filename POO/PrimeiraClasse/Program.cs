    using PrimeiraClasse;

// Console.WriteLine($"===== PROGRAMA PRIMEIRA CLASSE =====");

// //Carro mclaren = new Carro();
// //mclaren.marca = "McLaren";
// //mclaren.cor = "Laranja";
// //mclaren.modelo = "750s"
// //mclaren.potencia = 800;


// //Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}")
// //mclaren.Ligar();
// //Console.WriteLine($"Ligando a {mclaren.marca} de {mclaren.potencia} cv")
// //mclaren.Acelerar();


// //Pessoa fidalgo = new Pessoa();
// //fidalgo.Nome = "Fidalgo";
// //fidalgo.Idade = 16;
// //fidalgo.Altura = 1.75;
// //fidalgo.Falar();
// //fidalgo.Dormir();
// //Console.WriteLine($"O nome do cidadão é {fidalgo.Nome} e ele tem {fidalgo.Idade} anos.");

// Garrafa Tupperware = new Garrafa();
// Tupperware.Cor = "Azul";
// Tupperware.Capacidade = 2.0;
// Tupperware.Tamanho = 27;
// Tupperware.Formato = "Cilíndrica";

// Tupperware.Abrir();
// Console.WriteLine($"Abrindo a garrafa tupperware de cor {Tupperware.Cor} e capacidade de {Tupperware.Capacidade} litros."); 
// Tupperware.Fechar();
// Tupperware.Encher();

// Tupperware.Beber();
// Console.WriteLine($"Bebendo agua da garrafa tupperware de cor {Tupperware.Cor} e capacidade de {Tupperware.Capacidade} litros.");


Pessoa fidalgo = new Pessoa();
fidalgo.Nome = "Fidalgo";
fidalgo.Altura = 1.75;

Console.WriteLine($"O nome do cidadão é {fidalgo.Nome} e ele tem {fidalgo.Idade} anos.");
fidalgo.Envelhecer(10);
Console.WriteLine($"Após envelhecer, {fidalgo.Nome} agora tem {fidalgo.Idade} anos.");