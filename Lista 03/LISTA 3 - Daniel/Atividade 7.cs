// 7. O Portal Instável


string r1,r2,r3;


Console.WriteLine("Cenário: Um portal só se estabiliza com artefatos mágicos ou alto poder.");

Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
r1 = Console.ReadLine();


Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
r2 = Console.ReadLine();

Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
r3 = Console.ReadLine();


if (r1 == "sim" && r2 == "sim") 
{
    Console.WriteLine("Parabens voce consegue passar!");
}



else if (r3 == "sim")
{
    Console.WriteLine("Parabens voce consegue passar!");


 }


else
{
    Console.WriteLine("Infelizmente voce nao passa.");
}
