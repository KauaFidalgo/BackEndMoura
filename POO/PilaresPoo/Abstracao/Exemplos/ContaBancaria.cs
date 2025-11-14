public abstract class ContaBancaria
{
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depósito realizado. Novo saldo: " + Saldo);
    }

    // Método abstrato → cada tipo de conta vai ter sua própria forma de sacar
    public abstract void Sacar(double valor);
}
