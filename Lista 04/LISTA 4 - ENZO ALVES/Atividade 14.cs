
int a, b, c;
int r1=0, r2=0,r3 = 0;
Console.WriteLine("Decifrando um Código Rúnico");
Console.WriteLine("Qual número coloca na primeira rúnica");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Qual número coloca na primeira rúnica");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Qual número coloca na primeira rúnica");
c = int.Parse(Console.ReadLine());
if (a == 1)
{
    r1 = 1;
}
if  (b == 3)
{
    r2 = 1;
}
if (c == 1)
{
    r3 = 1;
}
if (r1+r2+r3 == 3)
{
    Console.WriteLine("O código está certo");
}
else if (r1+r2+r3 == 2)
{
     Console.WriteLine("Duas runas estão corretas");
}
else if (r1+r2+r3 == 1)
{
    Console.WriteLine("Uma runa está correta");
}
else
{
    Console.WriteLine("Nenhuma está correta");
}