// See https://aka.ms/new-console-template for more information
string numero = "blçeh";

string Gema = "gema";

string simounao = "sim ou não";

Console.WriteLine("Você encontra um portal estranho, mas para entrar você precisa ter atender algums requisitos");

Console.WriteLine("Você tem gemas estelares? (sim/não)");
Gema = Console.ReadLine();
if (Gema == "sim" || Gema == "não")
{
    Console.WriteLine("ok");
}

Console.WriteLine("Você tem orbes lunares? (sim/não)");
numero = Console.ReadLine();
if (numero == "sim" || numero == "não")
{
    Console.WriteLine("ok");
}

Console.WriteLine("Seu pode Arcano é maior que 50? (sim/não)");
simounao = Console.ReadLine();
if (simounao == "sim" ||  simounao == "não")
{
    Console.WriteLine("ok");
}
Console.WriteLine("Agora vamos ver se você pode passar...");
if (Gema == "sim" && numero == "sim" || simounao == "sim")
{
    Console.WriteLine("Você pode entrar no portal");
}

else
{
    Console.WriteLine("Você não pode entrar no portal");
}