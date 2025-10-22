//Faça um programa que pergunte para o usuário a quantidade de números que ele
//quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
//se for PAR. Utilize a estrutura WHILE.

Console.WriteLine("Quantos números você deseja digitar?");
int quantidade = int.Parse(Console.ReadLine());

int contador = 0;

while (contador < quantidade)
{
    Console.WriteLine($"\nDigite o {contador + 1}º número:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é PAR!");
    }

    contador++;
}

Console.WriteLine("\nFim do programa!");