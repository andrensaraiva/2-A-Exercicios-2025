
int dano = 10;
int velocidade = 5;
Console.WriteLine("Bonus de Arma");
Console.Write("Escolha arma (Espada/Machado/Arco): ");
string arma = Console.ReadLine();

switch (arma)
{
    case "Espada": 
        dano += 5; velocidade += 3;
        break;
    case "Machado": 
        dano += 8; velocidade -= 2; 
        break;
    case "Arco":
        dano += 4; velocidade += 5; 
        break;
    default: 
        Console.WriteLine("Arma inválida"); 
        break;
}
Console.WriteLine($"Dano: {dano}, Velocidade: {velocidade}");
