using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

string a, b;
int dinheiro;

Console.WriteLine("O ferreiro está em promoção para aventureiros.");

Console.WriteLine("Quantas moedas de ouro você tem?");
dinheiro = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da Guilda? Se for membro da guilda o item Cajado Mestre custara 100, se não, custará 120");
a = Console.ReadLine();
Console.WriteLine("Quer comprar um Cajado Mestre?");
b = Console.ReadLine();


if (a == "sim" & dinheiro >= 100)
{
    Console.WriteLine("Voce adquiriu o item: Cajado Mestre");

}
else if (a == "nao" & dinheiro <= 120)
{
    Console.WriteLine("Volte quando tiver mais dinheiro");

}






    