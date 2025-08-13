string[] ingredientes = { "Pedra Mágica", "Folha da Tervore", "Dente de Dragão", "Pele de Iguana", "Anel das Estrelas", "Botas Voadoras" };
Console.WriteLine("Digite o nome do ingrediente que procura:");
string busca = Console.ReadLine();
bool encontrado = false;
for (int i = 0; i < ingredientes.Length; i++)
{
    if (ingredientes[i] == busca)
    {
        Console.WriteLine("Ingrediente encontrado no slot " + i + "!");
        encontrado = true;
    }
}
if (!encontrado)
{
    Console.WriteLine("Ingrediente não encontrado.");
}