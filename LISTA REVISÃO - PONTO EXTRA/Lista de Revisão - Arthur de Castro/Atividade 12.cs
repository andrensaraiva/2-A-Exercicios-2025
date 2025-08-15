
Console.WriteLine("Teletransportador entre Cidades");
Console.Write("Digite a cidade (Ventobravo/Orgrimmar/Dalaran): ");
string cidade = Console.ReadLine();

switch (cidade)
{
    case "ventobravo":
        Console.WriteLine("Custo: 50g - Capital humana");
        break;
    case "orgrimmar":
        Console.WriteLine("Custo: 40g - Lar dos orcs");
        break;
    case "dalaran":
        Console.WriteLine("Custo: 60g - Cidade mágica");
        break;
    default:
        Console.WriteLine("Cidade desconhecida");
        break;
}
