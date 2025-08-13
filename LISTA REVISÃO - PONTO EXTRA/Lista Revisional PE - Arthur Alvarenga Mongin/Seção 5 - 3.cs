Console.WriteLine("Adivinhe o Código Secreto");
int codigoSecreto = 1337;
bool acertou = false;
for (int tentativa = 1; tentativa <= 3; tentativa++)
{
    Console.Write("Tentativa " + tentativa + ", Digite seu palpite: ");
    int palpite = int.Parse(Console.ReadLine());
    if (palpite == codigoSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou!");
        acertou = true;
        break;
    }
    else
    {
        Console.WriteLine("Errado!");
    }
}
if (!acertou)
{
    Console.WriteLine("Suas tentativas acabaram!");
}
