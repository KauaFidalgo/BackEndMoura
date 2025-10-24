int opcao;
do
{

Console.Clear();
Console.WriteLine($"-----------------------------------------");
Console.WriteLine($"             Bem Vindo                   ");
Console.WriteLine($"                ao                       ");
Console.WriteLine($"            Jacareca Food                ");
Console.WriteLine($"-----------------------------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Escolha uma opção abaixo");
Console.WriteLine();
Console.WriteLine($"    Hot Holl");
Console.WriteLine($"    Temaki");
Console.WriteLine($"    Sashimi");
Console.WriteLine($"    Yakisoba");
Console.WriteLine($"    Guioza");
Console.WriteLine($"    Shimeji");
Console.WriteLine();

opcao = int.Parse(Console.ReadLine());



    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <enter> para continuar...");
            break;
        case 1:
            Console.WriteLine($"Você escolheu Hot Holl, o valor é R$29,90 Vamos preparar seu pedido!");
            break;
        case 2:
            Console.WriteLine($"Você escolheu Temaki, o valor é R$30,00  Vamos preparar seu pedido!");
            break;
        case 3:
            Console.WriteLine($"Você escolheu Sashimi, o valor é R$67,20 Vamos preparar seu pedido!");
            break;
        case 4:
            Console.WriteLine($"Você escolheu Yakisoba, o valor é R$35,95 Vamos preparar seu pedido!");
            break;
        case 5:
            Console.WriteLine($"Você escolheu Guioza, o valor é R$49,00 Vamos preparar seu pedido!");
            break;
        case 6:
            Console.WriteLine($"Você escolheu Shimeji, o valor é R$50,90 Vamos preparar seu pedido!🙃");
            break;
        case 7:
            Console.WriteLine($"Saindo...");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != 0);   