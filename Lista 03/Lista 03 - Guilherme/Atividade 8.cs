// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

string humor = "blçeh";

string raro = "gema";

Console.WriteLine("Você encontra um goblin comerciante, ele só negocia se estiver de bom humor ou se você tiver um item raro");
Console.WriteLine("O goblin esta de bom humor? (sim/não)");

humor = Console.ReadLine();

if (humor == "sim" || humor == "não" )
{
   Console.WriteLine("ok");
}


Console.WriteLine("Você possui algum item raro? (sim/não)");

raro = Console.ReadLine();

if (raro == "sim" ||  raro == "não")
{
    Console.WriteLine("ok");
}

Console.WriteLine("Agora vamos ver se o goblin vai fazer negocios com você");

if (raro == "sim" || humor == "sim")
{
    Console.WriteLine("O goblin fará negocios com você");
}
else
{
    Console.WriteLine("O goblin não fara negocios com você");
}




