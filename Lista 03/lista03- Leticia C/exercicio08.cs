string Goblin = "sim";

string olho = "sim";

Console.WriteLine("Você encontra um goblin comerciante, ele só negocia se estiver de bom humor ou se receber um item raro");
Console.WriteLine("O goblin esta de bom humor? (sim/não)");

Goblin = Console.ReadLine();

if (Goblin == "sim" || Goblin == "não")
{
    Console.WriteLine("ok");
}


Console.WriteLine("Você tem algum item raro para dar para ele? (sim/não)");

olho = Console.ReadLine();

if (olho == "sim" || olho == "não")
{
    Console.WriteLine("ok");
}

Console.WriteLine("O Goblin está decidindo se vai fazer negocios com você");

if (olho == "sim" || Goblin == "sim")
{
    Console.WriteLine("O goblin fará negocios com você");
}
else
{
    Console.WriteLine("O goblin não fara negocios com você");
}

