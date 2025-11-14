namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int QuantidadeDeMotores { get; set; }

        public Aviao(string marca, string modelo, int quantidadeDeMotores)
            : base(marca, modelo)
        {
            QuantidadeDeMotores = quantidadeDeMotores;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Avião - Marca: {Marca}, Modelo: {Modelo}, Motores: {QuantidadeDeMotores}");
        }
    }
}
