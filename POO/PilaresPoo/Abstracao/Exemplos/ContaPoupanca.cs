public class ContaPoupanca : ContaBancaria
{
    // Conta poupança cobra taxa menor: 1 real
    public override void Sacar(double valor)
    {
        double taxa = 1.0;
        double total = valor + taxa;

        if (total <= Saldo)
        {
            Saldo -= total;
            Console.WriteLine("Saque realizado (com taxa de R$1). Novo saldo: " + Saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}
