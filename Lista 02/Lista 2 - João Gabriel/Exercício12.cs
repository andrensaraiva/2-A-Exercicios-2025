int xp = 11;
int membros = 11;

Console.WriteLine("total de XP ganho pela equipe?");
xp = int.Parse(Console.ReadLine());
Console.WriteLine("número de membros?");
membros = int.Parse(Console.ReadLine());

Console.WriteLine("xp individual: " + (xp / membros) + "xp restante: " + (xp % membros));