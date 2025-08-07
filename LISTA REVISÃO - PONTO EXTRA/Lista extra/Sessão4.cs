//A bolsa dimensional
//Cinto de utilidades
string[] cinto = new string[4];
for (int i = 0; i < cinto.Length; i++)
{
    Console.Write("Item " + (i + 1) + ": ");
    cinto[i] = Console.ReadLine();
}

Console.WriteLine("Conteúdo do cinto:");
for (int i = 0; i < cinto.Length; i++)
{
    Console.WriteLine("- " + cinto[i]);
}

//Histórico de batalha

int[] danos = new int[5];
Console.WriteLine("Digite o dano causado nos últimos 5 turnos:");
int totalDano = 0;
for (int i = 0; i < danos.Length; i++)
{
    danos[i] = int.Parse(Console.ReadLine());
    totalDano += danos[i];
}
float danoMedio = totalDano / (float)danos.Length;
Console.WriteLine("Dano total: " + totalDano + "; Dano médio: " + danoMedio);

//Procurando o ingrediente

string[] ingredientes = { "Erva verde", "Raiz de soja", "Escama de largato", "Lã rosa", "Lágrima de bruxa", "Chifre de unicórnio" };
Console.WriteLine("Digite o nome do ingrediente que procura:");
string busca = Console.ReadLine();

bool encontrado = false;
for (int i = 0; i < ingredientes.Length; i++)
{
    if (ingredientes[i] == busca)
    {
        Console.WriteLine("Ingrediente encontrado no slot # " + i + "!");
        encontrado = true;
    }
}
if (!encontrado)
{
    Console.WriteLine("Ingrediente não encontrado.");
}

//Invertendo a ordem dos feitiços

string[] feitiços = { "Bola de Fogo", "Escudo Arcano", "Raio Congelante", "Cura Rápida" };
Console.WriteLine("Feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}

//Inventário de itens raros

string[] nomesItens = { "Espada sagrada", "Adaga sangrenta", "Amuleto da sorte" };
int[] valoresItens = { 400, 500, 700 };
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
