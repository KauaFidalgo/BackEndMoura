public class ContaCorrente : ContaBancaria
{
    public override void Sacar(double valor)
    {
        double taxa = 5.0;
        double total = valor + taxa;

        if (total <= Saldo)
        {
            Saldo -= total;
            Console.WriteLine("Saque realizado (com taxa de R$5). Novo saldo: " + Saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}d