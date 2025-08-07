//Seção 1
//1 - Ficha de Monstro 
string nome = "Zap";
int hp = 20;
float velocidadeDeAtaque = 30.5f;
bool ehChefeDeFase = false;
Console.WriteLine("Ficha de Monstro:Nome=" + nome + " Hp=" + hp + " Velocidade de Ataque=" + velocidadeDeAtaque + " É chefe de fase=" + ehChefeDeFase);
//2 - Calculadora de Batalaha
Console.WriteLine("Digite um valor para dano do jogador e defesa do monstro");
int danoDoJogador = int.Parse(Console.ReadLine());
int defesaDoMonstro = int.Parse(Console.ReadLine());
int danoFinal = danoDoJogador - defesaDoMonstro;
Console.WriteLine("Dano final = " + danoFinal);
float vidaRestantePercentual = 100f;
Console.WriteLine("A vida restante é " + (vidaRestantePercentual - danoFinal));
//3 - Conversor de Moedas Arcanas
float dragaoDeOuro = 15.5f;
Console.WriteLine("Quantos Dragões de Ouro você possui?");
int dragoesDoJogador = int.Parse(Console.ReadLine());
float gemasDePrata = dragoesDoJogador * dragaoDeOuro;
Console.WriteLine("Você tem " + gemasDePrata + " gemas de prata");
//4 - Verificador de Condição
Console.WriteLine("Você tem a chave? (Responda com true ou false)");
bool jogadorTemChave = bool.Parse(Console.ReadLine());
Console.WriteLine("A porta está aberta? (Responda com true ou false)");
bool portaEstaAberta = bool.Parse(Console.ReadLine());
bool podePassar;
if (portaEstaAberta == true || jogadorTemChave == true)
{
    podePassar = true;
    Console.WriteLine("Você pode passar pela porta.");
}
else
{
    Console.WriteLine("Você não passa pela porta. Encontre a chave.");
}
//5 - Criador de Título de Herói
Console.WriteLine("Digite seu nome");
string nomeJogador = Console.ReadLine();
Console.WriteLine("DIgite sua classe");
string classe = Console.ReadLine();
Console.WriteLine("Digite seu nível");
int nivel = int.Parse(Console.ReadLine());
string tituloCompleto = "Sir " + nomeJogador + ", o " + classe + " de Nível " + nivel;
Console.WriteLine(tituloCompleto);


//Seção 2
//1 - O Baú do Tesouro com Armadilha
Console.WriteLine("Digite o seu nível de Ladinagem");
int nivelDeLadinagem = int.Parse(Console.ReadLine());
if (nivelDeLadinagem < 15)
{
    Console.WriteLine("Parabéns! Você desarmou a armadilha e ganhou um tesouro");
}
else if (nivelDeLadinagem > 10 && nivelDeLadinagem < 15)
{
    Console.WriteLine("Você desarmou a armadilha!");
}
else
{
    hp -= 20;
    Console.WriteLine("Você dispara a armadilha e perde 20 de HP. HP restante:" + hp);
}


//Seção 3
// 1 - Máquina de Poções
int ouro = 100; // exemplo de ouro inicial
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
//2 - Teletransportador entre Cidades
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
//3 - NPC com Personalidades Múltiplas
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
//4 - Aplicando Bônus de Arma
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
//5 - Conversor de Runa para Elemento
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


//Seção 4
//1 - Cinto de Utilidades
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
//2 - Histórico de Batalha
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
//3 - Procurando o Ingrediente
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
//4 - Invertendo a Ordem dos Feitiços
string[] feitiços = { "Bola de Fogo", "Escudo Arcano", "Raio Congelante", "Cura Rápida" };
Console.WriteLine("Feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}
//5 - Inventário de Itens Raros
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


//Seção 5
//1 - Forjando a Espada
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Martelada #" + i + "...");
    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }
}
//2 - Escalando a Torre Infinita
int andar = 1;
Console.WriteLine("Digite 'subir' para subir mais andares. Qualquer outra coisa para parar.");
string comando = Console.ReadLine();
while (comando == "subir")
{
    andar++;
    Console.WriteLine("Você chegou ao andar #" + andar + "!");
    comando = Console.ReadLine();
}
//3 - Adivinhe o Código Secreto
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
//4 - Coletando Recursos
int totalMadeira = 0;
Random rng = new Random();
while (totalMadeira < 50)
{
    int coleta = rng.Next(5, 11);
    totalMadeira += coleta;
    Console.WriteLine("Você coletou " + coleta + " madeiras. Total: " + totalMadeira);
}
//5 - Batalha Final 
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
