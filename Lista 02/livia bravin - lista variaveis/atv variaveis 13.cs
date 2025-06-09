int xp = 11;
int membros = 11;

Console.WriteLine("total de XP ganho pela equipe?");
xp = int.Parse(Console.ReadLine());
Console.WriteLine("número de membros?");
membros = int.Parse(Console.ReadLine());

Console.WriteLine("xp individual: " + (xp / membros) + "xp restante: " + (xp % membros));

///Calculadora de IMC
int peso = 11;
int altura = 159;

Console.WriteLine("peso?");
peso = int.Parse(Console.ReadLine());
Console.WriteLine("altura?");
int.Parse(Console.ReadLine());

Console.WriteLine("imc:" + (peso / (altura * altura)));
