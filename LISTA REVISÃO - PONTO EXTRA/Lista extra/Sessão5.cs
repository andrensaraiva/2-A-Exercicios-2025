//O seletor de opções

// Máquina de poções

int ouro = 100;

Console.WriteLine("[1] Poção de Cura (custa 20 ouro)");

Console.WriteLine("[2] Poção de Força (custa 35 ouro)");

Console.WriteLine("[3] Poção de Mana (custa 30 ouro)");

Console.WriteLine("Escolha sua poção digitando o número:");

int escolhaPocao = int.Parse(Console.ReadLine());

switch (escolhaPocao)

{

    case 1:

        ouro -= 20;

        Console.WriteLine("Você comprou a Poção de Cura. Ouro restante: " + ouro);

        break;

    case 2:

        ouro -= 40;

        Console.WriteLine("Você comprou a Poção de Força. Ouro restante: " + ouro);

        break;

    case 3:

        ouro -= 30;

        Console.WriteLine("Você comprou a Poção de Mana. Ouro restante: " + ouro);

        break;

    default:

        Console.WriteLine("Opção inválida.");

        break;

}


//Teletransportador entre cidades

Console.WriteLine("Digite o nome da cidade que você deseja viajar (Ventobravo, Orgrimmar ou Dalaran):");

string cidade = Console.ReadLine();

switch (cidade)

{

    case "Ventobravo":

        Console.WriteLine("Custo: 40 ouro. Ventobravo é uma cidade ensolarada e bela.");

        break;

    case "Orgrimmar":

        Console.WriteLine("Custo: 50 ouro. Orgrimmar é uma cidade fria e misteriosa");

        break;

    case "Dalaran":

        Console.WriteLine("Custo: 60 ouro. Dalaran é a famosa cidade dos magos");

        break;

    default:

        Console.WriteLine("Cidade não encontrada.");

        break;

}


//NPC com personalidades multiplas

Console.WriteLine("Digite o estado emocional do NPC (1: Feliz, 2: Neutro, 3: Triste, 4: Irritado):");

int estadoEmocional = int.Parse(Console.ReadLine());

switch (estadoEmocional)

{

    case 1:

        Console.WriteLine("NPC: 'Que belo dia!'");

        break;

    case 2:

        Console.WriteLine("NPC: 'O que você quer?'");

        break;

    case 3:

        Console.WriteLine("NPC: 'Não me sinto bem...'");

        break;

    case 4:

        Console.WriteLine("NPC: 'Saia da minha frente!'");

        break;

    default:

        Console.WriteLine("Estado desconhecido.");

        break;

}


//Aplicando bonus de arma

Console.WriteLine("Escolha uma arma (Espada, Machado ou Arco):");

string arma = Console.ReadLine();

int dano = 15;

int velocidadeDeAtaque = 10;

switch (arma)

{

    case "Espada":

        dano += 5;

        velocidadeDeAtaque += 3;

        break;

    case "Machado":

        dano += 8;

        velocidadeDeAtaque -= 2;

        break;

    case "Arco":

        dano += 4;

        velocidadeDeAtaque += 5;

        break;

    default:

        Console.WriteLine("Arma desconhecida.");

        break;

}

Console.WriteLine("Atributos finais: Dano = " + dano + "; Velocidade de Ataque = " + velocidadeDeAtaque);


//Conversor de runa para elemento

Console.WriteLine("Digite um símbolo de runa ('F', 'A' ou 'T'):");

char runa = char.Parse(Console.ReadLine());

switch (runa)

{

    case 'F':

        Console.WriteLine("Elemento: Fogo");

        break;

    case 'A':

        Console.WriteLine("Elemento: Água");

        break;

    case 'T':

        Console.WriteLine("Elemento: Terra");

        break;

    default:

        Console.WriteLine("Runa desconhecida.");

        break;

}

//A bolsa dimensional

//Cinto de utilidades

string[] cinto = new string[4];

for (int i = 0; i < cinto.Length; i++)

{

    Console.Write("Item " + (i + 1) + ": ");

    cinto[i] = Console.ReadLine();

}

Console.WriteLine("Conteúdo do cinto:");

for (int i = 0; i < cinto.Length; i++)

{

    Console.WriteLine("- " + cinto[i]);

}

//Histórico de batalha

int[] danos = new int[5];

Console.WriteLine("Digite o dano causado nos últimos 5 turnos:");

int totalDano = 0;

for (int i = 0; i < danos.Length; i++)

{

    danos[i] = int.Parse(Console.ReadLine());

    totalDano += danos[i];

}

float danoMedio = totalDano / (float)danos.Length;

Console.WriteLine("Dano total: " + totalDano + "; Dano médio: " + danoMedio);

//Procurando o ingrediente

string[] ingredientes = { "Erva verde", "Raiz de soja", "Escama de largato", "Lã rosa", "Lágrima de bruxa", "Chifre de unicórnio" };

Console.WriteLine("Digite o nome do ingrediente que procura:");

string busca = Console.ReadLine();

bool encontrado = false;

for (int i = 0; i < ingredientes.Length; i++)

{

    if (ingredientes[i] == busca)

    {

        Console.WriteLine("Ingrediente encontrado no slot # " + i + "!");

        encontrado = true;

    }

}

if (!encontrado)

{

    Console.WriteLine("Ingrediente não encontrado.");

}

//Invertendo a ordem dos feitiços

string[] feitiços = { "Bola de Fogo", "Escudo Arcano", "Raio Congelante", "Cura Rápida" };

Console.WriteLine("Feitiços em ordem inversa:");

for (int i = feitiços.Length - 1; i >= 0; i--)

{

    Console.WriteLine("- " + feitiços[i]);

}

//Inventário de itens raros

string[] nomesItens = { "Espada sagrada", "Adaga sangrenta", "Amuleto da sorte" };

int[] valoresItens = { 400, 500, 700 };

Console.WriteLine("Escolha um slot de 0 a 2 para ver o item:");

int slot = int.Parse(Console.ReadLine());

if (slot >= 0 && slot < nomesItens.Length)

{

    Console.WriteLine("Item: " + nomesItens[slot] + "; Valor: " + valoresItens[slot] + " ouro.");

}

else

{

    Console.WriteLine("Slot inválido.");

}

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
