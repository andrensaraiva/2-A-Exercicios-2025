string lana;
int força = 10;
int agilidade = 10;
int inteligencia = 10;

Console.WriteLine("Qual o nome do seu personagem?");
lana = (Console.ReadLine());
Console.WriteLine("Qual sua força");
força = int.Parse(Console.ReadLine());
Console.WriteLine("agilidade?");
agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("inteligencia?");
inteligencia = int.Parse(Console.ReadLine());
Console.WriteLine("HPBase: " + força * 5 + " Dano físico: " + (força + (agilidade / 2)) + " Poder mágico: " + inteligencia * 3);