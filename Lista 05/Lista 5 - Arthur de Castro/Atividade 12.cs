string[] item = new string[5];

Console.WriteLine("Inventario");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Coloque item no espaço " + (i + 1) + " do inventario");
    item[i] = Console.ReadLine();
}
Console.WriteLine("Seus itens finais foram: " + item[0] + "," + item[1] + "," + item[2] + "," + item[3] + "," + item[4] + ".");