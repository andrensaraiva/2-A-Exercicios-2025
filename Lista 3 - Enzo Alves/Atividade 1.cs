
string a, b;

Console.WriteLine("Qual é seu nome");
a = Console.ReadLine();
Console.WriteLine(a + " Você encotra um poção deseja beber(Sim/Não)");
b = Console.ReadLine();
if (b == "Sim")
{
    Console.WriteLine("Você bebe a poção! Um calor percorre seu corpo. (HP +10)");
}
else
{
    Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz?");
}