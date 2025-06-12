Console.WriteLine("Digite a força");
int n26 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a agilidade?");
int n27 = int.Parse(Console.ReadLine());

Console.WriteLine("E a inteligência?");
int n28 = int.Parse(Console.ReadLine());

Console.WriteLine("Hp base: " + (n26 * 5));

Console.WriteLine("Dano Físico: " + (n26 + (n27 / 2)));

Console.WriteLine("Poder Mágico: " + (n28 * 3));
