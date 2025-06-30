Console.WriteLine("Quantas moedas de ouro você tem?");
int moedas = int.Parse(Console.ReadLine());

Console.WriteLine("Você é membro da Guilda? (sim/nao)");
string resposta = Console.ReadLine();

if (moedas < 10 && resposta == "nao")
{
    Console.WriteLine("Nada de promoção.");
}
else if (moedas > 10 && resposta == "sim")
{
    Console.WriteLine("Promoção inclusa");
}