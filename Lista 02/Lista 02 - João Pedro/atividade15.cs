string nome;
int forca;
int agilidade;
int inteligencia;
int hp;
int dano;
int poder;

Console.WriteLine("Qual o nome do personagem?");
nome = Console.ReadLine();
Console.WriteLine("Qual a força?");
forca = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a agilidade?");
agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a inteligência?");
inteligencia = int.Parse(Console.ReadLine());

hp = forca * 5;
dano = forca + (agilidade / 2);
poder = inteligencia * 3;

Console.WriteLine("HP: " + hp);
Console.WriteLine("Dano: " + dano);
Console.WriteLine("Poder mágico: " + poder);

