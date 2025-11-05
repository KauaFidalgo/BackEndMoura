using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Pessoa
    {

        public string Nome;
        public int Idade;
        public double Altura;

        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha altura é {Altura} metros.");
        }

        public void Dormir()
        {
            Console.WriteLine($"zzzzzzzzzzzzzzzzz");
        }

        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                Idade += _id;
            }
            else
            {
                Idade++;
            }
        }
    }
}