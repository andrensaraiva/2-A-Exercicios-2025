Console.WriteLine("Voce recebeu 100 ouros!");
int ouro = 100;
Console.WriteLine(" ");
Console.WriteLine("Qual poção voce deseja? ( [1] Cura, [2] Força, [3] Mana)");
int pocaoescolhida = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
switch (pocaoescolhida)
{
    case 1:
        ouro -= 20;
        Console.WriteLine("voce recebeu a poção de cura, e agora tem " + ouro + " ouros.");
        break;
    case 2:
        ouro -= 50;
        Console.WriteLine("voce recebeu a poção de força, e agora tem " + ouro + " ouros.");
        break;
    case 3:
        ouro -= 30;
        Console.WriteLine("voce recebeu a poção de mana, e agora tem " + ouro + " ouros.");
        break;
}