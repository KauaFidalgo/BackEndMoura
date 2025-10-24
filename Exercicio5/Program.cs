        Console.Write("Informe o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco;

        
        if (quantidade < 12)
        {
            preco = 0.30;
        }
        else
        {
            preco = 0.25;
        }

        
        double total = quantidade * preco;

        
        Console.WriteLine($"Valor total da compra: R$ {total:F2}");
