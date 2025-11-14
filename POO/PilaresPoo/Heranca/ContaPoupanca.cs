namespace Heranca
{
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            double rendimento = Saldo * 0.02; // 2% de rendimento
            Saldo = Saldo + rendimento;
        }
    }
}
