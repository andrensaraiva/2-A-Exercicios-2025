string gema;
string orbe;
string poder;

Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
gema = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar ? (sim/nao)");
orbe = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
poder = Console.ReadLine();

{
    if ((gema == "sim" && orbe == "sim") || poder == "sim")
    {
        Console.WriteLine("O portal se estabiliza e você pode atravessar!");
    }
    else
    {
        Console.WriteLine("O portal continua instável. Você não pode passar.");
    }
}
