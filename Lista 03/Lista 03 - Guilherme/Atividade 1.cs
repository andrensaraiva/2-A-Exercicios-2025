// See https://aka.ms/new-console-template for more information
string Resposta = "oi";
Console.WriteLine("Você quer beber a poção?(sim/não)");
Resposta = Console.ReadLine();
if (Resposta == "sim") 
{
    Console.WriteLine("Você bebeu a poção, você sente suas forças voltando (+10 hp)");
}
else if (Resposta == "não")
{
    Console.WriteLine("Você guarda a poçõa,não se sabe o que ela faz");
}



