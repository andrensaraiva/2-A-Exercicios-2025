string resposta3;

Console.WriteLine("A ponte parece instável. Você quer atravessar? (sim/nao)");
resposta3 = Console.ReadLine();

{
    if (resposta3 == "sim")
    {
        Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
    }
    else
    {
        Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
    }
}
