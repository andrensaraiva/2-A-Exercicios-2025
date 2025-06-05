float c, dc;

Console.WriteLine("Digite o comprimento do cano padrão (em metros):");
c = float.Parse(Console.ReadLine());

Console.Write("Digite a distância a ser coberta (em metros):");
dc = float.Parse(Console.ReadLine());

Console.WriteLine("O número de Canos Necessários são: " + (dc / c));

Console.WriteLine("Será usado do ultimo cano: " + (dc % c));
float cc = float.Parse(Console.ReadLine());

Console.WriteLine("Será cortado do ultimo cano: " + (c - cc));

