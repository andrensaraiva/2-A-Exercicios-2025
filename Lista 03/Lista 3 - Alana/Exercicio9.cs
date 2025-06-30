Console.WriteLine("Escolha um túnel: 1 = esquerda(úmido), 2 = direita(com brilho)");
int resposta = int.Parse(Console.ReadLine());

if (resposta == 1)
{
    Console.WriteLine("Nada de promoção.");
}
else if (resposta == 2)
{
    Console.WriteLine("Promoção inclusa");
}