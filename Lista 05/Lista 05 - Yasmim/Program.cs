//1.Menu de Taverna Simples1. Menu de Taverna Simples
Console.WriteLine("[1] Cerveja Amanteigada [2] Hidromel dos Anões [3] Água Fresca");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Uma caneca espumante de Cerveja Amanteigada para você!");
        break;
    case 2:
        Console.WriteLine("Hidromel dos Anões, forte e adocicado! Saúde!");
        break;
    case 3:
        Console.WriteLine("Água Fresca para reidratar o aventureiro!");
        break;
    default:
        Console.WriteLine("Desculpe, não temos essa opção no menu.");
        break;
}

//2.Escolha de Classe Inicial
Console.WriteLine("[G] Guerreiro[M] Mago[A] Arqueiro");
char classe = char.ToUpper(char.Parse(Console.ReadLine()));

switch (classe)
{
    case 'G':
        Console.WriteLine("Você escolheu ser um valente Guerreiro! Força e honra!");
        break;
    case 'M':
        Console.WriteLine("Você escolheu o caminho arcano do Mago! Sabedoria e poder!");
        break;
    case 'A':
        Console.WriteLine("Você escolheu a precisão do Arqueiro! Agilidade e visão!");
        break;
    default:
        Console.WriteLine("Essa classe não existe em nossos registros. Tente novamente.");
        break;
}

//3.Reação do NPC ao Humor
Console.WriteLine("Qual o humor do NPC? (1=Feliz, 2=Neutro, 3=Irritado)");
int humor = int.Parse(Console.ReadLine());

switch (humor)
{
    case 1:
        Console.WriteLine("O NPC sorri e diz: 'Que dia adorável para uma aventura, não acha?'");
        break;
    case 2:
        Console.WriteLine("O NPC acena brevemente e diz: 'Olá, viajante.'");
        break;
    case 3:
        Console.WriteLine("O NPC franze a testa e resmunga: 'O que você quer? Estou ocupado!'");
        break;
    default:
        Console.WriteLine("O NPC parece... confuso.");
        break;
}

// 4.Seleção de Dificuldade do Jogo
Console.WriteLine("[1] Fácil[2] Normal[3] Difícil[4] Pesadelo");
int dificuldade = int.Parse(Console.ReadLine());

switch (dificuldade)
{
    case 1:
        Console.WriteLine("HP dos Inimigos: 50, Dano do Jogador: +20%");
        break;
    case 2:
        Console.WriteLine("HP dos Inimigos: 100, Dano do Jogador: Normal");
        break;
    case 3:
        Console.WriteLine("HP dos Inimigos: 150, Dano do Jogador: -10%, Recursos Escassos");
        break;
    case 4:
        Console.WriteLine("HP dos Inimigos: 200, Dano do Jogador: -25%, Inimigos Mais Agressivos");
        break;
    default:
        Console.WriteLine("Dificuldade não reconhecida. Padrão: Normal.");
        break;
}

//5.Sistema de Resposta a Comandos
Console.WriteLine("Digite um comando: (olhar, pegar item, usar pocao, atacar)");
string comando = Console.ReadLine().ToLower();

switch (comando)
{
    case "olhar":
        Console.WriteLine("Você observa ao redor. É uma sala escura e úmida...");
        break;
    case "pegar item":
        bool itemDisponivel = true;
        if (itemDisponivel)
            Console.WriteLine("Você pegou um item raro!");
        else
            Console.WriteLine("Não há nada para pegar.");
        break;
    case "usar pocao":
        Console.WriteLine("Você bebe uma poção e sente suas feridas se fechando.");
        break;
    case "atacar":
        Console.WriteLine("Você se prepara para o combate! Em quem você ataca?");
        break;
    default:
        Console.WriteLine($"Comando não reconhecido: '{comando}'");
        break;
}

//6.InventarioInicial()
    string[] inventarioInicial = { "Espada Curta", "Escudo de Madeira", "Poção de Cura Menor" };
    Console.WriteLine("Itens iniciais:");
    Console.WriteLine(inventarioInicial[0]);
    Console.WriteLine(inventarioInicial[1]);
    Console.WriteLine(inventarioInicial[2]);

//7.ListaDeTarefas()
    string[] lista = { "Falar com o Ferreiro", "Comprar Pão na Padaria", "Investigar o Poço Velho" };
    Console.WriteLine("Tarefas Pendentes:");
    Console.WriteLine(lista[0]);
    Console.WriteLine(lista[2]);

//8.PontuacoesJogos()
int[] ultimasPontuacoes = new int[3];
int soma = 0;
for (int i = 0; i < 3; i++)
{
    Console.Write("Digite a pontuação" + {i + 1}:);
    ultimasPontuacoes[i] = int.Parse(Console.ReadLine());
    soma += ultimasPontuacoes[i];
}

int maior = ultimasPontuacoes[0];
if (ultimasPontuacoes[1] > maior) maior = ultimasPontuacoes[1];
if (ultimasPontucoes[2] > maior) maior = ultimasPontuacoes[2];

Console.WriteLine("Pontuação total: " + soma);
Console.WriteLine("Maior pontuação: " + maior);

//9.MembrosGuilda()
string[] membrosGuilda = { "Elara", "Thorin", "Lyra", "Kael" };

Console.Write("Digite um número de 0 a 3: ");
int indice = int.Parse(Console.ReadLine());

if (indice >= 0 && indice < membrosGuilda.Length)
{
    Console.WriteLine("Membro escolhido: " + membrosGuilda[indice]);
}
else
{
    Console.WriteLine("Não há membro com esse código.");
}

//10.MapaTesouro()
int[] coordenadasX = { 5, 8, 3 };
int[] coordenadasY = { 10, 12, 7 };

Console.WriteLine("O mapa do tesouro indica os seguintes passos:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Passo" + {i + 1}: + "Vá para X=" + {coordenadasX[i]} + ", Y=" + {coordenadasY[i]});
}

Console.Write("Digite sua coordenada X atual: ");
int xAtual = int.Parse(Console.ReadLine());
Console.Write("Digite sua coordenada Y atual: ");
int yAtual = int.Parse(Console.ReadLine());

if (xAtual == coordenadasX[0] && yAtual == coordenadasY[0])
{
    Console.WriteLine("Você está no local do primeiro passo do mapa!");
}
else
{
    Console.WriteLine("Você ainda não chegou no primeiro passo do mapa.");
}


//11.ContagemMagia()
for (int i = 5; i >= 1; i--)
{
    Console.WriteLine("Canalizando..." + {i}s);
}
Console.WriteLine("Feitiço Concluído!");

//12.ExibirInventario()
string[] inventarioInicial = { "Espada Curta", "Escudo de Madeira", "Poção de Cura Menor" };

for (int i = 0; i < inventarioInicial.Length; i++)
{
    Console.WriteLine("Slot" + {i}: {inventarioInicial[i]});
}

//13.DanoTurnos()
int hp = 50;
    for (int i = 1; i <= 4; i++)
    {
        hp -= 5;
        Console.WriteLine("Turno" + {i} + ": Dano 5. HP restante:" + {hp});
        if (hp <= 0)
        {
            Console.WriteLine("Inimigo sucumbiu ao veneno!");
            break;
        }
    }

//14.BuscarPocao()
    string[] inventario = { "Espada", "Mapa", "Poção", "Chave", "Corda" };
    bool achou = false;
    for (int i = 0; i < inventario.Length; i++)
        if (inventario[i] == "Poção")
        {
            Console.WriteLine("Poção de Cura encontrada no slot" + {i});
            achou = true; break;
        }
    if (!achou)
{
    Console.WriteLine("Nenhuma Poção de Cura no inventário.");
}

//15.InvestimentoJuros()
Console.Write("Digite o valor inicial do investimento: ");
float principal = float.Parse(Console.ReadLine());
Console.Write("Digite a taxa de juros anual (ex: 0.05 para 5%): ");
float taxa = float.Parse(Console.ReadLine());
Console.Write("Por quantos anos o dinheiro ficará investido? ");
int anos = int.Parse(Console.ReadLine());
for (int ano = 1; ano <= anos; ano++)
{
    float jurosDoAno = principal * taxa;
    principal += jurosDoAno;
    Console.WriteLine("Ano" + {ano}: + "Saldo =" + {principal:F2});
}

Console.WriteLine("Montante total acumulado após" + {anos} "anos:" + {principal:F2});

//16.AdivinheNumero()

int numeroSecreto = 7;
int palpite;
Console.Write("Tente adivinhar o número secreto: ");
palpite = int.Parse(Console.ReadLine());

while (palpite != numeroSecreto)
{
    Console.Write("Errado! Tente novamente: ");
    palpite = int.Parse(Console.ReadLine());
}

Console.WriteLine("Parabéns! Você acertou o número secreto!");

//17.MenuPersistente()
bool sairDoJogo = false;
while (!sairDoJogo)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("[1] Novo Jogo");
    Console.WriteLine("[2] Carregar");
    Console.WriteLine("[3] Sair");
    Console.Write("Escolha: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Iniciando novo jogo...");
            break;
        case 2:
            Console.WriteLine("Carregando jogo...");
            break;
        case 3:
            sairDoJogo = true;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Console.WriteLine("Obrigado por jogar!");


//18.BatalhaGoblin()
int hpGoblin = 30;
int danoElara = 10;

while (hpGoblin > 0)
{
    Console.WriteLine("Elara ataca o Goblin!");
    hpGoblin -= danoElara;
    Console.WriteLine("HP do Goblin:" + {hpGoblin});
    Console.ReadLine(); // Pausa entre os turnos
}

Console.WriteLine("Goblin derrotado!");


//19.ColetarCristais()
int total = 0;
    while (total < 20)
    {
        Console.Write("Quantos cristais encontrou (1 a 3)? ");
        int encontrados = int.Parse(Console.ReadLine());
        total += encontrados;
        Console.WriteLine("Total:" + {total}/20);
    }
    Console.WriteLine("Meta de Cristais Mágicos alcançada!");


//20.TorreDesafios()
    int andar = 1, max = 5, hp = 20;
    while (andar <= max && hp > 0)
    {
        Console.WriteLine("Andar" + {andar}`+ ". Monstro (M) ou Tesouro (T)?");
        string evento = Console.ReadLine().ToUpper();
        if (evento == "M")
        {
            hp -= 5;
            Console.WriteLine($"Um monstro te ataca! HP: {hp}");
            if (hp <= 0)
            {
                Console.WriteLine("Elara foi derrotada..."); break;
            }
        }
        else if (evento == "T")
        {
            Console.WriteLine("Você encontra um pequeno tesouro!");
        }
        andar++;
    }
    if (andar > max && hp > 0)
        Console.WriteLine("Parabéns! Você chegou ao topo da torre!");

