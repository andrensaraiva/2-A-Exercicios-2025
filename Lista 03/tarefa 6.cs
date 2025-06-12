using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

int moedas = 0;
string guilda = "";
Console.WriteLine("o ferreiro está em promoção para membros da guilda!" + "quantas moedas você tem?");
moedas = int.Parse(Console.ReadLine());
Console.WriteLine("hmm... mas você é membro da guilda?");
guilda = Console.ReadLine();


if (moedas >= 50 && guilda == "sim")
{
    Console.WriteLine("bom, eu acho que consigo alguma coisa por esse preço para um nobre cavaleiro da guilda");
}
else if (moedas < 50 && guilda == "sim")
{
    Console.WriteLine("é uma quantidade muito baixa mas vale a pena para um cavaleiro da guilda");
}
else if (moedas < 50 && guilda == "não")
{
    Console.WriteLine("há, por esse valor não faço nada para alguem que não seja da guilda");
}
else if (moedas >= 50 && guilda == "não")
{
    Console.WriteLine("é o preço normal de um equipamento, já que você não faz parte da guilda");
}
else
{
    Console.WriteLine("não entendi, fale direito, rapaz.");
}