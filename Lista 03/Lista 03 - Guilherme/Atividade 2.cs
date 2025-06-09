// See https://aka.ms/new-console-template for more information
string Resposta = "oi";
Console.WriteLine("Você tem a chave do cofre? (sim/não)");
Resposta = Console.ReadLine();
if (Resposta == "sim")
{
    Console.WriteLine("Você abre o bau e encontra um tesouro! (+50 gold)");
}
else if (Resposta == "não")
{
    Console.WriteLine("O bau não abre, você precisa da chave");
}

