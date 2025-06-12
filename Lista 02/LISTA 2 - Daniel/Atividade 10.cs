// 10. Mini Loja – Cálculo de Troco


float b;
float c;


Console.WriteLine("O valor que voce vai pagar é de 30 reais:");

Console.WriteLine("Pagamento em dinheiro:");

b = float.Parse(Console.ReadLine());

c = (b - 30);

Console.WriteLine("Seu troco: " +  c);