Console.WriteLine(" Um goblin comerciante só negocia se estiver de bom humor ou se receber um item raro.");

string a, b;

Console.WriteLine("O goblin esta de bom humor hoje?");
a = Console.ReadLine();

Console.WriteLine("Você tem um Olho de Dragão Polido?");
b = Console.ReadLine();

if (a == "sim" & b == "sim")
{
    Console.WriteLine("Para sua sorte estou de bom humor hoje, podemos negociar.");
}
else
{
    Console.WriteLine("Nao quero comprar nada hoje");
}