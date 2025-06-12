string a;
string b;

Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
a = (Console.ReadLine());

Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
b = (Console.ReadLine());


if (a == "sim" || b == "sim")
{
    Console.WriteLine("vamos negociar");
}


else
{
    Console.WriteLine("pode vazar q eu n negocio com comedia");
}