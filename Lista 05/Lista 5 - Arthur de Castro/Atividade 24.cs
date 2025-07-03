string[] inventario = { "Poção", "Espada", "Mapa" };
int escolha;
Console.WriteLine("Inventário");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(" No slot " + i+1 + "está o item: " + inventario[i]);
}

Console.Write("Qual item você quer usar? (Digite o número do slot): ");
escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("Você bebe a Poção e recupera HP!");
            break;
        case 2:
            Console.WriteLine("Você equipa a Espada e se prepara para a batalha!");
            break;
        case 3:
            Console.WriteLine("Você consulta o Mapa e descobre uma nova rota!");
            break;
        default:
            Console.WriteLine("Nada acontece...");
            break;
    }
