Console.WriteLine("Desafio do Encanador");
Console.WriteLine("comprimento do cano padrão ");
int n38 = int.Parse(Console.ReadLine());
Console.WriteLine("distância a ser coberta ");
int n39 = int.Parse(Console.ReadLine());
Console.WriteLine("quantos canos inteiros serão necessários " + (n39 / n38));
Console.WriteLine("quantos canos serão cortados " + (n39 % n38));
