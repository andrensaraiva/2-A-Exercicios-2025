using System.ComponentModel.Design;

string a;

Console.WriteLine("Qual botão você aperta?: Vermelho, Azul ou Verde?");
a = Console.ReadLine();

if (a == "Azul")
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");

}

else if (a == "Vermelho")
{
    Console.WriteLine("Nada acontece com o botão Vermelho.");

}
else if (a == "Verde")
{
    Console.WriteLine("O botão Verde não funcionou.");
}
else
{
    Console.WriteLine("Escolha inválida, Elara.");
}