int a, b, c,d;

Console.WriteLine("Gerenciamento de Reino");
Console.WriteLine("Quantidade de Tesouro");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Quantidade de Felicidade");
b= int.Parse(Console.ReadLine());
Console.WriteLine("Quantidade de Força Militar");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Decisão tomada (aumentar impostos =1, investir em festas= 2)");
d=int.Parse(Console.ReadLine());
if (d == 1)
{
    a = (a * 2); b = (b/2); c = (c*2);
}
else  if (d == 2)
{
    a = (a/2); b = (b * 3);
}
Console.WriteLine("Você ficou com " + a + " tesouro e de felicidade ficou com " + b + " e de força militar ficou " +  c + " ,e o reino ficou numa situação");
if (a >= 100 && b <= 50)
{
    Console.WriteLine("de Riqueza e Insatisfação do povo");
}
else if (a >=50 && b >=100)
{
    Console.WriteLine("Boa");
}
else if (a >=300 && b <=20 && c>=100)
{
    Console.WriteLine("Complicada, Preste a estourar uma revolução");
}
