string humor = "sd";
string raro = "ew";

Console.WriteLine("um goblin comerciante só vende se estiver de bom humor ou se você tem um item raro");
Console.WriteLine("você tem um iten raro? (sim/nao)");
raro = Console.ReadLine();

Console.WriteLine("o goblin aparenta estar de bom humor? (sim/nao)");
humor = Console.ReadLine();

if (humor == "sim" || raro == "sim")
{
    Console.WriteLine("o goblin aceitar trocar com você");
}
else {
    Console.WriteLine("o goblin nao troca com você");
}