int moedas;
string resp;

Console.WriteLine("Quantas moedas de ouro você tem?");
moedas = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
resp = Console.ReadLine();

{
    if (moedas >= 100 && resp == "sim")
    {
        Console.WriteLine("Oferta especial! Você recebe uma espada mágica com desconto!");
    }
    else if (moedas >= 100 && resp == "nao")
    {
        Console.WriteLine("Você pode comprar uma espada normal");
    }
    else if (moedas < 100 && resp == "sim")
    {
        Console.WriteLine("Como membro, você recebe um escudo");
    }
    else
    {
        Console.WriteLine("Volte quando tiver moedas ou entrar pra guilda");
    }
}
