int andar = 1;
Console.Write("Digite 'subir' para continuar ou outra coisa para parar: ");
string acao = Console.ReadLine();

while (acao == "subir")
{
    andar++;
    Console.WriteLine($"Você chegou ao andar #{andar}!");
    Console.Write("Digite 'subir' para continuar ou outra coisa para parar: ");
    acao = Console.ReadLine();
}
if (andar >= 99)
{
    Console.WriteLine("O Louco");
}
else
{
    Console.WriteLine($"Você parou no andar {andar} ");
}