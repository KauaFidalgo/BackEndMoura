
namespace Construtores
{
    public class Produto
    {
        public string Nome;

        public double Preco;

        public int Estoque;

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}