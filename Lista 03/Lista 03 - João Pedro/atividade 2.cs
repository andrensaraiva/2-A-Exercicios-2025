string resposta2;

Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)");
resposta2 = Console.ReadLine();

{
    if (resposta2 == "sim")
    {
        Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
    }
    else
    {
        Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
    }
}
