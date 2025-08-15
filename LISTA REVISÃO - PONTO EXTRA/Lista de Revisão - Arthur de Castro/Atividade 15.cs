
Console.WriteLine("Conversor de Runa");
Console.Write("Digite a runa (F/A/T): ");
char runa = char.Parse(Console.ReadLine());

switch (runa)
{
    case 'F': 
        Console.WriteLine("Fogo");
        break;
    case 'A':
        Console.WriteLine("Água");
        break;
    case 'T': 
        Console.WriteLine("Terra"); 
        break;
    default: 
        Console.WriteLine("Runa desconhecida"); 
        break;
}