namespace Construtores
{
    public class Carro
    {
        // Atributos
        string marca;
        string modelo;
        int ano;

        // Construtor
        public Carro(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;

            Console.WriteLine("=== Dados do Carro ===");
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + ano);
        }
    }

    // Classe principal para testar
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Toyota", "Corolla", 2022);
        }
    }
}