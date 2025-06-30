using System.ComponentModel.Design;

Console.WriteLine("Você acaba preso em uma armadilha!");
Console.WriteLine("Você precisa resolver três enigmas para escapar desta armadilha.");

string a, b, c; 


Console.WriteLine(" ");
Console.WriteLine("Enigma 1: ");
Console.WriteLine("O que é, o que é? Tem dentes, mas não morde.");
a = Console.ReadLine();
Console.WriteLine(" ");
Console.WriteLine("Enigma 2: ");
Console.WriteLine("O que é, o que é? Quanto mais você tira, maior fica?");
b = Console.ReadLine();
Console.WriteLine(" ");
Console.WriteLine("Enigma 3: ");
Console.WriteLine("O que é, o que é? Anda com os pés na cabeça?");
c = Console.ReadLine();

if (a == "pente" & b != "buraco" & c != "piolho")
{
    Console.WriteLine("A armadilha foi parcialmente desativada");
}
else if (a == "pente" & b == "buraco" & c != "piolho")
{
    Console.WriteLine("A armadilha foi parcialmente desativada");
}
else if (a == "pente" & b == "buraco" & c == "piolho")
{
  Console.WriteLine("A armadilha foi completamente desativada");
}
else
{
    Console.WriteLine("A armadilha não foi desativada");
}


