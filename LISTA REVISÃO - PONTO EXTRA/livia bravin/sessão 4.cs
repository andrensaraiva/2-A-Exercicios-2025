//1

string[] cinto = new string[4];
for (int i = 0; i < cinto.Length; i++)
{
    Console.Write("item " + (i + 1) + ": ");
    cinto[i] = Console.ReadLine();
}

Console.WriteLine("o conteúdo do cinto é:");
for (int i = 0; i < cinto.Length; i++)
{
    Console.WriteLine("- " + cinto[i]);
}

//2

int[] danos = new int[5];
Console.WriteLine("digite o dano causado referentes aos últimos 5 turnos!");
int totalDeDano = 0;
for (int i = 0; i < danos.Length; i++)
{
    danos[i] = int.Parse(Console.ReadLine());
    totalDeDano += danos[i];
}
float danoMedio = totalDeDano / (float)danos.Length;
Console.WriteLine("seu dano total é: " + totalDeDano + "; dano médio: " + danoMedio);

//3

string[] ingredientes = { "batata roxa", "camomila", "frango desfiado", "arroz japonês", "salmão", "presunto" };
Console.WriteLine("qual é o ingrediente que você está procurando?");
string busca = Console.ReadLine();

bool encontrado = false;
for (int i = 0; i < ingredientes.Length; i++)
{
    if (ingredientes[i] == busca)
    {
        Console.WriteLine("ingrediente encontrado no slot # " + i + "!");
        encontrado = true;
    }
}
if (!encontrado)
{
    Console.WriteLine("este ingrediente não foi encontrado.");
}

//4

string[] feitiços = { "Trazer o amor de volta", "Imortabilidade", "Chuva ácida", "Doença mortal" };
Console.WriteLine("feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}

//5

string[] nomesItens = { "escudo protetivo", "faca super mortal", "granada gigante" };
int[] valoresItens = { 350, 550, 750 };
Console.WriteLine("escolha um slot de 0 a 2");
int slot = int.Parse(Console.ReadLine());
if (slot >= 0 && slot < nomesItens.Length)
{
    Console.WriteLine("item: " + nomesItens[slot] + "; valor: " + valoresItens[slot] + " ouro.");
}
else
{
    Console.WriteLine("slot inválido.");
}