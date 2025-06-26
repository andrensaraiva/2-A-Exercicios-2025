int doce1 = 0;
int doce2 = 0;
int doce3 = 0;
float preçoChoco = 0.0f;
float preçoChic = 0.0f;
float preçoBala = 0.0f;
float TotalCompra = 0.0f;

Console.WriteLine("Quantos chocolates, chicletes e balas você quer comprar na nossa doceria?");
Console.WriteLine("Quantos chocolates?");

doce1 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos chicletes?");

doce2 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas balas?");

doce3 = int.Parse(Console.ReadLine());

preçoChoco = 5.00f * doce1;
preçoChic = 2.00f * doce2;
preçoBala = 0.50f * doce3;

TotalCompra = preçoChoco + preçoChic + preçoBala;

Console.WriteLine("O preço de todos os chocolates foi" + preçoChoco + ", o dos chicletes foi" + preçoChic + ", e o das balas foi" + preçoBala + ".");
Console.WriteLine("No total, deu" + TotalCompra + "Crédito, Débito, pix, picpay ou dinheiro parça?");






