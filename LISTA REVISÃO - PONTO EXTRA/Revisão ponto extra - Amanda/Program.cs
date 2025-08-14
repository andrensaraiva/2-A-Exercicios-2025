
// seção 01                  for while 
// atividade 01 
string NomeJogador = " Pedro";
int Hp = 50;
float VelocidadeAtaque = 107.13f;
bool eh_chefe_de_fase = false;


// atividade 02 
int danoJogador = 0;
int Defesa_do_Monstro = 0;
Console.WriteLine("Escolha um valor para O DANO DO JOGADOR");
//readline ele retorna um texto - uma string -
//então o parse para converter texto no tipo que voce quer
//float.parse - int.parse - bool.parse
danoJogador = int.Parse(Console.ReadLine());
Console.WriteLine(" Escolha um valor para Defesa do Monstro");
Defesa_do_Monstro = int.Parse (Console.ReadLine());    

int danoFinal = danoJogador - Defesa_do_Monstro;
danoFinal = int.Parse(Console.ReadLine());
float Vida_Restante_Percentual_Monstro = 100f;



// seção 05   for e while 

// While 


for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Martelada #" + i + "...");
    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }

}

// Atividade 02


int andar = 1;
Console.WriteLine("Digite 'subir' para subir mais andares.");
string comando = Console.ReadLine();
while (comando == "subir")
{
    andar++;
    Console.WriteLine("Você chegou ao andar #" + andar + "!");
    comando = Console.ReadLine();
}

// Atividade 03 

int codigoSecreto = 1522;
int tentativas = 0;
bool acertou = false;
while (tentativas < 3 && !acertou)
{
    Console.WriteLine("Tente adivinhar o código secreto:");
    int palpite = int.Parse(Console.ReadLine());
    if (palpite == codigoSecreto)
    {
        acertou = true;
        Console.WriteLine("Você acertou");
    }
    else
    {
        tentativas++;
        if (tentativas < 3)
        {
            Console.WriteLine("Errado,Tentativas restantes: " + (3 - tentativas));
        }
        else
        {
            Console.WriteLine("Acabaram as tentativas, O código era " + codigoSecreto);
        }




        // Atividade 04 
        int totalMadeira = 0;
        Random rng = new Random();
        while (totalMadeira < 50)
        {
            int coleta = rng.Next(5, 12);
            totalMadeira += coleta;
            Console.WriteLine("Você coletou " + coleta + " madeiras. Total: " + totalMadeira);
        }


        // Atividade 05 

        int hpChefe = 100;
        while (hpChefe > 0)
        {
            Console.WriteLine("Usando combo de 3 golpes");
            for (int i = 1; i <= 3; i++)
            {
                int danoGolpe = rng.Next(5, 16);
                hpChefe -= danoGolpe;
                if (hpChefe < 0) hpChefe = 0;
                Console.WriteLine("Golpe " + i + " causou " + danoGolpe + " de dano. HP do chefe restante: " + hpChefe);
            }
        }
        Console.WriteLine("Chefe derrotado,Vitória!");

    