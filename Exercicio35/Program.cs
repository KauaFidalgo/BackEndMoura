int repeticoes, num2, num1;
int i = 0;

Console.WriteLine("Insira um numero de repeticoes");
repeticoes = int.Parse(Console.ReadLine());

while (i < repeticoes)
{
    Console.WriteLine("Insira um numero");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo numero");
    num2 = int.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine($"o numero {num1} e maior que o {num2}");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"o numero {num2} e maior que o {num1}");
    }
    else
    {
        Console.WriteLine("Eles são iguais");
    }
    


    i++;
}


Console.WriteLine("Numero de repeticoes excedidas");
