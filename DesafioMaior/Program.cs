int numero1, numero2;

Console.WriteLine($"Digite o primeiro número:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número:");
numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"O primeiro número é o maior: {numero1}");

}
else
{
    Console.WriteLine($"O segundo número é o maior: {numero2}");
}