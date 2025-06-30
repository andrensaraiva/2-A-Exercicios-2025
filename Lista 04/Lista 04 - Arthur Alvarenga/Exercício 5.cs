String c, a;
int co = 6687;

Console.WriteLine("Você acha um cofre mágico, é necessário utilizar uma chave, um amuleto e um codígo para abrí-lo.");
Console.WriteLine(" ");
Console.WriteLine("Possui chave de bronze? (sim/não)");
c = Console.ReadLine();
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
a = Console.ReadLine();
Console.WriteLine("Qual o codígo?");
co = int.Parse(Console.ReadLine());

int contador = 0;

if (c == "sim") contador++;
if (a == "sim") contador++;
if (co == 6687) contador++;

if (contador == 1)
{
    Console.WriteLine("Apenas uma trava foi aberta.");
}
if (contador == 2)
{
    Console.WriteLine("Duas travas foram abertas.");
}
if (contador == 3)
{
    Console.WriteLine("O cofre mágico foi aberto!");
}
if (contador == 0)
{
    Console.WriteLine("Nada aconteceu, o cofre continua trancado.");
}