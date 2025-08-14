
using System;

string nomedomonstro = "";
int hpdomonstro = 0;    
float velocidadeDeAtaque = 0;
bool ehChefeDeFase = false;
Console.WriteLine("ficha:");
Console.WriteLine("HP: " + hpdomonstro);
Console.WriteLine("Nome: " + nomedomonstro);
Console.WriteLine("velocidade: " + velocidadeDeAtaque);
Console.WriteLine("Chefe: " + ehChefeDeFase);



//atividade dois
float vidaRestantePercentual = 100f;
int danoDoJogador = 0;
int defesaDoMonstro = 0;
Console.WriteLine("Dano do jogador?");
danoDoJogador = int.Parse(Console.ReadLine());
Console.WriteLine("defesa do monstro?");
defesaDoMonstro = int.Parse(Console.ReadLine());
Console.WriteLine((danoDoJogador - defesaDoMonstro));
Console.WriteLine( vidaRestantePercentual - (danoDoJogador - defesaDoMonstro));

//atividade 3

float DragaodeOuro = 0;
float GemasdePrata = 15.5f;
Console.WriteLine("quantos dragoes de ouro vc tem?");
DragaodeOuro = float.Parse(Console.ReadLine()); 
Console.WriteLine("vai dar isso em gemas: " + (DragaodeOuro * GemasdePrata));

//atividade 4

bool jogadorTemChave = false;
bool portaEstaAberta  = false;
bool podePassar = false;

Console.WriteLine("jogador Tem Chave?  digite true ou false");
jogadorTemChave = bool.Parse(Console.ReadLine());
Console.WriteLine("porta Esta Aberta?  digite true ou false");
portaEstaAberta = bool.Parse(Console.ReadLine());


//atividade 5


Console.WriteLine("seu nome?");
string seunome = Console.ReadLine();
Console.WriteLine("sua classe?");
string suaclasse = Console.ReadLine();
Console.WriteLine("seu nivel?");
int seunivel = int.Parse(Console.ReadLine());
string tituloCompleto = "Sir " + seunome + ", o " + suaclasse + "de nivel " + seunivel;
Console.WriteLine(tituloCompleto);

//atividade 6
Console.WriteLine("seu nivel ladinagem?");
int niveldeLadinagem = int.Parse(Console.ReadLine());
if (niveldeLadinagem > 15)
{
    Console.WriteLine("desarma a armadilha e ganha o tesouro");
}
else if (niveldeLadinagem > 10)
{
    Console.WriteLine("ele desarmarna armadilha mas não ganha nada");
}
else
{
    Console.WriteLine("armadilha dispara e ele perde HP");
}


//atividade 6

Console.WriteLine("Um guarda bloqueia seu caminho. Pergunte ao jogador como ele vai abordar o guarda:persuadir subornar ou lutar");
string escolhadojogador = Console.ReadLine();
Random random = new Random();
int rnd = random.Next(20);
if  (escolhadojogador == "persuadir")
{
    if (rnd >= 10)
    {
        Console.WriteLine("consegue passar");
    }
    else
    {
        Console.WriteLine("o guarda fica irritado.");
    }
}
else if (escolhadojogador ==  "subornar")
{
    Console.WriteLine("quanto ouro ele oferece");
    int ouro1 = int.Parse(Console.ReadLine());
    if (ouro1 > 50)
    {
        Console.WriteLine("ele passa");
    }
    else
    {
        Console.WriteLine("nao passa");
    }
}
else 
{
    Console.WriteLine("o jogador perde HP, mas consegue passar");
}


//atividade 7

Console.WriteLine("escolher o tipo do seu\r\nataque (\"Fogo\", \"Água\", \"Grama\")");
string tipodeataque = Console.ReadLine();
Console.WriteLine("escolher o tipo do seu\r\nataque inimigo (\"Fogo\", \"Água\", \"Grama\")");
string tipodeataqueinimigo = Console.ReadLine();
if (tipodeataque == "fogo" && tipodeataqueinimigo == "grama")
{
    Console.WriteLine("É super eficaz!");
}
else if (tipodeataque == "agua" && tipodeataqueinimigo == "fogo")
{
    Console.WriteLine("É super eficaz!");
}
else if (tipodeataque == "grama" && tipodeataqueinimigo == "agua")
{
    Console.WriteLine("É super eficaz!");
}
else if (tipodeataque == tipodeataqueinimigo )
{
    Console.WriteLine("É pouco eficaz!");
}
else
{ 
    Console.WriteLine("Dano normal");
}


//atividade 8

Console.WriteLine(" nível de futividade ");
int nivelFurtividade = int.Parse(Console.ReadLine());
Console.WriteLine(" nível de Agilidade ");
int nivelAgilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Carta de Recomendação");
bool cartaderecomendacao = bool.Parse(Console.ReadLine());

if (nivelFurtividade > 12 && nivelAgilidade > 14)
{
    Console.WriteLine("aceito");
}
else if (cartaderecomendacao = true)
{
    Console.WriteLine("aceito");
}
else
{
    Console.WriteLine("nao aceito");
}


// atividade 9
Console.WriteLine("Qual o clima atual? (Ensolarado, Chuvoso ou Nevando)");
string clima = Console.ReadLine();

Console.WriteLine("Qual sua montaria? (Cavalo, Lobo ou Nenhuma)");
string montaria = Console.ReadLine();

int tempoViagem = 10;

if (clima == "Chuvoso")
{
    tempoViagem += 2;
}
else if (clima == "Nevando")
{
    if (montaria == "Nenhuma")
    {
        tempoViagem += 5 * 2;
    }
    else
    {
        tempoViagem += 5;
    }
}

if (montaria == "Cavalo")
{
    tempoViagem -= 3;
}
else if (montaria == "Lobo")
{
    tempoViagem -= 4;
}

Console.WriteLine("Tempo estimado da viagem: " + tempoViagem + " horas");






// atividade 10
int ouro = 100; 
Console.WriteLine("[1] Poção de Cura (custa 20 ouro)");
Console.WriteLine("[2] Poção de Força (custa 40 ouro)");
Console.WriteLine("[3] Poção de Mana (custa 30 ouro)");
Console.WriteLine("Escolha sua poção digitando o número:");
int escolhaPocao = int.Parse(Console.ReadLine());

switch (escolhaPocao)
{
    case 1:
        ouro -= 20;
        Console.WriteLine("Você comprou a Poção de Cura! Ouro restante: " + ouro);
        break;
    case 2:
        ouro -= 40;
        Console.WriteLine("Você comprou a Poção de Força! Ouro restante: " + ouro);
        break;
    case 3:
        ouro -= 30;
        Console.WriteLine("Você comprou a Poção de Mana! Ouro restante: " + ouro);
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}


// atividade 11
Console.WriteLine("Digite o nome da cidade para qual deseja viajar (Ventobravo, Orgrimmar ou Dalaran):");
string cidade = Console.ReadLine();

switch (cidade)
{
    case "Ventobravo":
        Console.WriteLine("Custo: 50 ouro. Ventobravo é uma cidade nobre e brilhante.");
        break;
    case "Orgrimmar":
        Console.WriteLine("Custo: 40 ouro. Orgrimmar é quente e cheia de guerreiros.");
        break;
    case "Dalaran":
        Console.WriteLine("Custo: 70 ouro. Dalaran flutua e respira magia.");
        break;
    default:
        Console.WriteLine("Cidade não encontrada.");
        break;
}


// atividade 12
Console.WriteLine("Digite o estado emocional do NPC (1 = Feliz, 2 = Neutro, 3 = Triste, 4 = Irritado):");
int estadoEmocional = int.Parse(Console.ReadLine());

switch (estadoEmocional)
{
    case 1:
        Console.WriteLine("NPC diz: 'Que dia maravilhoso!'");
        break;
    case 2:
        Console.WriteLine("NPC diz: '... O que você quer?'");
        break;
    case 3:
        Console.WriteLine("NPC diz: 'Nada faz sentido...'");
        break;
    case 4:
        Console.WriteLine("NPC diz: 'Saia da minha frente!'");
        break;
    default:
        Console.WriteLine("Estado desconhecido.");
        break;
}


// atividade 13
Console.WriteLine("Escolha uma arma (Espada, Machado ou Arco):");
string arma = Console.ReadLine();

int dano = 10;
float velocidadeDeAtaqueBase = velocidadeDeAtaque;

switch (arma)
{
    case "Espada":
        dano += 5;
        velocidadeDeAtaqueBase += 3;
        break;
    case "Machado":
        dano += 8;
        velocidadeDeAtaqueBase -= 2;
        break;
    case "Arco":
        dano += 4;
        velocidadeDeAtaqueBase += 5;
        break;
    default:
        Console.WriteLine("Arma desconhecida.");
        break;
}

Console.WriteLine("Atributos finais: Dano = " + dano + "; Velocidade de Ataque = " + velocidadeDeAtaqueBase);



//atividade 14
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





// atividade 15
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



// atividade 16
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




// atividade 17
string[] ingredientes = { "Erva Azul", "Raiz Vermelha", "Pó de Fada", "Escama de Dragão", "Lágrima de Fênix", "Semente Negra" };
Console.WriteLine("Digite o nome do ingrediente que procura:");
string busca = Console.ReadLine();

bool encontrado = false;
for (int i = 0; i < ingredientes.Length; i++)
{
    if (ingredientes[i] == busca)
    {
        Console.WriteLine("Ingrediente encontrado no slot " + i + "!");
        encontrado = true;

    }
}
if (!encontrado)
{
    Console.WriteLine("Ingrediente não encontrado.");
}




// atividade 18
string[] feitiços = { "Bola de Fogo", "Escudo Arcano", "Raio Congelante", "Cura Rápida" };
Console.WriteLine("Feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}



// atividade 19
string[] nomesItens = { "Anel do Poder", "Amuleto Sagrado", "Espada Negra" };
int[] valoresItens = { 300, 500, 700 };
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




// atividade 20
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Martelada #" + i + "...");
    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }
}




// atividade 21
int andar = 1;
Console.WriteLine("Digite 'subir' para subir mais andares. Qualquer outra coisa para parar.");
string comando = Console.ReadLine();
while (comando == "subir")
{
    andar++;
    Console.WriteLine("Você chegou ao andar #" + andar + "!");
    comando = Console.ReadLine();
}




// atividade 22
int codigoSecreto = 1337;
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



// atividade 23
int totalMadeira = 0;
Random rng = new Random();
while (totalMadeira < 50)
{
    int coleta = rng.Next(5, 11);
    totalMadeira += coleta;
    Console.WriteLine("Você coletou " + coleta + " madeiras. Total: " + totalMadeira);
}



// atividade 24 
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