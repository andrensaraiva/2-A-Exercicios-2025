string[] nomesItens = { "Amuleto da Tartaruga", "Espada Alada", "Selo de Radhan" };
int[] valoresItens = { 100, 250, 500 };
Console.WriteLine("Escolha um slot de 0 a 2 para ver o item:");
int slot = int.Parse(Console.ReadLine());
if (slot >= 0 && slot < nomesItens.Length)
{
    Console.WriteLine("Item: " + nomesItens[slot] + "; Valor: " + valoresItens[slot] + " ouro.");
}
else
{
    Console.WriteLine("Slot inválido.");
}