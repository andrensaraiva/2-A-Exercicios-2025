
string resposta = "é";
int moeda  = 0;

Console.WriteLine("Você é membro da guilda? (sim/não)");
resposta= Console.ReadLine();

if (resposta == "sim")
{
    Console.WriteLine("Você tem desconto de 5 moedas!");
}

else if (resposta == "não")
{
     Console.WriteLine("Que pena!");
}

Console.WriteLine("Quantas moedas de ouro você tem?");
moeda = int.Parse(Console.ReadLine());


 if (moeda < 100)
{
Console.WriteLine("Você não tem o suficiente. Volte quando tiver mais moedas.");
}

 else if (moeda <= 100)
{
    Console.WriteLine("Você pode comprar. Entre!");
}


