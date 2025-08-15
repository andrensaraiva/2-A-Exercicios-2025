int codigoSecreto = 1337;
int tentativas = 0;
bool acertou = false;
while (tentativas < 3 && acertou == false)
{
    Console.Write("Digite o código: ");
    int palpite = int.Parse(Console.ReadLine());
    tentativas++;
    if (palpite == codigoSecreto)
    {
        Console.WriteLine("Você acertou!");
        acertou = true;
    }
    else if (tentativas >= 3)
        Console.WriteLine("Suas tentativas acabaram - Tente Novamente!");
}