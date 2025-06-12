string a;
int b;

Console.WriteLine("Sistema de Crafting com Qualidade de Item");
Console.WriteLine("Qual é o material utilizado(ferro,aço,mithril");
a = Console.ReadLine();
Console.WriteLine("Nível de habilidade");
b = int.Parse(Console.ReadLine());
if (a == "ferro" && b >=20)
{
    Console.WriteLine("Criou uma espada de ferro comum");
}
else if (a == "aço" && b >=50)
{
    Console.WriteLine("Criou uma espada de aço rara");
}
else if (a == "mithril" && b >=100)
{
    Console.WriteLine("Criou uma espada de mithril épica");
}
else if (a == "mithril" && b>= 999)
{
    Console.WriteLine("Criou a Excalibur lendária");
}