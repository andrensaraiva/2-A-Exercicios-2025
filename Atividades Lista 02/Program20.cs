int força = 0;
int agilidade = 0;
int inteligencia = 0;
int total = 100;
int resto = 0;

Console.WriteLine("Atenção, jogador. Você possui 100 pontos.");
Console.WriteLine("Quantos deles você gostaria de usar em força?(o resto ficará com agilidade e inteligência)");

força = int.Parse(Console.ReadLine());

total = total - força;

Console.WriteLine("Quantos dos que restaram você gostaria de usar em agilidade?(O resto ficará com inteligência)");

agilidade = int.Parse(Console.ReadLine());

total = total - agilidade;

Console.WriteLine("Quanto você gostaria de colocar em inteligência?");

inteligencia = int.Parse(Console.ReadLine());

total = total - inteligencia;

resto = total;

Console.WriteLine("A distribuição final ficou:");

Console.WriteLine(" Força =" + força);
Console.WriteLine(" Agilidade =" + agilidade);
Console.WriteLine(" Inteligência =" + inteligencia);
Console.WriteLine(" O resto foi" + resto); 