usign ExercicioPolimorfismo;


PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;
float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Julio Boneco inflável");
Console.WriteLine($"Preço: {compraPix.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Cartão");
Console.WriteLine($"Pagamento com desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Julio Boneco inflável");
Console.WriteLine($"Preço: {compraPix.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Cartão");
Console.WriteLine($"Pagamento com desconto: {compraCartao.CalcularTotal()}");