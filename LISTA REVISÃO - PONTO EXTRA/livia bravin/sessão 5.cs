//1

for (int i = 1; i <= 8; i++)

{

    Console.WriteLine("martelada #" + i + "...");

    if (i % 2 == 0)

    {

        Console.WriteLine("o ferreiro mergulha a lâmina na água!");

    }

}

//2

int andar = 1;

Console.WriteLine("digite 'subir' para continuar subindo, ou digite outra coisa para parar.");

string comando = Console.ReadLine();

while (comando == "subir")

{

    andar++;

    Console.WriteLine("você chegou ao andar #" + andar + "!");

    comando = Console.ReadLine();

}

//3

int codigoSecreto = 8546;

int tentativas = 0;

bool acertou = false;

while (tentativas < 3 && !acertou)

{

    Console.WriteLine("adivinhe o meu código secreto!");

    int palpite = int.Parse(Console.ReadLine());

    if (palpite == codigoSecreto)

    {

        acertou = true;

        Console.WriteLine("parabéns! você acertou! agora o meu código não é tão secreto assim!");

    }

    else

    {

        tentativas++;

        if (tentativas < 3)

        {

            Console.WriteLine("opss! errado! tentativas que faltam: " + (3 - tentativas));

        }

        else

        {

            Console.WriteLine("poxa :((, suas tentativas acabaram! o meu código secreto era " + codigoSecreto);

        }

    }

}


//4

int totalDeMadeira = 0;

Random rng = new Random();

while (totalDeMadeira < 50)

{

    int coleta = rng.Next(5, 11);

    totalDeMadeira += coleta;

    Console.WriteLine("você coletou " + coleta + " madeiras. o total é: " + totalDeMadeira);

}


//5

int hpChefe = 100;

while (hpChefe > 0)

{

    Console.WriteLine("usando combo de 3 golpes!");

    for (int i = 1; i <= 3; i++)

    {

        int danoGolpe = rng.Next(5, 16);

        hpChefe -= danoGolpe;

        if (hpChefe < 0) hpChefe = 0;

        Console.WriteLine(" o golpe " + i + " causou " + danoGolpe + " de dano. HP do chefe restante: " + hpChefe);

    }

}

Console.WriteLine("parabéns! o chefe foi derrotado, você venceu!!");