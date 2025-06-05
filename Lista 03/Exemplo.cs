// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numero = 0;
float virgula = 0.1f;
string nome = "monalisa";
bool vf = false;

Console.WriteLine("digite um numero");
numero = int.Parse(Console.ReadLine());
if (numero >= 5)
{
    Console.WriteLine("numero é maior que 5");
}
else if (numero < 0)
{
    Console.WriteLine("numero é negativo");
}
else 
{
    Console.WriteLine("numero esta entre 0 e 4");
}
