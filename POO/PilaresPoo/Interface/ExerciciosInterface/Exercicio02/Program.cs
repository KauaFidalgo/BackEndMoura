using Exercicio02;

// criar uma lista para faturas
List<IImprimivel> documentos = new List<IImprimivel>();


int opcao;

do
{
   Console.Clear();
   Console.WriteLine($@"Menu de Opções
   1) Cadastrar Fatura
   2) Cadastrar Relatório
   3) Cadastrar Contrato
   4) Listar Fatura
   5) Listar Relatório
   6) Listar Contrato
   0) Sair
   Escolha a opção:
   ");

   opcao = int.Parse(Console.ReadLine());

   //criar um swich case para as opções do menu

   switch (opcao)
   {
    case 1:
        Console.WriteLine($"Cadastrar Fatura em desenvolvimento");
        break;
    case 2:
        Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
        break;
    case 3:
        Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
        break;
    case 4:
        Console.WriteLine($"Listar Fatura em desenvolvimento");
        break;
    case 5:
        Console.WriteLine($"Listar Relatório em desenvolvimento");
        break;
    case 6:
        Console.WriteLine($"Listar Contrato em desenvolvimento");
        break;
    case 0:
        Console.WriteLine($"Sair");
        break;
    

    default:
        Console.WriteLine($"Opção Inválida!");
        break;
   }
   
   Console.WriteLine($"Pressione <Enter> para continuar");
   Console.ReadLine();
   

} while (opcao != 0);



void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o nome do Cliente Devedor");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o nome do Cliente Devedor");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);
    
    Console.WriteLine($"Voce acabou de cadastrar!");
    
}

void CadastrarRelatorio()
{
    
}

void CadastrarContrato()
{
    
}

void ListarFatura()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
    
}

void ListarRelatorio()
{
    
}

void ListarContrato()
{
    
}





















// Cria um objeto de casa classe e adiciona nas listas
// Fatura fatKaua = new Fatura();
// documentos.Add(fatKaua);
// Fatura fatAle = new Fatura();
// documentos.Add(fatAle);

// Relatorio relKaua = new Relatorio();
// documentos.Add(relKaua);
// Relatorio relAle = new Relatorio();
// documentos.Add(relAle);

// Contrato contKaua = new Contrato();
// documentos.Add(contKaua);
// Contrato contAle = new Contrato();
// documentos.Add(contAle);

// // Listar os dados da fatura

// Console.WriteLine($"Faturas:");
// foreach (var fat in documentos)
// {
//     if (fat is Fatura)
//     {
//         fatura.Imprimir();
//     }
    
// }

// Console.WriteLine($"Relatorios:");
// foreach (var rel in documentos)
// {
//     if (rel is Relatorio)
//     {
//         rel.Imprimir();
//     }
    
// }

// Console.WriteLine($"Contrato:");
// foreach (var cont in documentos)
// {
//     if (cont is Contrato)
//     {
//         cont.Imprimir(); 
//     }
   
// }
