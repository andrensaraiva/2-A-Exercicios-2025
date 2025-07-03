
string[] itens = new string[6];

Console.WriteLine("Inventario");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Colocar item no espaço " + (i+1) );
    itens[i] = Console.ReadLine();
}
Console.WriteLine("Qual item que buscar ");
itens[6] = Console.ReadLine();

if (new[] { itens[0], itens[1], itens[2], itens[3], itens[4] }.Contains(itens[6])) 
{
    Console.WriteLine("O item foi encontrado");
}
else
{
    Console.WriteLine("O item não foi encontrado");
}