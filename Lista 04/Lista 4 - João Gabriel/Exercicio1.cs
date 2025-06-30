using System.Drawing;

string grifo = "sim/nao";
string escama = "sim/nao";
string flor = "sim/nao";
int moeda = 500;

Console.WriteLine("Possui Pena de Grifo?");
grifo = Console.ReadLine();
Console.WriteLine("Possui Escama de Basilisco?");
escama = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta?");
flor = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui?");
moeda = int.Parse(Console.ReadLine());

if (moeda >= 500 && grifo == "sim" && escama == "sim" && flor == "sim")
{ Console.WriteLine("Parabéns, você conseguiu fazer a poção."); }
else { Console.WriteLine("Você não consegue fazer a poção."); }