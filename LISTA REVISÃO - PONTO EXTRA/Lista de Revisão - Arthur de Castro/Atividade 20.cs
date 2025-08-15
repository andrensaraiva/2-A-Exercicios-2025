string[] nomesItens = { "Espada Lendária", "Armadura Épica", "Anel Místico" };
int[] valoresItens = { 500, 300, 200 };

Console.WriteLine("Inventário de Itens Raros");
Console.Write("Escolha o slot (1, 2 ou 3): ");
int slot = int.Parse(Console.ReadLine());
Console.WriteLine($"Item: {nomesItens[slot - 1]}, Valor: {valoresItens[slot-1]} de ouro");
