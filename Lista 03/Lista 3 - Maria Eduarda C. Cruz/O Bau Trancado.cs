// O Bau Trancado

string jogador = "";
Console.WriteLine("Voce tem a 'Chave de Cobre'? ");
jogador = Console.ReadLine();
if (jogador == "sim")
{
    Console.WriteLine("Voce abre o bau e encontra 50 moedas de ouro!");
}

else if (jogador == "nao")
{
    Console.WriteLine("O bau esta trancado. Voce precisa da chave certa.");
}
