Console.WriteLine("Digite um símbolo de runa ('F', 'A' ou 'T'):");
char runa = char.Parse(Console.ReadLine());

switch (runa)
{
    case 'F':
        Console.WriteLine("Elemento: Fogo");
        break;
    case 'A':
        Console.WriteLine("Elemento: Água");
        break;
    case 'T':
        Console.WriteLine("Elemento: Terra");
        break;
}
