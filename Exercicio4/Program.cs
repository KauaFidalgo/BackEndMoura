 Console.Write("Digite a senha: ");
        int senha = int.Parse(Console.ReadLine());

        // Verificação da senha
        if (senha == 1234)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }