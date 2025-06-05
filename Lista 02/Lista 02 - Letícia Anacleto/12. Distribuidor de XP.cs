Console.WriteLine("Distribuidor de XP");
Console.WriteLine("Digite o total de XP");
int n19 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de membros");
int n20 = int.Parse(Console.ReadLine());
Console.WriteLine("Cada um vai receber " + (n19 / n20));
Console.WriteLine("O resto de será " + (n19 % n20));