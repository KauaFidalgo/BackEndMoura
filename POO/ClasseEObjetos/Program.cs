//Garrafa Tupperware = new Garrafa();
//Tupperware.Cor = "Azul";
//Tupperware.Capacidade = 2.0;
//Tupperware.Tamanho = 27;
///Tupperware.Formato = "Cilíndrica";

//Tupperware.Abrir();
//Console.WriteLine($"Abrindo a garrafa tupperware de cor {Tupperware.Cor} e capacidade de {Tupperware.Capacidade} litros."); 
///Tupperware.Fechar();
//Tupperware.Encher();

//Tupperware.Beber();
//Console.WriteLine($"Bebendo agua da garrafa tupperware de cor {Tupperware.Cor} e capacidade de {Tupperware.Capacidade} litros.");

using ClasseEObjetos;

Console.Clear();
Console.WriteLine("=== Agência Bancária ===");
Console.WriteLine();

AgenciaBancaria contaDoJoao = new AgenciaBancaria();

contaDoJoao.Titular = "João Silva";
contaDoJoao.Saldo = 1000.0f;

contaDoJoao.Depositar(500.0f);
contaDoJoao.Sacar(1500.0f);