int item1 = 100;
int valorpago = 11;


Console.WriteLine("O preço da pelúcia é 100 reais, qual é o valor que você vai me dar?");
valorpago = int.Parse(Console.ReadLine());

Console.WriteLine("Seu troco é: " + (valorpago - item1));
