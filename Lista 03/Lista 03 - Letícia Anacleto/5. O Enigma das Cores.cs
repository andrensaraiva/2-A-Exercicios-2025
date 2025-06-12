Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
int numero = int.Parse(Console.ReadLine());
if (numero == 2)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");
}
else if (numero == 1)
{
    Console.WriteLine("Nada acontece com o botão Vermelho.");
}
else if (numero == 3)
{
    Console.WriteLine("O botão Verde não funcionou.");
}
else
{
    Console.WriteLine("Escolha inválida, Elara.");
}
