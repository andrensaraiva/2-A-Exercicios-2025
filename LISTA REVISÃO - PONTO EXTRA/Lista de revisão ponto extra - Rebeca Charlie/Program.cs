// See https://aka.ms/new-console-template for more information
Console.WriteLine("magos");


//Seção 1

//1 - Ficha do Personagem

string nomeMago = "Mago Zelda";

int hp = 35;

float velocidadeDeAtaque = 22.8f;

bool ehChefe = true;

Console.WriteLine("Nome: " + nomeMago + " | HP: " + hp + " | Velocidade: " + velocidadeDeAtaque + " | Chefe: " + ehChefe);



//2 - Dano na Batalha

Console.WriteLine("Digite o dano do jogador:");

int danoDoHeroi = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a defesa do inimigo:");

int defesaDoInimigo = int.Parse(Console.ReadLine());

int danoFinal = danoDoHeroi - defesaDoInimigo;

Console.WriteLine("Dano final: " + danoFinal);

float vidaTotal = 120f;

Console.WriteLine("Vida que sobra: " + (vidaTotal - danoFinal));



//3 - Conversor de Moeda

float valorCristal = 12.3f;

Console.WriteLine("Quantos cristais você tem?");

int cristais = int.Parse(Console.ReadLine());

float moedas = cristais * valorCristal;

Console.WriteLine("Você tem " + moedas + " moedas.");



//4 - Porta Trancada

Console.WriteLine("Você tem a chave? (true/false)");

bool temChave = bool.Parse(Console.ReadLine());

Console.WriteLine("A porta está aberta? (true/false)");

bool portaAberta = bool.Parse(Console.ReadLine());

if (portaAberta || temChave)

{

    Console.WriteLine("Você passou pela porta.");

}

else

{

    Console.WriteLine("Não pode passar. Ache a chave.");

}


//5 - Título do Jogador

Console.WriteLine("Digite seu nome:");

string nomeJogador = Console.ReadLine();

Console.WriteLine("Digite sua classe:");

string classe = Console.ReadLine();

Console.WriteLine("Digite seu nível:");

int nivel = int.Parse(Console.ReadLine());

string titulo = nomeJogador + ", " + classe + " nível " + nivel;

Console.WriteLine(titulo);



//Seção 2

//1 - Cofre com Armadilha

Console.WriteLine("Digite seu nível de abrir cofres:");

int nivelAbrir = int.Parse(Console.ReadLine());

if (nivelAbrir < 8)

{

    Console.WriteLine("Armadilha ativada! Você perdeu 15 HP. HP restante: " + (hp - 15));

}

else if (nivelAbrir >= 8 && nivelAbrir < 14)

{

    Console.WriteLine("Você abriu o cofre sem problemas.");

}

else

{

    Console.WriteLine("Você abriu o cofre e achou ouro!");

}



//Seção 3

//1 - Loja de Poções

int ouro = 150;

Console.WriteLine("[1] Poção de Vida (25 ouro)");

Console.WriteLine("[2] Poção de Força (45 ouro)");

Console.WriteLine("[3] Poção de Magia (35 ouro)");

Console.WriteLine("Escolha o número:");

int escolha = int.Parse(Console.ReadLine());

switch (escolha)

{

    case 1:

        ouro -= 25;

        Console.WriteLine("Você comprou Poção de Vida! Ouro: " + ouro);

        break;

    case 2:

        ouro -= 45;

        Console.WriteLine("Você comprou Poção de Força! Ouro: " + ouro);

        break;

    case 3:

        ouro -= 35;

        Console.WriteLine("Você comprou Poção de Magia! Ouro: " + ouro);

        break;

    default:

        Console.WriteLine("Opção inválida.");

        break;

}

//2 - Viagem de Cidade

Console.WriteLine("Digite a cidade (Sol, Lua ou Névoa):");

string cidade = Console.ReadLine();

switch (cidade)

{

    case "Sol":

        Console.WriteLine("Custa 60 ouro. Cidade quente e brilhante.");

        break;

    case "Lua":

        Console.WriteLine("Custa 45 ouro. Cidade calma e iluminada pela lua.");

        break;

    case "Névoa":

        Console.WriteLine("Custa 80 ouro. Cidade misteriosa e fria.");

        break;

    default:

        Console.WriteLine("Cidade não encontrada.");

        break;

}

//3 - Humor do NPC

Console.WriteLine("Digite o humor (1 = Feliz, 2 = Normal, 3 = Triste, 4 = Bravo):");

int humor = int.Parse(Console.ReadLine());

switch (humor)

{

    case 1:

        Console.WriteLine("NPC: 'Dia bom hoje!'");

        break;

    case 2:

        Console.WriteLine("NPC: 'O que quer?'");

        break;

    case 3:

        Console.WriteLine("NPC: 'Nada está certo...'");

        break;

    case 4:

        Console.WriteLine("NPC: 'Sai daqui!'");

        break;

    default:

        Console.WriteLine("Humor não conhecido.");

        break;

}

//4 - Escolha de Arma

Console.WriteLine("Escolha uma arma (Cajado, Lança ou Adaga):");

string arma = Console.ReadLine();

int dano = 12;

float velBase = velocidadeDeAtaque;

switch (arma)

{

    case "Cajado":

        dano += 6;

        velBase += 2;

        break;

    case "Lança":

        dano += 9;

        velBase -= 1;

        break;

    case "Adaga":

        dano += 3;

        velBase += 6;

        break;

    default:

        Console.WriteLine("Arma não conhecida.");

        break;

}

Console.WriteLine("Dano: " + dano + " | Velocidade: " + velBase);

//5 - Runa para Elemento

Console.WriteLine("Digite 'V', 'G' ou 'S':");

char runa = char.Parse(Console.ReadLine());

switch (runa)

{

    case 'V':

        Console.WriteLine("Elemento: Vento");

        break;

    case 'G':

        Console.WriteLine("Elemento: Gelo");

        break;

    case 'S':

        Console.WriteLine("Elemento: Sombras");

        break;

    default:

        Console.WriteLine("Runa não conhecida.");

        break;

}



//Seção 4

//1 - Cinto de Itens

string[] cinto = new string[4];

for (int i = 0; i < cinto.Length; i++)

{

    Console.Write("Digite o item " + (i + 1) + ": ");

    cinto[i] = Console.ReadLine();

}

Console.WriteLine("Itens no cinto:");

for (int i = 0; i < cinto.Length; i++)

{

    Console.WriteLine("- " + cinto[i]);

}

//2 - Histórico de Dano

int[] danos = new int[5];

Console.WriteLine("Digite o dano dos últimos 5 ataques:");

int totalDano = 0;

for (int i = 0; i < danos.Length; i++)

{

    danos[i] = int.Parse(Console.ReadLine());

    totalDano += danos[i];

}

float mediaDano = totalDano / (float)danos.Length;

Console.WriteLine("Total de dano: " + totalDano + " | Média: " + mediaDano);

//3 - Procurar Ingrediente

string[] ingredientes = { "Erva Azul", "Raiz Vermelha", "Pó Mágico", "Escama de Dragão", "Lágrima de Fênix", "Semente Negra" };

Console.WriteLine("Digite o ingrediente que procura:");

string busca = Console.ReadLine();

bool achou = false;

for (int i = 0; i < ingredientes.Length; i++)

{

    if (ingredientes[i] == busca)

    {

        Console.WriteLine("Encontrado no espaço " + i);

        achou = true;

    }

}

if (!achou)

{

    Console.WriteLine("Ingrediente não encontrado.");

}

//4 - Feitiços ao Contrário

string[] magias = { "Bola de Fogo", "Escudo", "Raio de Gelo", "Cura Rápida" };

Console.WriteLine("Magias ao contrário:");

for (int i = magias.Length - 1; i >= 0; i--)

{

    Console.WriteLine("- " + magias[i]);

}

//5 - Itens Raros

string[] nomesItens = { "Anel Dourado", "Amuleto Azul", "Espada Negra" };

int[] valores = { 300, 500, 700 };

Console.WriteLine("Digite um número de 0 a 2:");

int slot = int.Parse(Console.ReadLine());

if (slot >= 0 && slot < nomesItens.Length)

{

    Console.WriteLine("Item: " + nomesItens[slot] + " | Valor: " + valores[slot] + " ouro");

}

else

{

    Console.WriteLine("Número inválido.");

}


//Seção 5

//1 - Forjar Espada

for (int i = 1; i <= 8; i++)

{

    Console.WriteLine("Martelada " + i);

    if (i % 2 == 0)

    {

        Console.WriteLine("O ferreiro molha a lâmina na água.");

    }

}

//2 - Subir Torre

int andar = 1;

Console.WriteLine("Digite 'subir' para continuar ou outra coisa para parar:");

string comando = Console.ReadLine();

while (comando == "subir")

{

    andar++;

    Console.WriteLine("Você está no andar " + andar);

    comando = Console.ReadLine();

}

//3 - Adivinhar Código

int codigo = 1337;

int tentativas = 0;

bool acertou = false;

while (tentativas < 3 && !acertou)

{

    Console.WriteLine("Digite o código:");

    int palpite = int.Parse(Console.ReadLine());

    if (palpite == codigo)

    {

        acertou = true;

        Console.WriteLine("Acertou!");

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

            Console.WriteLine("Errou! O código era " + codigo);

        }

    }

}

//4 - Coletar Madeira

int madeira = 0;

Random rng = new Random();

while (madeira < 50)

{

    int coleta = rng.Next(5, 11);

    madeira += coleta;

    Console.WriteLine("Você pegou " + coleta + " madeiras. Total: " + madeira);

}

//5 - Batalha Final

int hpChefe = 100;

while (hpChefe > 0)

{

    Console.WriteLine("Combo de 3 ataques!");

    for (int i = 1; i <= 3; i++)

    {

        int danoGolpe = rng.Next(5, 16);

        hpChefe -= danoGolpe;

        if (hpChefe < 0) hpChefe = 0;

        Console.WriteLine("Golpe " + i + " causou " + danoGolpe + ". HP do chefe: " + hpChefe);

    }

}

Console.WriteLine("Você venceu");


