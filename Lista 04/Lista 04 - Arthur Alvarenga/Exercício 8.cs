int ED = 1, LG = 2, PU = 3, PG = 4, FCS = 5, BT = 6;
int a, b;
Console.WriteLine("Escoha dois ingredientes desta lista: ");
Console.WriteLine(" ");
Console.WriteLine("1. Escamas de Dragão");
Console.WriteLine("2. Lágrimas de Fênix ");
Console.WriteLine("3. Pó de Unircórnio ");
Console.WriteLine("4. Pluma de Grifo ");
Console.WriteLine("5. Fio de Cabelo de Sereia ");
Console.WriteLine("6. Barbatana de Tubarão");
Console.WriteLine(" ");
Console.WriteLine("Escolha o Primeiro ingrediente: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha o Segundo ingrediente: ");
b = int.Parse(Console.ReadLine());
if (a == 1  && b == 2)
{
    Console.WriteLine("Você consegue criar uma poção de pele de obsidiana, você pode nadar da lava e andar no fogo durante 15 minutos.");
}
else if (a == 3 && b == 4)
{
    Console.WriteLine("Você consegue criar uma poção de voo scarlat, você pode voar por 3000m metros.");
}
else if (a == 5 && b == 6)
{
    Console.WriteLine("Você consegue criar uma poção de nado submergido, você pdoe nadar durante 20 minutos em baixo da água.");
}
else
{
    Console.WriteLine("Não é possivel criar nenhuma poção.");
}