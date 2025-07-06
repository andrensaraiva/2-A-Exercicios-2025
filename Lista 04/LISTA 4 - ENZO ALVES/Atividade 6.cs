string a;
int b, c;
Console.WriteLine("Clima Dinâmico e Seus Efeitos");
Console.WriteLine("Clima atual (chuva, sol, neve)");
a = Console.ReadLine();
Console.WriteLine("Quanto é sua quantidade de movimento");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Quanto de dano mágico você tem");
c = int.Parse(Console.ReadLine());
if (a == "chuva")
{
    b = (b / 2);
}
else if (a == "sol")
{
    c = (c*2);
}
else
{
    b = (b / 3); c = (c/2);
}
Console.WriteLine("Você ficou com " + b + " de quantindade de movimento e " + c + " de dano mágico");