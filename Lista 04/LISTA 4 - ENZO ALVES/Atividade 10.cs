int a;
string a2,b,c="";

Console.WriteLine("Gerador de Eventos Aleatórios com Consequências");
Console.WriteLine("Tipo de Evento");
Console.WriteLine("Ataque de piratas=1");
Console.WriteLine("Chuva Ácida=2");
Console.WriteLine("Ladrões=3");
a = int.Parse(Console.ReadLine());
if (a == 1)
{
    c = "Ataque de Piratas";
}
else if (a == 2)
{
    c = "Chuva Ácida";
}
else if (a == 3)
{
    c = "Ataque de Ladrões";
}
Console.WriteLine("Tem escudo(sim/não)");
a2 = Console.ReadLine();
Console.WriteLine("Tem poção(sim/não)");
b = Console.ReadLine();
if (a2=="sim" && b=="sim")
{
    Console.WriteLine("Você sobrevive ao " + c + "sem perder vida ou itens");
}
else if (a2== "sim"&& b=="não")
{
    Console.WriteLine("Você sobrevive ao " + c + "com pouca vida, mas não perde itens");
}
else if (a2== "não" && b == "sim")
{
    Console.WriteLine("Você sobrevive ao " + c + " com a vida cheia, mas perde seus itens");
}
else
{
     Console.WriteLine("Você morreu e perdeu todo");
}