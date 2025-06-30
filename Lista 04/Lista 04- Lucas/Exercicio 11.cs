using System.ComponentModel.Design;

string Al1, Al2, Al3;

Console.WriteLine("Qual a posição das alavancas?");
Al1 = Console.ReadLine();
Al2 = Console.ReadLine();
Al3 = Console.ReadLine();

if (Al1 == "baixo" & Al2 == "cima" & Al3 == "cima")
{
    Console.WriteLine("A porta se abre misteriosamente");
}
else
{
    Console.WriteLine("Tente novamente");
}

