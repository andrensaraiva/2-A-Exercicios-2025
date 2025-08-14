using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

// Seção 1

//1
string nomedomonstro = "Bob";
int hpdomonstro = 300;
float velocidadedeataque = 20;
bool ehChefeDeFase = true;

Console.WriteLine("Nome do monstro: " +  nomedomonstro);

Console.WriteLine("Vida do monstro: " +  hpdomonstro);

Console.WriteLine("Velocidade de ataque do monstro: " +  velocidadedeataque);

Console.WriteLine("Seu monstro é Chefe de Fase");

//2
Console.WriteLine("Qual o seu dano?");

int danodoJogador = int.Parse(Console.ReadLine());

Console.WriteLine("Defina a defesa do monstro: ");

int defesadoMonstro = int.Parse(Console.ReadLine());

float danoFinal = (danodoJogador - defesadoMonstro);

Console.WriteLine("O seu dano é: " + danodoJogador);
Console.WriteLine("A defesa do monstro é: " + defesadoMonstro);
Console.WriteLine("O dano final é de: " + danoFinal);

float vidaRestantePercental = (danoFinal / 100);

Console.WriteLine("A vida restante é de " + (danoFinal/100*10)  + " %");

//3
float valorPorDragao = 15.5f;

Console.WriteLine("Quantos Dragões de outro vc tem?");
float DragoesdeOuro = float.Parse(Console.ReadLine());

float GemasdePrata = (DragoesdeOuro * valorPorDragao);

Console.WriteLine("Você possuí: " + GemasdePrata + " Gemas de prata");

//4
Console.WriteLine("O Portão está aberto? (true/false)");
bool oPortãoEstaAberto = bool.Parse(Console.ReadLine());

Console.WriteLine("Você possuí a chave para abrir o portão? (true/false)");
bool jogadorTemChave = bool.Parse(Console.ReadLine());

bool podePassar = oPortãoEstaAberto || jogadorTemChave;

Console.WriteLine("Pode passar? " + podePassar);

//5
Console.WriteLine("Qual seu nome? ");
string nomedojogador = Console.ReadLine();

Console.WriteLine("Qual sua classe? ");
string classedojogador = Console.ReadLine();

Console.WriteLine("Qual seu nível? ");
int niveldojogador = int.Parse(Console.ReadLine());

string titulocompleto = (nomedojogador + ", O(A)  " + classedojogador + " de Nível " + niveldojogador);

Console.WriteLine(titulocompleto);

//Seção 2

//1
Console.WriteLine("Qual seu nível de Landinagem? ");
int Landinagem = int.Parse(Console.ReadLine());

if (Landinagem >= 15)
{
    Console.WriteLine("Você desarmou a armadilha e ganhou o tesouro");
}
else if (Landinagem >= 10 && Landinagem < 15)
{
    Console.WriteLine("Você desarmou a armadilha, mas não ganhou nada");
}

{
    Console.WriteLine("A armadilha disparou e você perdeu HP!");
}

//2
    Console.WriteLine("Um guarda bloqueou seu caminho, você deseja persuadir, subornar ou lutar: ");
string resposta = Console.ReadLine();

if (resposta == "persuadir")
{
    Random randon = new Random();
    int dado = randon.Next(1, 20);
    Console.WriteLine("Você rolou um dado: " + dado);
    if (dado > 10)
    {
        Console.WriteLine("Você conseguiu passar");
    }
    else
    {
        Console.WriteLine("O Guarda ficou irritado");
    }
}
if  (resposta == "subornar")
{
    Console.WriteLine("Quanto de ouro você oferece?");
    int ouro = int.Parse(Console.ReadLine());

    if (ouro > 50)
    {
        Console.WriteLine("Você conseguiu passar");

    }
    else {
        Console.WriteLine("O guarda recusou");
    }
}
if (resposta == "lutar")
{
    Console.WriteLine("Você perdeu HP, mas conseguiu passar. Cuidado na próxima!! ");
}
else
{
    Console.WriteLine("Inválido");
}
//3
    Console.WriteLine("Escolha seu ataque: .fogo .agua .grama");
string tipoAtaque = Console.ReadLine();

Console.WriteLine("Escolha o tipo do seu inimgo: .fogo .agua .grama");
string tipoInimigo = Console.ReadLine();

if (tipoAtaque == tipoInimigo)
{
    Console.WriteLine("É pouco eficaz!");
}
else if (tipoAtaque == "fogo")
{
    if (tipoInimigo == "grama")
    {
        Console.WriteLine("É super eficaz!");
    }
    else
    {
        Console.WriteLine("Dano normal.");
    }
}
else if (tipoAtaque == "agua")
{
    if (tipoInimigo == "fogo")
    {
        Console.WriteLine("É super eficaz!");
    }
    else
    {
        Console.WriteLine("Dano normal.");
    }
}
else if (tipoAtaque == "grama")
{
    if (tipoInimigo == "agua")
    {
        Console.WriteLine("É super eficaz!");
    }
    else
    {
        Console.WriteLine("Dano normal.");
    }
}
else
{
    Console.WriteLine("Tipo inválido!");
}
//4
Console.WriteLine("Você chegou na Guilda dos Ladrões!");

Console.WriteLine("Qual seu nível de furtividade?");
int furtividade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual seu nível de agilidade?");
int agilidade = int.Parse(Console.ReadLine());

Console.WriteLine("Você possuí a carta de recomendação? (true/false)");
bool TemaCartadeRecomendacao = bool.Parse(Console.ReadLine());
if (furtividade > 12 && agilidade > 14 || TemaCartadeRecomendacao == true)
{
    Console.WriteLine("Você foi aceito!!");
}
else
{
    Console.WriteLine("Você foi recusado");
}

//5
Console.WriteLine("Qual o clima atual: .Ensolarado .Chuvoso .Nevando?");
string climaatual = Console.ReadLine();

Console.WriteLine("Qual montaria você está usando: .Cavalo .Lobo .Nenhuma?");
string montaria = Console.ReadLine();

int tempodeviagem = 10;


if (climaatual == "Chuvoso")
{
    tempodeviagem += 2;
}
else if (climaatual == "Nevando")
{
    if (montaria == "Nenhuma")
    {
        tempodeviagem += 5 * 2;
    }

    else
    {
        tempodeviagem += 5;
    }
}
if (montaria == "Cavalo")
{
    tempodeviagem -= 3;
}
else if (montaria == "Lobo")
{
    tempodeviagem -= 4;
}
Console.WriteLine("O tempo final da viagem será: " + tempodeviagem + " horas");

//Seção 3

//1
    Console.WriteLine("Qual poção você quer: [1] Cura, [2] Força, [3] Mana");
    int pocao = int.Parse(Console.ReadLine());

    Console.WriteLine("Quanto de ouro você possui?");
    int ouropocao = int.Parse(Console.ReadLine());

    switch (pocao)
    {
        case 1:
            Console.WriteLine("Você comprou a Poção de Cura!");
            ouropocao -= 20;
            break;

        case 2:
            Console.WriteLine("Você comprou a Poção de Força!");
            ouropocao -= 30;
            break;

        case 3:
            Console.WriteLine("Você comprou a Poção de Mana!");
            ouropocao -= 25;
            break;

        default:
            Console.WriteLine("Opção inválida, nenhuma compra realizada.");
            break;
    }

    Console.WriteLine("Ouro restante: " + ouropocao);


//2
    Console.WriteLine("Para qual cidade você quer viajar? (Ventobravo, Orgrimmar, Dalaran)");
    string cidade = Console.ReadLine();

    switch (cidade)
    {
        case "Ventobravo":
            Console.WriteLine("Viagem para Ventobravo: Custo 50 de ouro. Cidade humana próspera, cheia de comércio e aventuras.");
            break;

        case "Orgrimmar":
            Console.WriteLine("Viagem para Orgrimmar: Custo 45 de ouro. Fortaleza dos orcs, cheia de guerreiros e treinamentos.");
            break;

        case "Dalaran":
            Console.WriteLine("Viagem para Dalaran: Custo 60 de ouro. Cidade flutuante de magos, cheia de magia e mistérios.");
            break;

        default:
            Console.WriteLine("Cidade inválida. Não há teletransporte disponível para este destino.");
            break;
    }


//3
    Console.WriteLine("Escolha o estado emocional do NPC: [1] Feliz, [2] Neutro, [3] Triste, [4] Irritado");
    int estadoEmocional = int.Parse(Console.ReadLine());

    switch (estadoEmocional)
    {
        case 1:
            Console.WriteLine("NPC: Que dia maravilhoso. Estou muito feliz em te ver!");
            break;

        case 2:
            Console.WriteLine("NPC: Olá tudo bem, suponho.");
            break;

        case 3:
            Console.WriteLine("NPC: Ah não estou muito bem hoje...");
            break;

        case 4:
            Console.WriteLine("NPC: Ei Cuidado com o que você faz!");
            break;

        default:
            Console.WriteLine("NPC: Não sei como me sentir sobre isso");
            break;
    }


 //4
    Console.WriteLine("Escolha seu tipo de arma: Espada, Machado, Arco");
    string arma = Console.ReadLine();

    int dano = 10;
    int velocidadeDeAtaque = 5;

    switch (arma)
    {
        case "espada":
            dano += 5;
            velocidadeDeAtaque += 3;
            break;

        case "machado":
            dano += 8;
            velocidadeDeAtaque -= 2;
            break;

        case "arco":
            dano += 4;
            velocidadeDeAtaque += 5;
            break;

        default:
            Console.WriteLine("Arma inválida, atributos permanecem básicos.");
            break;
    }

    Console.WriteLine("Atributos finais:");
    Console.WriteLine("Dano: " + dano);
    Console.WriteLine("Velocidade de Ataque: " + velocidadeDeAtaque);


//5
Console.WriteLine("Digite o símbolo da runa (F, A, T):");
char runa = Console.ReadLine()[0];


switch (runa)
{
    case 'F':
        Console.WriteLine("Elemento correspondente: Fogo");
        break;

    case 'A':
        Console.WriteLine("Elemento correspondente: Água");
        break;

    case 'T':
        Console.WriteLine("Elemento correspondente: Terra");
        break;

    default:
        Console.WriteLine("Símbolo inválido! Nenhum elemento corresponde.");
        break;
}

//Seção 4

//1
string[] cinto = new string[4];

Console.WriteLine("Digite o nome do item 1:");
cinto[0] = Console.ReadLine();

Console.WriteLine("Digite o nome do item 2:");
cinto[1] = Console.ReadLine();

Console.WriteLine("Digite o nome do item 3:");
cinto[2] = Console.ReadLine();

Console.WriteLine("Digite o nome do item 4:");
cinto[3] = Console.ReadLine();

//2

Console.WriteLine("Itens no seu cinto: ");
Console.WriteLine("Espaço 1: " + cinto[0]);
Console.WriteLine("Espaço 2: " + cinto[1]);
Console.WriteLine("Espaço 3: " + cinto[2]);
Console.WriteLine("Espaço 4: " + cinto[3]);

int[] danos = new int[5];

Console.WriteLine("Digite o dano do turno 1:");
danos[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dano do turno 2:");
danos[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dano do turno 3:");
danos[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dano do turno 4:");
danos[3] = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dano do turno 5:");
danos[4] = int.Parse(Console.ReadLine());

int danoTotal = danos[0] + danos[1] + danos[2] + danos[3] + danos[4];
int danoMedio = danoTotal / 5;

Console.WriteLine("Dano total causado: " + danoTotal);
Console.WriteLine("Dano médio por turno: " + danoMedio);

//3 

string[] ingredientes = new string[6] { "Erva", "Cogumelo", "Olho de Dragão", "Pó Mágico", "Flor da Lua", "Escama de Serpente" };

Console.WriteLine("Digite o nome do ingrediente que você está procurando:");
string procurado = Console.ReadLine();

bool encontrado = false;

for (int i = 0; i < ingredientes.Length; i++)
{
    if (ingredientes[i] == procurado)
    {
        Console.WriteLine($"Ingrediente encontrado no slot #{i + 1}!");
        encontrado = true;
        break;
    }
}

if (encontrado)
{
    Console.WriteLine("Ingrediente não encontrado.");
}

//4

string[] feitiços = new string[4] { "Bola de Fogo", "Cura", "Escudo", "Relâmpago" };

Console.WriteLine("Feitiços em ordem inversa:");

for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine(feitiços[i]);
}

//5

string[] nomesItens = new string[3] { "Amuleto de Fogo", "Elixir de Vida", "Anel da Força" };
int[] valoresItens = new int[3] { 100, 50, 75 };

Console.WriteLine("Escolha um slot (0, 1 ou 2):");
int slot = int.Parse(Console.ReadLine());

if (slot >= 0 && slot < nomesItens.Length)
{
    Console.WriteLine("Item escolhido: {nomesItens[slot]}");
    Console.WriteLine("Valor: {valoresItens[slot]} ouro");
}
else
{
    Console.WriteLine("Slot inválido!");
}

//Seção 5

//1

for (int i = 1; i <= 8; i = i + 1)
{
    Console.WriteLine("Martelada #" + i + "...");

    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }
}

Console.WriteLine("A espada foi forjada com sucesso!");

//2

int andar = 1;

Console.WriteLine("Você está no andar 1 da torre.");
Console.WriteLine("Digite 'subir' para continuar subindo:");

string acao = Console.ReadLine();

while (acao == "subir")
{
    andar = andar + 1;
    Console.WriteLine("Você chegou ao andar #" + andar + "!");

    Console.WriteLine("Digite 'subir' para continuar subindo:");
    acao = Console.ReadLine();
}

Console.WriteLine("Você parou de subir a torre.");

//3

int codigoSecreto = 1337;
int tentativas = 0;
int palpite = 0;

Console.WriteLine("Tente adivinhar o código secreto. Você tem 3 tentativas.");

while (palpite == codigoSecreto == false && tentativas < 3)
{
    Console.Write("Digite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());
    tentativas = tentativas + 1;

    if (palpite == codigoSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o código secreto.");
    }
    else if (tentativas < 3)
    {
        Console.WriteLine("Errado. Tente novamente.");
    }
}

if (palpite == codigoSecreto == false)
{
    Console.WriteLine("Suas tentativas acabaram. O código secreto era: " + codigoSecreto);
}

//4

Random random = new Random();
int madeiraTotal = 0;

Console.WriteLine("Você precisa coletar 50 madeiras.");

while (madeiraTotal < 50)
{
    int madeiraColetada = random.Next(5, 11);
    madeiraTotal = madeiraTotal + madeiraColetada;

    Console.WriteLine("Você coletou " + madeiraColetada + " madeiras neste turno.");
    Console.WriteLine("Total de madeiras: " + madeiraTotal);
}

Console.WriteLine("Você coletou todas as 50 madeiras");

//5

int hpChefe = 100;

Console.WriteLine("A Batalha Final começou. Chefe tem 100 HP.");

while (hpChefe > 0)
{
    Console.WriteLine("Você realiza um Combo de 3 Golpes!");

    for (int i = 1; i <= 3; i = i + 1)
    {
        dano = random.Next(5, 16);
        hpChefe = hpChefe - dano;

        if (hpChefe < 0)
        {
            hpChefe = 0;
        }

        Console.WriteLine("Golpe #" + i + " causou " + dano + " de dano. HP do Chefe: " + hpChefe);
    }
}

Console.WriteLine("Parabéns! Você derrotou o Chefe Final.");