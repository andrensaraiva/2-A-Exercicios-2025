Console.WriteLine("Elara, você quer beber a poção? (sim/nao)");
string resposta = Console.ReadLine();
if (resposta == "sim")
{
    Console.WriteLine("Você bebe a poção! Um calor percorre seu corpo. (HP +10)");
}
else
{
    Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz?");
}
