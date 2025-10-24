// Entrada de dados
        Console.Write("Informe o salário recebido: ");
        double salario = double.Parse(Console.ReadLine());//para permitir os valores decimais

        Console.Write("Informe o total gasto: ");
        double gastos = double.Parse(Console.ReadLine());

        // Verificação e saída
        if (gastos <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento");
        }
        else
        {
            Console.WriteLine("Orçamento estourado");
        }