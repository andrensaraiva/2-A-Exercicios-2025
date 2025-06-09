int valorpago = 60;
int item = 50;

Console.WriteLine("Seu produto custa 50 reais, pode me dar o dinheiro?");
valorpago = int.Parse(Console.ReadLine());

Console.WriteLine("Obrigado seu troco é " + (valorpago - item));
