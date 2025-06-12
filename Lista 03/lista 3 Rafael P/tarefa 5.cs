int bot = 0;
Console.WriteLine("uma porta com três botões aparece, qual botão você deseja apertar?" + 
    "   1 = vermelho   2 = verde   3 = azul");
bot = int.Parse(Console.ReadLine());
if (bot == 1)
{
    Console.WriteLine("nada acontece com o botão vermelho");
}
else if (bot == 2)
{
    Console.WriteLine("a porta se abre!");
}
else if (bot == 3) 
{
    Console.WriteLine("escolha errada, a porta não abre");
}
else
{
    Console.WriteLine("escolha inválida");
}