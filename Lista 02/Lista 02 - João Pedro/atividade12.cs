int xp;
int membros;
int resto;

Console.WriteLine("Digite o XP ganhado pela equipe");
xp = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o número de membros?");
membros = int.Parse(Console.ReadLine());

xp = xp / membros;
resto = xp % membros;

Console.WriteLine("Cada membro tem " + xp + " pontos e sobram " + resto);

