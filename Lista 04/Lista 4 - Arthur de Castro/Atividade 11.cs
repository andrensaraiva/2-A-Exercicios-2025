string a, b, c;

Console.WriteLine("Quebra-Cabeça de Alavancas Interdependentes");
Console.WriteLine("Você três alavancas");
Console.WriteLine("A primeira para cima ou para baixo");
a = Console.ReadLine();
Console.WriteLine("A segunda para cima ou para baixo");
b = Console.ReadLine();
Console.WriteLine("A terceira para cima ou para baixo");
c = Console.ReadLine();
if (a == "cima" &&  b == "cima" && c== "cima")
{
    Console.WriteLine("O quebra-cabeça é resolvido");
}
else
{
    Console.WriteLine("A combinação está errada");
}