// O Enigma das Cores

int botao = 0;
Console.WriteLine("Qual botao voce aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
botao = int.Parse(Console.ReadLine());
if (botao == 1)
{
    Console.WriteLine("Nada acontece com o botao Vermelho.");
}
else if (botao == 2)
{
    Console.WriteLine("A porta se abre! O botao Azul estava certo.");
}
else if (botao == 3)
{
    Console.WriteLine("O botao Verde não funcionou.");
}
else
{
    Console.WriteLine("Escolha invalida, Elara.");
}
