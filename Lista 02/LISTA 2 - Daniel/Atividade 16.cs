// 16. Máquina de Doces Simulada

int chocolate;
int bala;
int chiclete;

Console.WriteLine("Quantos de cada doce voce quer? (Chocolate, Bala, Chiclete)");
chocolate = int.Parse(Console.ReadLine());
bala = int.Parse(Console.ReadLine());
chiclete = int.Parse(Console.ReadLine());

Console.WriteLine("O valor da compra é:");
Console.WriteLine("Chocolate: " + (chocolate * 8));
Console.WriteLine("Bala: " + (bala * 3));
Console.WriteLine("Chiclete: " + (chiclete * 5));
Console.WriteLine("Valor Total: " + (chocolate * 8 + bala * 3 + chiclete * 5));