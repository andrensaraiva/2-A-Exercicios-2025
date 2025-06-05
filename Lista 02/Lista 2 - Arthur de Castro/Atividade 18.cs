float a, b;

Console.WriteLine("Desafio do Encanador");
Console.WriteLine();
Console.WriteLine("Os dois tem que está na mesma unidade");
Console.WriteLine("Qual é o comprimento do cano");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Qual a distância a ser coberta");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Será necessários " + (b / a) + " Canos");
