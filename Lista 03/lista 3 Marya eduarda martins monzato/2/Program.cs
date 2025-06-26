string Resposta = "Sim/Não";

Console.WriteLine("Você tem a 'chave de cobre'? ");
Resposta = (Console.ReadLine());
if (Resposta == "Sim")
{
    Console.WriteLine("Você abre o bau e encontra 50 moedas de ouro!");
}
else
{
    Console.WriteLine("O bau está trancado, você prescisa dda chave certa!");
}