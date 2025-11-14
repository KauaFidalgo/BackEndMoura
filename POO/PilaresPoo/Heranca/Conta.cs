namespace Heranca
{
    public class Conta
    {
        public int Numero;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Conta nº " + Numero + " - Saldo: R$ " + Saldo);
        }
    }
}
