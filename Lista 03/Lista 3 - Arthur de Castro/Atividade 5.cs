int a;

Console.WriteLine("Você encontra uma porta com três botões");
Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Nada acontece com o botão Vermelho");
}
else if (a == 2)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");
}
else if (a == 3)
    Console.WriteLine("O botão Verde não funcionou.");
else
{
    Console.WriteLine("Escolha inválida");
}