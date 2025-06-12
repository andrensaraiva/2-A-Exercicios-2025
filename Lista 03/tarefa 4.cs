
int verif = 0;
Console.WriteLine("Qual o seu nível?");
verif = int.Parse(Console.ReadLine());
if (verif >= 5 )
{
    Console.WriteLine("você é forte o suficiente, pode entrar para a guilda");
}
else
{
    Console.WriteLine("HAHA você ainda é fraco");
}