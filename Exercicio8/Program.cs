        int opcao; // variável usada no menu

        do
        {
            
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("        Bem Vindo, Usuário");
            Console.WriteLine("-------------------------------------------------------\n");

            Console.WriteLine("Escolha uma opção no menu abaixo:\n");
            Console.WriteLine("   1) Opção 1");
            Console.WriteLine("   2) Opção 2");
            Console.WriteLine("   3) Opção 3");
            Console.WriteLine("   0) Sair\n");

            // Lê a opção digitada
            Console.WriteLine("Digite sua opção: ");
            opcao = int.Parse(Console.ReadLine());

           
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu a Opção 1.\n");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a Opção 2.\n");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a Opção 3.\n");
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...\n");
                    break;
                default:
                    Console.WriteLine("Opção Inválida!\n");
                    break;
            }

        } while (opcao != 0); // repete enquanto o usuário não escolher 0

        Console.WriteLine("Programa finalizado.");