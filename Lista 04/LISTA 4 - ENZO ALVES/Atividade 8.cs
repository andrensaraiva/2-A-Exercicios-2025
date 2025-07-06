int a, b;
Console.WriteLine("Criação de Poções com Efeitos Variados");
Console.WriteLine("Lista de Ingredientes");
Console.WriteLine("Madeira=1");
Console.WriteLine("Asa de Morcego=2");
Console.WriteLine("Olho de Sapo=3");
Console.WriteLine("Lagrima de Fada=4");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a==1 && b==2)
{
    Console.WriteLine("Você criou um poção de visão noturna");
}
else if (a==2 && b==3)
{
    Console.WriteLine("Você criou uma poção de olho de águia ");
}
else if (a==3 && b==4)
{
    Console.WriteLine("Você criou uma poção de cura");
}
else if (a==1 && b == 4)
{
    Console.WriteLine("Você criou uma poção de força");

}
else
{
    Console.WriteLine("O caldeirão explode");
}