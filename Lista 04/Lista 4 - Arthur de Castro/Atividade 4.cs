int a, b, c;
int força=0, agilidade=0, inteligencia=0;

Console.WriteLine("Equipamentos");
Console.WriteLine("Elmo");
Console.WriteLine("1 = Elmo do Guerreiro");
Console.WriteLine("2 = Elmo do Assasino");
Console.WriteLine("3 = Chapéu do Mago");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Armadura");
Console.WriteLine("1 = Armadura do Guerreiro");
Console.WriteLine("2 = Armadura do Assasino");
Console.WriteLine("3 = Manto do Mago");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Arma");
Console.WriteLine("1 = Espada Longa");
Console.WriteLine("2 = Adaga");
Console.WriteLine("3 = Cajado");
c = int.Parse(Console.ReadLine());
if (a == 1)
{
    força = 25;
}
else if (a == 2)
{
    agilidade = 25;
}
else if (a == 3)
{
    inteligencia = 25;
}
if (b ==1)
{
    força = (força+25);
}
else if (b ==2)
{
    agilidade = (agilidade+25);
}
else if (b ==3)
{
    inteligencia= (inteligencia+25);
}
if (c ==1)
{
    força = (força + 25);
}
if (c ==2)
{
    agilidade= (agilidade+25);
}
if (c ==3)
{
    inteligencia= (inteligencia+25);
}
Console.WriteLine("Status força=" + força + " pontos, agilidade=" + agilidade + " pontos, inteligencia=" + inteligencia + " pontos");