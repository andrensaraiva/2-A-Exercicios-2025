Console.WriteLine("Adivinhação");
int numeroSecreto = 7;
int resposta;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Tentativa :" + i + "Adivinhe o número (1-10): ");
    resposta = int.Parse(Console.ReadLine());

    if (resposta == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou!");
        break;
    }
    else if (resposta < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else if (resposta > numeroSecreto)
    {
        Console.WriteLine("O número secreto é menor.");
    }
    if (i == 4)
    {
        Console.WriteLine("Você não acertou. O número era 7.");
    }
 }