int XP;
int equipe;

Console.WriteLine("Quantos membros sua equipe tem? ");
equipe = int.Parse(Console.ReadLine());

Console.WriteLine("No total, quanto de XP sua equipe ganhou? "); 
XP = int.Parse(Console.ReadLine());

Console.WriteLine("Cada um recebera " + (XP / equipe) + ", sobra: " + (XP %  equipe));  
