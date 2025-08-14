//Os ciclos do tempo
//Forjando a espada
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Martelada #" + i + "...");
    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }
}
 
//Escalando a torre infinita
int andar = 1;
Console.WriteLine("Digite 'subir' para subir mais andares. Digite qualquer outra coisa para parar.");
string comando = Console.ReadLine();
while (comando == "subir")
{
    andar++;
    Console.WriteLine("Você chegou ao andar #" + andar + "!");
    comando = Console.ReadLine();
}
 
//Adivinhe o codigo secreto
int codigoSecreto = 2367;
int tentativas = 0;
bool acertou = false;
while (tentativas < 3 && !acertou)
{
    Console.WriteLine("Tente adivinhar o código secreto:");
    int palpite = int.Parse(Console.ReadLine());
    if (palpite == codigoSecreto)
    {
        acertou = true;
        Console.WriteLine("Você acertou!");
    }
    else
    {
        tentativas++;
        if (tentativas < 3)
        {
            Console.WriteLine("Errado! Tentativas restantes: " + (3 - tentativas));
        }
        else
        {
            Console.WriteLine("Acabaram as tentativas! O código era " + codigoSecreto);
        }
    }
}
 
//Coletando recursos
int totalMadeira = 0;
Random rng = new Random();
while (totalMadeira < 50)
{
    int coleta = rng.Next(5, 11); 
    totalMadeira += coleta;
    Console.WriteLine("Você coletou " + coleta + " madeiras. Total: " + totalMadeira);
}
 
//Batalha final
int hpChefe = 100;
while (hpChefe > 0)
{
    Console.WriteLine("Usando combo de 3 golpes!");
    for (int i = 1; i <= 3; i++)
    {
        int danoGolpe = rng.Next(5, 16); 
        hpChefe -= danoGolpe;
        if (hpChefe < 0) hpChefe = 0;
        Console.WriteLine("Golpe " + i + " causou " + danoGolpe + " de dano. HP do chefe restante: " + hpChefe);
    }
}
Console.WriteLine("Chefe derrotado! Vitória!");
