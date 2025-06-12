using System.Runtime.Intrinsics.Arm;

int a;
string b;

Console.WriteLine("Quantas moedas de ouro você tem?");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Você é membro da Guilda? (sim/nao)");
b = (Console.ReadLine());


if (a <= 5 && b == "sim")
{
    Console.WriteLine("Quer fazer missoes para conseguir moedas?");
}


else if (a > 5 && b == "sim")
{
    Console.WriteLine("Otimo! entao vamos para a loja da guilda.");
}

else if (a > 5 && b == "nao")
{
    Console.WriteLine("Entao entre na guilda para acessar a nossa loja!");
}

else
{
    Console.WriteLine("nao posso te ajudar, mal ai");
}