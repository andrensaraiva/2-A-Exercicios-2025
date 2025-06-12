string resposta = "salvo";

Console.WriteLine("A ponte parece instável. Você quer atravessar? (sim/não)");
resposta = Console.ReadLine();

if (resposta == "sim")
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
}

else if (resposta == "não")
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
}