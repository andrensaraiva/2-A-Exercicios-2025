Console.WriteLine(" Você encontra uma porta mágica com três botões: Vermelho (1), Azul (2), Verde (3).");

int numero = 0;

Console.WriteLine("Qual botão você aperta?");
numero = int.Parse(Console.ReadLine());
if (numero == 1)
{
    Console.WriteLine("Nada acontece com o botão Vermelho.");
}
else if (numero == 2)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");
}
else if (numero == 3)
{
    Console.WriteLine("O botão Verde não funcionou.");
}
else 
{
    Console.WriteLine("Escolha inválida, Elara.");
}