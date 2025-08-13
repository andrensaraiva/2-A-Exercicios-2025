Console.WriteLine("Voce deseja viajar para qual cidade: [1] VentoBravo, [2] Orgrimmar ou [3] Dalaran");
int destinoescolhido = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
switch (destinoescolhido)
{
    case 1:
        Console.WriteLine("O destino escolhido foi VentoBrava, uma capital humana, repleta de comércio, soldados e intrigas políticas. O custo da Viagem sera 300 moedas.");
    break;
    case 2:
        Console.WriteLine("O destino escolhido foi Orgrimmar, uma fortaleza dos Orcs, marcada por sua força bruta e espírito guerreiro. O custo da Viagem sera 100 moedas.");
    break;
    case 3:
        Console.WriteLine("O destino escolhido foi Dalaran, uma cidade mágica flutuante, lar de poderosos magos e segredos arcanos. O custo da Viagem sera 500 moedas.");
    break;
}
