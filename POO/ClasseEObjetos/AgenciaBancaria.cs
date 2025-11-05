using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular;

        public float Saldo;

        public void Depositar(float valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
            Console.WriteLine($"Saldo atual: {Saldo:F2}");
        }

        public void Sacar(float valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado com sucesso!");
            Console.WriteLine($"Saldo atual: {Saldo:F2}");
            return;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }
    }
}