// 15. Gerador de Status de Jogo

string nome;
int f, a, i;

Console.WriteLine("Qual o nome do personagem e seus atributos (força, agilidade, inteligência)? ");
nome = Console.ReadLine();
f = int.Parse(Console.ReadLine());
a = int.Parse(Console.ReadLine());
i = int.Parse(Console.ReadLine());

Console.WriteLine("Seu Nome é: " + nome);
Console.WriteLine("HP Base = " + (f * 5));
Console.WriteLine("Dano Fisíco = " + (f + (a / 2)));
Console.WriteLine("Poder Mágico = " + (i * 3));
