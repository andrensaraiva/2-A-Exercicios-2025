//Sessão 1: O dominio das variaveis e tipos 

//1.1: Ficha Monstro 

string nome = "Vampiro";
int hp = 100;
float velocidadeDeAtaque = 25.5f;
bool chefeDeFase = false;
Console.WriteLine("Nome: " + nome + "; HP: " + hp + "; Velocidade: " + velocidadeDeAtaque + ";" + "`É chefe de fase: " + chefeDeFase);

//1.2: Calculadora de Batalha 

int danoJogador;
int defesaMonstro;
Console.WriteLine("Digite o seu dano e a defesa do seu mosntro.");
danoJogador = int.Parse(Console.ReadLine());
defesaMonstro = int.Parse(Console.ReadLine());
int danoFinal = danoJogador - defesaMonstro;
Console.WriteLine("O dano final é: " + danoFinal);
float vidaRestante = 100f;
Console.WriteLine("A vida restante é " + (vidaRestante - danoFinal));

//1.3: Conversor de Moedas Arcanas 

float dragaoOuro = 15.5f;
Console.WriteLine("Quantos Dragões de Ouro você contém?");
int dragoesJogador = int.Parse(Console.ReadLine());
float gemasPrata = dragoesJogador * dragaoOuro;
Console.WriteLine("Você tem " + gemasPrata + " gemas de prata");

//1.4: Verificador de condição 

bool jogadorTemChave;
bool portaEstaAberta;
Console.WriteLine("Você tem a chave? (true/false)");
jogadorTemChave = bool.Parse(Console.ReadLine());
Console.WriteLine("A porta está aberta? (true/false)");
portaEstaAberta = bool.Parse(Console.ReadLine());

if (jogadorTemChave == true || portaEstaAberta == true)
{
    bool podePassar = true;
    Console.WriteLine("Você pode passar.");
}

else
{
    Console.WriteLine("Você não pode passar.");
}

//1.5: Criador de título de herói 

Console.WriteLine("Qual o nome do seu herói?");
string nomeHeroi = Console.ReadLine();
Console.WriteLine("Qual sua classe?");
string classeHeroi = Console.ReadLine();
Console.WriteLine("Qual seu nível?");
int nivelHeroi = int.Parse(Console.ReadLine());
Console.WriteLine("Sr " + nomeHeroi + ", o " + classeHeroi + " de nível " + nivelHeroi);


//Sessão 2: O poder das escolhas 

//2.1: O bau do tesouro com armadilha 

Console.WriteLine("Qual seu nível de Ladinagem?");
int nivelLadinagem = int.Parse(Console.ReadLine());
if (nivelLadinagem > 15)
{
    Console.WriteLine("Você desarma a armadilha e ganha o tesouro.");
}

else if (nivelLadinagem > 10 && nivelLadinagem < 15)
{
    Console.WriteLine("Você desarma a armadilha, mas não ganha o tesouro.");
}

else
{
    Console.WriteLine("A armadilha dispara e voce perde HP.");
}

//2.2: Diálogo com consequências 

Console.WriteLine("Um guarda bloqueia seu caminho. Como você irá abordá-lo: [1]persuadir, [2]subornar ou [3]lutar.");
int ação = int.Parse(Console.ReadLine());
int hp = 40;
if (ação == 1)
{
    Random dado = new Random();
    int resultado = dado.Next(1, 21);
    if (resultado > 10)
    {
        Console.WriteLine("Você convenceu o guarda. Resultado do dado: " + resultado);
    }

    else
    {
        Console.WriteLine("O guarda ficou irritado. Resultado do dado: " + resultado);
    }

}

else if (ação == 2)
{
    Console.WriteLine("Quanto ouro você oferece?");
    int ouroOferecido = int.Parse(Console.ReadLine());
    if (ouroOferecido > 50)
    {
        Console.WriteLine("O guarda aceita e deixa você passar.");
    }

    else
    {
        Console.WriteLine("O guarda recusou sua oferta.");
    }

}

else if (ação == 3)
{
    hp -= 10;
    Console.WriteLine("Você lutou e passou, mas perdeu 10 de HP. HP restante: " + hp);
}

else
{
    Console.WriteLine("Escolha uma das opções 1, 2 ou 3");
}

//2.3: Sistema de dano elemental 

Console.WriteLine("Escolha o tipo do seu ataque (Fogo, Água ou Grama):");
string tipoAtaque = Console.ReadLine();
Console.WriteLine("Escolha o tipo do inimigo (Fogo, Água ou Grama):");
string tipoInimigo = Console.ReadLine();
if ((tipoAtaque == "Fogo" && tipoInimigo == "Grama") ||
    (tipoAtaque == "Água" && tipoInimigo == "Fogo") ||
    (tipoAtaque == "Grama" && tipoInimigo == "Água"))

{
    float multiplicador = 0.5f;
    Console.WriteLine("É super eficaz!");
}

else if (tipoAtaque == tipoInimigo)
{
    float multiplicador = 0.5f;
    Console.WriteLine("É pouco eficaz!");
}

else
{
    Console.WriteLine("Dano normal.");
}


//2.4: Verificador de acesso à guilda 

Console.WriteLine("Qual seu nível de Furtividade?");
int furtividade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual seu nível de Agilidade?");
int agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem Carta de Recomendação? (true/false)");
bool cartaRecomendacao = bool.Parse(Console.ReadLine());
if ((furtividade > 12 && agilidade > 14) || cartaRecomendacao)
{
    Console.WriteLine("Você foi aceito na Guilda dos Ninjas.");
}

else
{
    Console.WriteLine("Você foi recusado na Guilda dos Ninjas.");
}


//2.5: Clima e viagem 

Console.WriteLine("Qual o clima atual? (ensolarado, chuvoso ou nevando)");
string clima = Console.ReadLine();
Console.WriteLine("Qual sua montaria? (cavalo, lobo ou nenhuma)");
string montaria = Console.ReadLine();
int tempoViagem = 10;
if (clima == "chuvoso")
{
    tempoViagem += 2;
}

else if (clima == "nevando")
{

    if (montaria == "nenhuma")
    {
        tempoViagem += 5 * 2;
    }

    else
    {
        tempoViagem += 5;
    }

}

if (montaria == "cavalo")
{
    tempoViagem -= 3;
}

else if (montaria == "lobo")
{
    tempoViagem -= 4;
}
Console.WriteLine("Tempo estimado da viagem: " + tempoViagem + " horas");

//Sessão 3: O seletor de opções 

// 3.1: Máquina de poções 

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


//3.2: Teletransportador entre cidades 

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

//3.3: NPC com personalidades multiplas 

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

//3.4: Aplicando bonus de arma 

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

//3.5: Conversor de runa para elemento 

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

//Seção 4 - A bolsa dimensional

//4.1: Cinto de utilidades 

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


//4.2: Histórico de batalha 

int[] dano = new int[5];
Console.WriteLine("Digite o dano causado nos últimos 5 turnos:");
int totalDano = 0;
for (int i = 0; i < dano.Length; i++)
{
    dano[i] = int.Parse(Console.ReadLine());
    totalDano += dano[i];
}
float danoMedio = totalDano / (float)dano.Length;
Console.WriteLine("Dano total: " + totalDano + "; Dano médio: " + danoMedio);


//4.3: Procurando o ingrediente 

string[] ingredientes = { "Ruga de Bruxa", "Lágrima Cristalina", "Língua de Cobra", "Olho de Jacaré", "Asa de Borboleta", "Cabelo de Unicórnio" };
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
if (encontrado)
{
    Console.WriteLine("Ingrediente não encontrado.");
}


//4.4: Invertendo a ordem dos feitiços 

string[] feitiços = { "Raio de Fogo", "Coluna de Água", "Bola Ultra Congelante", "Choro de Milagre" };
Console.WriteLine("Feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}


//4.5Inventário de itens raros 

string[] nomesItens = { "Espada sangrenta", "Agua sagrada", "Trevo do sucesso" };
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


//Sessão 5: Os ciclos do tempo 

//5.1: Forjando a espada 

for (int i = 1; i <= 8; i++) 
{
    Console.WriteLine("Martelada #" + i + "...");
    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }


    //5.2: Escalando a torre infinita 

    int andar = 1;
    Console.WriteLine("Digite 'subir' para subir mais andares. Digite qualquer outra coisa para parar.");
    string comando = Console.ReadLine();
    while (comando == "subir")
    {
        andar++;
        Console.WriteLine("Você chegou ao andar #" + andar + "!");
        comando = Console.ReadLine();
    }

    //5.3: Adivinhe o codigo secreto 

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


            //5.4: Coletando recursos 

            int totalMadeira = 0;
            Random rng = new Random();
            while (totalMadeira < 50)
            {
                int coleta = rng.Next(5, 11);
                totalMadeira += coleta;
                Console.WriteLine("Você coletou " + coleta + " madeiras. Total: " + totalMadeira);
            }


            //5.5: Batalha final 

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