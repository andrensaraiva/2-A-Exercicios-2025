// Seção 1: O Domínio das Variáveis e Tipos (5 Exercícios) 
//1. Fixa de Monstro:
Console.WriteLine("1. Ficha de Monstro:");
Console.WriteLine("Escreva o nome do monstro");
string nomeDoMonstro = Console.ReadLine();
int hp = 10;
float velocidadeDeAtaque = 20.5f;
bool chefeDeFase = false;
Console.WriteLine("Nome: " + nomeDoMonstro + " HP: " + hp + " Velocidade: " + velocidadeDeAtaque + ";");

//2. Calculadora de Batalha:
Console.WriteLine("2. Calculadora de Batalha:");
int danoDoJogador;
int defesaDoMonstro;
Console.WriteLine("Digite os valores do seu dano e a defesa do monstro");
danoDoJogador = int.Parse(Console.ReadLine());
defesaDoMonstro = int.Parse(Console.ReadLine());
int danoFinal = danoDoJogador - defesaDoMonstro;
Console.WriteLine("O dano final é: " + danoFinal);
float vidaRestantePercentual = 100f;
Console.WriteLine("A vida restante é " + (vidaRestantePercentual - danoFinal));

//3. Conversor de Moedas Arcanas:
Console.WriteLine("3.Conversor de Moedas Arcanas:");
float dragaoDeOuro = 15.5f;
Console.WriteLine("Quantos Dragões de Ouro ele possui");
int dragoesDoJogador = int.Parse(Console.ReadLine());
float gemasDePrata = dragoesDoJogador * dragaoDeOuro;
Console.WriteLine("Você tem " + gemasDePrata + " gemas de prata");

//4. Verificador de Condição:
Console.WriteLine("4. Verificador de Condição:");
bool jogadorTemChave;
bool portaEstaAberta;
bool podePassar;
Console.WriteLine("Defina se o jogador tem chave e se a porta está aberta com true ou false ");
jogadorTemChave = bool.Parse(Console.ReadLine());
portaEstaAberta = bool.Parse(Console.ReadLine());
if (jogadorTemChave || portaEstaAberta)
{
    bool podepassar = true;
    Console.WriteLine("Você pode passar pela porta");
}
else
{
    Console.WriteLine("Sua entrada foi negada");
}

//5. Criador de Título de Herói:
Console.WriteLine("5. Criador de Título de Herói:");
Console.WriteLine("Qual seu nome de herói?");
string nomeHeroi = Console.ReadLine();

Console.WriteLine("Qual sua classe?");
string classeHeroi = Console.ReadLine();

Console.WriteLine("Qual seu nível?");
int nivelHeroi = int.Parse(Console.ReadLine());

string tituloCompleto = "Sir " + nomeHeroi + ", o " + classeHeroi + " de Nível " + nivelHeroi;
Console.WriteLine(tituloCompleto);


//Seção 2: O Poder das Escolhas (if-else) (5 Exercícios)
//1. O Baú do Tesouro com Armadilha: 
Console.WriteLine("1. O Baú do Tesouro com Armadilha:");
Console.WriteLine("Digite seu nível de Ladinagem:");
int nivelLadinagem = int.Parse(Console.ReadLine());

if (nivelLadinagem > 15)
{
    Console.WriteLine("Você desarmou a armadilha e ganhou o tesouro!");
}
else if (nivelLadinagem > 10)
{
    Console.WriteLine("Você desarmou a armadilha, mas não ganhou nada...");
}
else
{
    hp -= 20;
    Console.WriteLine("A armadilha disparou! Você perdeu 20 de HP. HP restante: " + hp);
}

//2. Diálogo com Consequências: 
Console.WriteLine("2. Diálogo com Consequências:");
Console.WriteLine("O guarda bloqueia seu caminho. O que você faz? (persuadir, subornar ou lutar)");
string acaoGuarda = Console.ReadLine();

if (acaoGuarda == "persuadir")
{
    Random dado = new Random();
    int resultado = dado.Next(1, 21);
    if (resultado > 10)
    {
        Console.WriteLine("Você convenceu o guarda! Resultado do dado: " + resultado);
    }
    else
    {
        Console.WriteLine("O guarda ficou irritado! Resultado do dado: " + resultado);
    }
}
else if (acaoGuarda == "subornar")
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
else if (acaoGuarda == "lutar")
{
    hp -= 10;
    Console.WriteLine("Você lutou e passou, mas perdeu 10 de HP. HP restante: " + hp);
}

//3. Sistema de Dano Elemental:
Console.WriteLine("3. Sistema de Dano Elemental:");
Console.WriteLine("Escolha o tipo do seu ataque (Fogo, Água ou Grama):");
string tipoAtaque = Console.ReadLine();

Console.WriteLine("Escolha o tipo do inimigo (Fogo, Água ou Grama):");
string tipoInimigo = Console.ReadLine();

float multiplicador = 1f;

if ((tipoAtaque == "Fogo" && tipoInimigo == "Grama") ||
    (tipoAtaque == "Água" && tipoInimigo == "Fogo") ||
    (tipoAtaque == "Grama" && tipoInimigo == "Água"))
{
    multiplicador = 2f;
    Console.WriteLine("É super eficaz!");
}
else if (tipoAtaque == tipoInimigo)
{
    multiplicador = 0.5f;
    Console.WriteLine("É pouco eficaz!");
}
else
{
    Console.WriteLine("Dano normal.");
}

Console.WriteLine("Multiplicador de dano: " + multiplicador);

//4. Verificador de Acesso à Guilda: 
Console.WriteLine("4. Verificador de Acesso à Guilda:");
Console.WriteLine("Digite seu nível de Furtividade:");
int furtividade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu nível de Agilidade:");
int agilidade = int.Parse(Console.ReadLine());

Console.WriteLine("Você tem Carta de Recomendação? (true/false)");
bool cartaRecomendacao = bool.Parse(Console.ReadLine());

if ((furtividade > 12 && agilidade > 14) || cartaRecomendacao)
{
    Console.WriteLine("Você foi aceito na Guilda dos Ladrões!");
}
else
{
    Console.WriteLine("Você foi recusado na Guilda dos Ladrões.");
}

//5. Clima e Viagem:
Console.WriteLine("5. Clima e Viagem:");
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


//Seção 3: O Seletor de Opções (switch) (5 Exercícios) 
//1. Máquina de Poções: 
Console.WriteLine("1. Máquina de Poções:");
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

//2. Teletransportador entre Cidades: 
Console.WriteLine("2. Teletransportador entre Cidades:");
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

//3. NPC com Personalidades Múltiplas: 
Console.WriteLine("3. NPC com Personalidades Múltiplas:");
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

//4. Aplicando Bônus de Arma: 
Console.WriteLine("4. Aplicando Bônus de Arma:");
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

//5. Conversor de Runa para Elemento: 
Console.WriteLine("5. Conversor de Runa para Elemento:");
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


//Seção 4: A Bolsa Dimensional (Arrays) (5 Exercícios)
//1. Cinto de Utilidades:
Console.WriteLine("1. Cinto de Utilidades:");
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

//2. Histórico de Batalha:
Console.WriteLine("2. Histórico de Batalha:");
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

//3. Procurando o Ingrediente: 
Console.WriteLine("3. Procurando o Ingrediente:");
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

//4. Invertendo a Ordem dos Feitiços:
Console.WriteLine("4. Invertendo a Ordem dos Feitiços:");
string[] feitiços = { "Bola de Fogo", "Escudo Arcano", "Raio Congelante", "Cura Rápida" };
Console.WriteLine("Feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}

//5. Inventário de Itens Raros:
Console.WriteLine("5. Inventário de Itens Raros:");
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


//Seção 5: Os Ciclos do Tempo (for e while) (5 Exercícios) 
//1. Forjando a Espada (for):
Console.WriteLine("1. Forjando a Espada (for):");
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Martelada #" + i + "...");
    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }
}

//2. Escalando a Torre Infinita (while): 
Console.WriteLine("2. Escalando a Torre Infinita (while):");
int andar = 1;
Console.WriteLine("Digite 'subir' para subir mais andares. Qualquer outra coisa para parar.");
string comando = Console.ReadLine();
while (comando == "subir")
{
    andar++;
    Console.WriteLine("Você chegou ao andar #" + andar + "!");
    comando = Console.ReadLine();
}

//3. Adivinhe o Código Secreto (while com limite):
Console.WriteLine("3. Adivinhe o Código Secreto (while com limite):");
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

//4. Coletando Recursos (while):
Console.WriteLine("4. Coletando Recursos (while):x");
int totalMadeira = 0;
Random rng = new Random();
while (totalMadeira < 50)
{
    int coleta = rng.Next(5, 11);
    totalMadeira += coleta;
    Console.WriteLine("Você coletou " + coleta + " madeiras. Total: " + totalMadeira);
}

//5. Batalha Final (while e for):
Console.WriteLine("5. Batalha Final (while e for):");
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