using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaBancaria
{
    public class ContaBancaria
    {

    // Atributos da conta
    public string Titular;
    public double Saldo;

    // Método para depositar um valor
    public void Depositar(double valor)
    {
        Saldo += valor; // aumenta o saldo
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}\n");
    }

    // Método para sacar um valor
    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor; // diminui o saldo
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque!");
        }

        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}\n");
    }
}

class Program
{
    static void Main()
    {
        // Cria um objeto da classe ContaBancaria
        ContaBancaria conta = new ContaBancaria();

        // Define o titular e o saldo inicial
        conta.Titular = "Kauã";
        conta.Saldo = 0;

        Console.WriteLine($"Titular: {conta.Titular}");
        Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}\n");

        // Realiza operações
        conta.Depositar(500);  // aumenta o saldo
        conta.Sacar(200);      // diminui o saldo
        conta.Sacar(400);      // tentativa com saldo insuficiente
    }
}


    }
