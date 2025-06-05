float feijão = 25;
float Valor;

Console.WriteLine("O valor do feijão é 25 reais, com quantos reais deseja pagar?");
Valor = int.Parse(Console.ReadLine());

Console.WriteLine("Seu troco é de: " + (Valor - feijão));

