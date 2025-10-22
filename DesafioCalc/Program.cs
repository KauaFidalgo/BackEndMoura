//Pedir para o usuario digitar dois numeros e exbir a soma desses dois numeros
int numero1, numero2;

Console.WriteLine($"Digite o primeiro número:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número:");
numero2 = int.Parse(Console.ReadLine());


int soma = numero1 + numero2;
Console.WriteLine($"A soma de {numero1} + {numero2} é {soma}");