namespace Exemplos
{
    public class Carro : IMotor
    {

    //propriedade de implementar a interface IMotor
    public string Cor;
    public string Marca;
    public string Modelo;
    public int Ano;

    //construtores
    public Carro(string cor, string marca, string modelo, int ano)
    {
        Cor = cor;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    //metodos da interface IMotor

        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Informações do Carro:
             {Marca} 
             {Modelo} 
             ({Ano}) - Cor: {Cor}");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando... Vrum vrum!");
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro freiando... Chuuuu!");
        }
    }
}
