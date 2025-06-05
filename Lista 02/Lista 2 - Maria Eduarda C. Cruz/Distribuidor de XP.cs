// Distribuidor de XP

int xp = 0;
int membros = 0;
int resto = 0;
Console.WriteLine("Digite o total de XP ganho pela equipe e o numero de membros: "); 
xp = int.Parse(Console.ReadLine());
membros = int.Parse(Console.ReadLine());
xp /= membros;
resto = xp % membros;
Console.WriteLine("Cada membro recebe " + xp + " de XP.");
Console.WriteLine("Sombram " + resto + " pontos.");
