int numero = 100;
int numero2 = 50;
int resultado = 150;

Console.WriteLine("Digite dois números inteiros. Seu primeiro número é:");

numero = int.Parse(Console.ReadLine());

Console.WriteLine("Seu segundo número:");

numero2 = int.Parse(Console.ReadLine());

resultado = numero + numero2;

Console.WriteLine(" A soma de" + numero + "+" + numero2 + "é igual a" + resultado);