// 5. O Enigma das Cores

int v = 1;
int a = 2;
int vd = 3;
int n;

Console.WriteLine("Uma porta mágica com três botões: Vermelho, Azul, Verde");


Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
n = int.Parse(Console.ReadLine());


if (n == a)
{

    Console.WriteLine("A porta se abre! O botão Azul estava certo.");
}

if (n == v);

{
    Console.WriteLine("Nada acontece com o botão Vermelho.");

}

if (n == vd)
{
    Console.WriteLine("O botão Verde não funcionou.");
}

if (n >vd)
{
    Console.WriteLine("Escolha inválida, Elara.");
}
