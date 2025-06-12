Console.WriteLine("O ferreiro está em promoção para aventureiros da guilda.");

int a;
string a1;

Console.WriteLine("Quantas moedas de ouro você tem?");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Você é membro da guilda?");
a1 = Console.ReadLine();
Console.WriteLine(" ");
Console.WriteLine("O preço do cajado é 70, para aventureiros da guilda 50.");
Console.ReadLine();
if (a >= 70 & a1 == "nao")
{
    Console.WriteLine("Você comprou o cajado!");
}
else if (a < 70 & a1 == "nao")
{
    Console.WriteLine("Você não tem dinheiro o suficiente");
}
else if (a >= 50 & a1 == "sim")
{
    Console.WriteLine("Você comprou o cajado!");
}
else if (a < 50 & a1 == "sim")
{
    Console.WriteLine("Você não tem dinheiro o suficiente");
}