string a;

Console.WriteLine("Diálogo com NPC Reativo à Fama");
Console.WriteLine("Fama do jogador (ex: herói, vilão, neutro)");
a = Console.ReadLine();
if (a == "herói")
{
    Console.WriteLine("NPC: O grande herói que bom ver você");
}
else if (a == "vilão")
{
    Console.WriteLine("NPC: Eu não tenho nada aqui para você");
}
else if (a == "neutro") ;
{
    Console.WriteLine("NPC: Bom dia como vai o dia ");
}