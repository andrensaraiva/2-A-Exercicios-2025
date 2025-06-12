string resposta = "salvo";

Console.WriteLine("Você tem a 'Chave de cobre'? (sim/não)");
resposta = Console.ReadLine();

if (resposta == "sim")
{
    Console.WriteLine("Você Você abre o baú e encontra 50 moedas de ouro!");
}

else if (resposta == "não")
{
    Console.WriteLine("O baú está trancado.Você precisa da chave certa!");
}
