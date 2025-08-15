int ladinagem;

Console.WriteLine("Báu com Armadilha");
Console.WriteLine("Qual seu nível como ladino");
ladinagem = int.Parse(Console.ReadLine());

if (ladinagem >= 10)
{
    Console.WriteLine("Você abre o báu sem dificuldade");
}
else if (ladinagem >= 15)
{
    Console.WriteLine("Não foi possível abrir");
} 
else
{
    Console.WriteLine("Você não abre o báu e toma dano de hp");
}