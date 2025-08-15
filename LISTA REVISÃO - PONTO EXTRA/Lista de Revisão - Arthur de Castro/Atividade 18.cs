string[] ingredientes = { "erva", "poeira", "cristal", "mel", "raiz", "agua" };

Console.WriteLine("Procurando Ingrediente");
Console.Write("Digite o ingrediente procurado: ");
string procurado = Console.ReadLine();
bool encontrado = false;
for (int i = 0; i < 6; i++)
{
    if (ingredientes[i] == procurado)
    {
        Console.WriteLine($"Ingrediente encontrado no slot {i+1}º!");
        encontrado = true;
    }
}
if (encontrado == false)
{
    Console.WriteLine("Ingrediente não encontrado.");
}