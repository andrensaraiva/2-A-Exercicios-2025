string numero = "numero";

string orbe = "orbe";

string simNao = "sim ou não";

Console.WriteLine("Você encontrou m portal estranho, mas para entrar você precisa ter alguns itens");

Console.WriteLine("Você tem gemas estelares? (sim/não)");
orbe = Console.ReadLine();
if (orbe == "sim" || orbe == "não")
{
    Console.WriteLine("beleza");
}

Console.WriteLine("Você tem orbes lunares? (sim/não)");
numero = Console.ReadLine();
if (numero == "sim" || numero == "não")
{
    Console.WriteLine("beleza");
}

Console.WriteLine("Seu pode Arcano é maior que 50? (sim/não)");
simNao = Console.ReadLine();
if (simNao == "sim" || simNao == "não")
{
    Console.WriteLine("ok");
}
Console.WriteLine("Agora vamos ver se você pode passar...");
if (orbe == "sim" && numero == "sim" || simNao == "sim")
{
    Console.WriteLine("Você pode entrar no portal");
}

else
{
    Console.WriteLine("Você não pode entrar no portal");
}