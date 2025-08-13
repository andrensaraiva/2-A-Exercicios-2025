using System.ComponentModel.Design;

Console.WriteLine("Bau do Tesouro com Armadilha");
Console.WriteLine(" ");
Console.WriteLine("Qual seu nivel de esperteza?");
int NE = int.Parse(Console.ReadLine());
if (NE >= 15)
{
    Console.WriteLine("Voce desarma a armadilha e consegue o tesouro");
}
else if (NE >= 10)
{
    Console.WriteLine("Voce desarma a armadilha, porem nao consegue o tesouro");
}
else
{
    Console.WriteLine("A armadilha é disparada e voce perde um pouco de vida");
}
