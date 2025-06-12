// O Nivel do Desafio

int jogador = 0;
Console.WriteLine("Qual e o seu nivel atual?");
jogador = int.Parse(Console.ReadLine());
if (jogador >= 5)
{
    Console.WriteLine("Voce e forte o bastante! A caverna se abre.");
}
else if (jogador <= 5)
{
    Console.WriteLine("Volte quando estiver mais forte, Elara.");
}
// Cenário: Elara encontra a entrada da "Caverna dos Sussurros", com uma placa: "Apenas nível 5 ou mais".
// Sua missão:
// Pergunte ao jogador: "Qual é o seu nível atual?"(entrada numérica)
// Se nível ≥ 5: mostre "Você é forte o bastante! A caverna se abre."
// Caso contrário: mostre ""
