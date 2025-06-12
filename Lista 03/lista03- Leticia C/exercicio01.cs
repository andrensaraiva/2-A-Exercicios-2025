string resposta = "salvo";

Console.WriteLine("Você quer beber a poção? (sim/não)");
resposta = Console.ReadLine();

if (resposta == "sim")
{
    Console.WriteLine("Você bebe a poção! um calor percorre seu corpo. (HP + 10)");
}

else if (resposta == "não")
{
    Console.WriteLine(" Você guarda a poção para depois. Quem sabe o que ela faz?");
}




