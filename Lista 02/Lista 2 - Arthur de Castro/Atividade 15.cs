int a, b, c;

Console.WriteLine("Gerador de Status de Jogo");
Console.WriteLine();
Console.WriteLine("Digite sua Força");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digte sua Agilidade");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite sua Inteligência");
c = int.Parse(Console.ReadLine());

Console.WriteLine("Hp Base = " + (a * 5));
Console.WriteLine("Dano Físico = " + (a+(b/2)) );
Console.WriteLine("Poder Mágico = " + (c*3));