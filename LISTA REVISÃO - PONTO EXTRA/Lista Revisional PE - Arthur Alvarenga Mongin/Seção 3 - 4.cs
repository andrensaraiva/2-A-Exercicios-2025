Console.WriteLine("Escolha um tipo de arma: [1] Espada, [2] Machado ou [3] Arco");
int armaescolhida = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
switch (armaescolhida)
{
    case 1:
        Console.WriteLine("Espada: +5 de dano, +3 de velocidade.");
        break;
    case 2:
        Console.WriteLine("Machado: +8 de dano, -2 de velocidade.");
        break;
    case 3:
        Console.WriteLine("Arco: +4 de dano, +5 de velocidade.");
        break;
}
