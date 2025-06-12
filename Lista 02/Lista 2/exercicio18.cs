Console.WriteLine("Qual é o comprimento do cano padrão ");
int n38 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a distância a ser coberta ");
int n39 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos canos inteiros serão necessários " + (n39 / n38));

Console.WriteLine("Quantos canos serão cortados " + (n39 % n38));