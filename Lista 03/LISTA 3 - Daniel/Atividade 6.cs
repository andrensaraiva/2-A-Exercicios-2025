// 6. A Oferta do Ferreiro

int moedas;
string resposta;
string s = "sim";
string nao = "nao";

Console.WriteLine("Cenário: O ferreiro está em promoção para aventureiros.");

Console.WriteLine("Quantas moedas de ouro voce tem?");

moedas = int.Parse(Console.ReadLine());

if (moedas >= 10 )
{
    Console.WriteLine("Voce consegue comprar o ferreiro");
}


else
{

    Console.WriteLine("Infelizmente voce nao consegue comprar o ferreiro");

}


Console.WriteLine("Você é membro da Guilda?");

resposta = Console.ReadLine();

if (resposta == s)
{
    Console.WriteLine("Voce consegue um desconto no ferreiro!");

}

else
   if (resposta == nao)
{
    Console.WriteLine("Nao ganha nenhum desconto.");
}