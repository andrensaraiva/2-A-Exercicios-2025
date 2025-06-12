using System.Runtime.Intrinsics.Arm;

string resposta = "melei a cueca";

Console.WriteLine("voce quer tomar o tadalafila?");
resposta = Console.ReadLine();

if (resposta == "sim") {
    Console.WriteLine("você tomou o tadalafila! +30 de vigor");
}
else {
    Console.WriteLine("você não tomou o tadala e ficou broxa!!! - 100000 social credits");
}
