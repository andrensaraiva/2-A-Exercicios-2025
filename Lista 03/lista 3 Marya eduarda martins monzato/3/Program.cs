string Resposta = "Sim/Não";

Console.WriteLine("A ponte parece instável. Você quer atravessar?");
Resposta = (Console.ReadLine());
if (Resposta == "Sim")
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
}
else
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
}