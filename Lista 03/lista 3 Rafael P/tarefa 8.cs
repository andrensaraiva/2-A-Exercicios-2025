using System.Runtime.Intrinsics.Arm;

string humor = "";
string olho = "";

Console.WriteLine("o gobrin só vai aceitar a troca se você lhe oferecer um item raro ou se ele estiver de bom humor...");
Console.WriteLine("você ainda tem olho de dragão polido?");
olho = Console.ReadLine();
Console.WriteLine("julgando pelo olhar do goblin, você diria que ele está de bom humor?");
humor = Console.ReadLine();

if (humor == "sim" || olho == "sim")
{
    Console.WriteLine("você se aproxima e tenta fazer a troca. surpreendentemente ele aceita");
}
else
{
    Console.WriteLine("você tenta fazer a troca mas o gobrin ri da sua cara: HAHAHA esqueça, não gaste o meu tempo");
}