int xpGanho = 0;
int Nmembros = 0;

Console.WriteLine("Quantos XP a sua equipe ganhou?");
xpGanho = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos membros tem na sua equipe?");
Nmembros = int.Parse(Console.ReadLine());

Console.WriteLine("xp individual: " + (xpGanho / Nmembros) + "xp restante: " + (xpGanho % Nmembros));
