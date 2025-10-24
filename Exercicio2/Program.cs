Console.Write("Informe os gols do primeiro time: ");
        int golsTime1 = int.Parse(Console.ReadLine());

        Console.Write("Informe os gols do segundo time: ");
        int golsTime2 = int.Parse(Console.ReadLine());

        // Verificação e saída
        if (golsTime1 > golsTime2)
        {
            Console.WriteLine("Vitória do primeiro time!");
        }
        else if (golsTime2 > golsTime1)
        {
            Console.WriteLine("Vitória do segundo time!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }