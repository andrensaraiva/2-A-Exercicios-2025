// Pocao Misteriosa

string jogador = "";
Console.WriteLine("Elara, voce quer beber a pocao? ");
jogador = Console.ReadLine();
if (jogador == "sim")
{
    Console.WriteLine("Voce bebe a pocao! Um calor percorre seu corpo. (HP +10)");
}
 
else if (jogador == "nao")
{
    Console.WriteLine("Voce guarda a pocao para depois. Quem sabe o que ela faz?");
}
