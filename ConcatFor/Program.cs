﻿int qtdLetras = 0;

Console.WriteLine($"Olá usuário, quantas letras tem o seu nome :");
qtdLetras = int.Parse(Console.ReadLine());//guarda o numero na variavel
string nome = "";

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra:");
    nome += Console.ReadLine();
}

Console.WriteLine($"Seu nome é: {nome}";