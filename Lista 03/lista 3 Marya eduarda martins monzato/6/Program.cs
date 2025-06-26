Console.WriteLine("O ferreiro está em promoção para aventureiros.\r\n");

int numero = 0;
string Resposta = "Sim/Não";
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
Resposta = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro você tem?(PRECISA TER NO MINIMO 100)");
numero = int.Parse(Console.ReadLine());

if (numero >= 100 && Resposta == "sim")
{
    Console.WriteLine("Voce utilizou pq é da guilda e gastou 100 moedas.");
}
else if (numero >=100 && Resposta == "Não")
{
    Console.WriteLine("Voce tem o valor porem nao faz parte da Guilda.");
}
else if (numero <= 100 && Resposta == "Não" )
{
    Console.WriteLine("Não tem valor o suficiente e nem faz parte da Guilda.");
}
else if(numero <= 100 && Resposta == "sim" )
{
    Console.WriteLine("voce e da Guilda porem nao possui o valor.");
}