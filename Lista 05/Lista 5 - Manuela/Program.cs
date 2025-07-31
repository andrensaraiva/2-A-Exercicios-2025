// See https://aka.ms/new-console-template for more information
// Menu de taverna simples
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("O que você deseja? 1 - Cerveja amanteigada, 2 - Hidromel dos anões, 3 - Água Fresca ");
Console.WriteLine("Digite o numero de sua escolha");
{
    int bebida = int.Parse(Console.ReadLine());
    switch (bebida)
    {
        case 1:
            Console.WriteLine("Uma caneca espumante de Cerveja para você! ");
            break;
        case 2:
            Console.WriteLine("Hidromel dos anões, forte e adocicado!");
            break;
        case 3:
            Console.WriteLine("Água fresca para reidratar o aventureiro!");
            break;
        default:
            Console.WriteLine("Desculpe, não temos essa opção no menu");
            break;
    }
}


// Escolha de classe inicial
Console.WriteLine("Escolha sua classe: G - Guerreiro, M - Mago, A - Arqueiro");
Console.WriteLine("Digite a letra da classe");

{
    string classe = Console.ReadLine();
    switch (classe)
    {
        case "G":
            Console.WriteLine("Você escolheu ser um valente guerreiro");
            break;
        case "M":
            Console.WriteLine("Você escolheu o caminho arcano do Mago");
            break;
        case "A":
            Console.WriteLine("Você escolheu a precisão do Arqueiro");
            break;
        default:
            Console.WriteLine("Essa classe não existe em nossos registros");
            break;
    }
}


// Reação do NPC ao humor
Console.WriteLine("Defina o humor do NPC - 1, 2 ou 3");

{
    int humor = int.Parse(Console.ReadLine());
    switch (humor)
    {
        case 1:
            Console.WriteLine("O NPC sorri e diz: 'Que dia adorável para uma aventura, não acha? ");
            break;
        case 2:
            Console.WriteLine("O NPC acena brevemente e diz: 'Olá, viajante.");
            break;
        case 3:
            Console.WriteLine("O NPC franze a testa e resmunga: 'O que você quer? Estou ocupado!'");
            break;
        default:
            Console.WriteLine("O NPC parece... confuso");
            break;
    }
}


// Seleção de Dificuldade do Jogo
Console.WriteLine("Escolha a dificuldade: [1] Fácil - Aventura Relaxante, [2] Normal - Desafio Equilibrado, [3] Difícil - Sobrevivência Intensa, [4] Pesadelo - Sofrimento Garantido");

{
    int dificuldade = int.Parse(Console.ReadLine());
    switch (dificuldade)
    {
        case 1:
            Console.WriteLine("HP dos Inimigos: 50, Dano do Jogador: +20% ");
            break;
        case 2:
            Console.WriteLine("HP dos Inimigos: 100, Dano do Jogador: Normal.");
            break;
        case 3:
            Console.WriteLine("HP dos Inimigos: 150, Dano do Jogador: -10%, Recursos Escassos");
            break;
        case 4:
            Console.WriteLine("HP dos Inimigos: 200, Dano do Jogador: -25%, Inimigos Mais Agressivos");
            break;
        default:
            Console.WriteLine("Dificuldade não reconhecida. Padrão: Normal");
            break;
    }
}


// Sistema de Resposta a Comandos de Jogo:
Console.WriteLine("digite um comando (ex: olhar, pegar item, usar poção, atacar).");

{
    string comando = Console.ReadLine();
    switch (comando)
    {
        case "olhar":
            Console.WriteLine("Você observa ao redor. É uma sala escura e úmida... ");
            break;
        case "pegar item":
            Console.WriteLine("O que você gostaria de pegar?");
            string item = (Console.ReadLine());

            if (item == "Espada")
            {
                Console.WriteLine("Você ganhou uma espada.");
            }
            else if (item == "Escudo")
            {
                Console.WriteLine("Você ganhou um escudo.");
            }
            else if (item == "Armadura")
            {
                Console.WriteLine("Você ganhou uma armadura");
            }
            else
            {
                Console.WriteLine("Este item não está disponível");
            }
            break;
        case "usar poção":
            Console.WriteLine("Você bebe uma poção e sente suas feridas se fechando.");
            break;
        case "atacar":
            Console.WriteLine("Você se prepara para o combate! Em quem você ataca?");
            break;
        default:
            Console.WriteLine("Comando não reconhecido" + comando);
            break;
    }
}


// Dominando as Bolsas Dimensionais (Arrays)
//Inventário de Itens Iniciais:

string[] inventarioInicial = new string[3];
inventarioInicial[0] = "Espada Curta";
inventarioInicial[1] = "Escudo de Madeira";
inventarioInicial[2] = "Poção de cura menor";
Console.WriteLine("Seu herói começa com os seguintes itens:  " + inventarioInicial[0] + " " + inventarioInicial[1] + " " + inventarioInicial[2]);


//Lista de Tarefas do Herói:
string[] listaDeTarefas = new string[3];
listaDeTarefas[0] = "Falar com o Ferreiro";
listaDeTarefas[1] = "Comprar Pão na Padaria";
listaDeTarefas[2] = "Investigar o Poço Velho";
Console.WriteLine("Tarefas Pendentes");
Console.WriteLine(listaDeTarefas[0]);
Console.WriteLine(listaDeTarefas[2]);


//Pontuações dos Últimos Jogos:
int[] ultimasPontuacoes = new int[3];
Console.WriteLine("digite suas últimas 3 pontuações");
ultimasPontuacoes[0] = int.Parse(Console.ReadLine());
ultimasPontuacoes[1] = int.Parse(Console.ReadLine());
ultimasPontuacoes[2] = int.Parse(Console.ReadLine());
Console.WriteLine("A soma das 3 é " + (ultimasPontuacoes[0] + ultimasPontuacoes[1] + ultimasPontuacoes[2]));
if (ultimasPontuacoes[0] > ultimasPontuacoes[1] && ultimasPontuacoes[0] > ultimasPontuacoes[2])
{
    Console.WriteLine("O maior é o primeiro");
}
else if (ultimasPontuacoes[1] > ultimasPontuacoes[0] && ultimasPontuacoes[1] > ultimasPontuacoes[2])
{
    Console.WriteLine("O maior é o segundo");
}
else
{
    Console.WriteLine("O maior é o terceiro");
}


//Membros da Guilda:

string[] membrosGuilda = new string[4];
membrosGuilda[0] = "isabella";
membrosGuilda[1] = "leticia";
membrosGuilda[2] = "otavio";
membrosGuilda[3] = "gabriel";
Console.WriteLine("digitar um número de 0 a 3.");

int numero = int.Parse(Console.ReadLine());
switch (numero)
{
    case 0:
        Console.WriteLine(membrosGuilda[0]);
        break;
    case 1:
        Console.WriteLine(membrosGuilda[1]);
        break;
    case 2:
        Console.WriteLine(membrosGuilda[2]);
        break;
    case 3:
        Console.WriteLine(membrosGuilda[3]);
        break;
    default:
        Console.WriteLine("Não há membro com esse código.");
        break;
}


//Mapa do Tesouro Simplificado (Coordenadas):
int[] coordenadasX = new int[3];
coordenadasX[0] = 5;
coordenadasX[1] = 8;
coordenadasX[2] = 3;
int[] coordenadasY = new int[3];
coordenadasY[0] = 10;
coordenadasY[1] = 12;
coordenadasY[2] = 7;
Console.WriteLine("O mapa do tesouro indica os seguintes passos:");
Console.WriteLine("Passo 1: Vá para X= " + coordenadasX[0] + ", Y = " + coordenadasY[0]);
Console.WriteLine("Passo 2: Vá para X= " + coordenadasX[1] + ", Y = " + coordenadasY[1]);
Console.WriteLine("Passo 3: Vá para X= " + coordenadasX[2] + ", Y = " + coordenadasY[2]);




//Dominando o Contador Incansável (for loop)
//Contagem Regressiva para Magia:

for (int i = 5; i >= 1; i--)

{

    Console.WriteLine("Canalizando... " + i);

}

Console.WriteLine("Feitiço Concluído!");



//Exibindo Todos os Itens do Inventário (com for):
string[] inventarioInicial2 = new string[3];
inventarioInicial2[0] = "Espada Curta";
inventarioInicial2[1] = "Escudo de Madeira";
inventarioInicial2[2] = "Poção de cura menor";
for (int i = 0; i < inventarioInicial2.Length; i++)
{
   Console.WriteLine("Item " + (i + 1) + ": " + inventarioInicial2[i]);
}


//Calculando Dano ao Longo de Vários Turnos:
{
    int hpInimigo = 50;
    int dano = 5;
    for (int i = 0; i <= 4; i++)
    {
        hpInimigo -= 5;
        Console.WriteLine("turno " + i + ": inimigo sofre 5 de dano do inimigo. HP restante: " + hpInimigo);

        if (hpInimigo <= 0)
        {
            Console.WriteLine("Inimigo sucumbiu ao veneno!");
            break;
        }
    }
}


//Encontrando um Item Específico no Inventário:
{
    string[] inventario = new string[5];
    inventario[0] = "Espada Curta";
    inventario[1] = "Escudo de Madeira";
    inventario[2] = "Poção de cura";
    inventario[3] = "Adaga ";
    inventario[4] = "Ataduras";
    for (int i = 0; i < inventario.Length; i++)
        if (inventario[i] == inventario[2])
        {
            Console.WriteLine("Poção de cura encontrada no slot " + i);
        }
}


    //Simulação de Investimento com Juros Compostos (por N Anos):
    Console.WriteLine("Qual o valor do investimento inicial?");
    float investimento = float.Parse(Console.ReadLine());
    Console.WriteLine("Qual a taxa de juros anual?");
    float taxa = float.Parse(Console.ReadLine());
    Console.WriteLine("Por quantos anos o dinheiro ficará investido?");
    int anos = int.Parse(Console.ReadLine());
for (int i = 1; i <= anos; i++)
{
    float jurosDoAno = investimento * taxa;
    investimento += jurosDoAno;
    Console.WriteLine("Ano " + i + ": Saldo = R$ " + investimento);
}
{ 
    Console.WriteLine("Montante final acumulado após " + anos + " anos: R$ " + investimento);
}



//Seção 4: Dominando o Guardião da Condição (while loop)
//Adivinhe o Número Secreto (Simplificado):
int numeroSecreto = 7;
Console.WriteLine("Digite um palpite para o número secreto");
int palpite = int.Parse(Console.ReadLine());
while (palpite != 7)
{
    Console.WriteLine("Errado! Tente novamente:");
    palpite = int.Parse(Console.ReadLine());
}
if (palpite == 7)
    Console.WriteLine("Parabéns! Você acertou o número secreto!");


//Menu de Jogo Persistente:
bool sairDoJogo = false;
while (sairDoJogo == false)
{
    Console.WriteLine("[1] Novo Jogo, [2] Carregar, [3] Sair");
    int escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Iniciando novo jogo...");
            break;
        case 2:
            Console.WriteLine("Carregando jogo...");
            break;
        case 3:
            Console.WriteLine("Saindo do jogo...");
            sairDoJogo = true;
            break;
    }
}
    Console.WriteLine("Obrigado por jogar!");



//Batalha Contra Monstro (até HP zerar):
int hpGoblin = 30;
int danoElara = 10;
 while (hpGoblin > 0)
{
    Console.WriteLine("Elara ataca Goblin!" );
    hpGoblin -= danoElara;
    Console.WriteLine("HP do Goblin: " + hpGoblin );
    Console.ReadLine();

}
Console.WriteLine("Goblin derrotado");



//Coletando Recursos até a Meta:
int cristaisColetados = 0;
int metaCristais = 20;
while (cristaisColetados < metaCristais)
{
    Console.WriteLine("Quantos cristais Elara encontrou nessa tentativa (1 a 3)?");
    int cristaisEncontrados = int.Parse(Console.ReadLine());

        
    cristaisColetados += cristaisEncontrados ;
    Console.WriteLine("Total de Cristais Coletados: " + cristaisColetados);
}
Console.WriteLine("Meta de Cristais Mágicos alcançada!");



// Escalada de Torre com Desafios Aleatórios (Simplificado):
int andarAtual = 1;
int totalAndares = 5;
int hpElara = 20;

while (andarAtual <= totalAndares && hpElara > 0)
{
    Console.WriteLine("Você está no andar " + andarAtual );
    Console.WriteLine("Monstro (M) ou Tesouro (T) neste andar?");
    string escolha = Console.ReadLine();

    if (escolha == "M" )
    {
        hpElara -= 5;
        Console.WriteLine("Um monstro te ataca! HP de Elara: " + hpElara);

        if (hpElara <= 0)
        {
            Console.WriteLine("Elara foi derrotada...");
            
        }
    }
    else if (escolha == "T")
    {
        Console.WriteLine("Você encontra um pequeno tesouro!");
    }
    else
    {
        Console.WriteLine("Escolha inválida. Digite M ou T.");
       
    }

    andarAtual++;
}

if (andarAtual > totalAndares && hpElara > 0)
{
    Console.WriteLine("Parabéns! Você chegou ao topo da torre!");
}



// Desafios Mistos - Integrando Tudo!
// Quiz Simples com Pontuação
string[] perguntas = {
            "Qual a capital da França?",
            "Qual é 2 + 2?",
            "Qual a cor do céu em um dia sem nuvens?"
        };
string[] respostasCorretas = { "paris", "4", "azul" };
int acertos = 0;

Console.WriteLine("Quiz");
for (int i = 0; i < perguntas.Length; i++)
{
    Console.WriteLine(perguntas[i]);
    string respostaJogador = Console.ReadLine().ToLower();

    if (respostaJogador == respostasCorretas[i])
    {
        Console.WriteLine("Correto!");
        acertos++;
    }
    else
    {
        Console.WriteLine("Errado!");
    }
}

Console.WriteLine($"Você acertou {acertos} de {perguntas.Length} perguntas.");



//Escolha de Power-up e Efeito
int hpAtual = 80;

Console.WriteLine("Escolha um Power-up");
Console.WriteLine("[1] Super Força");
Console.WriteLine("[2] Invisibilidade");
Console.WriteLine("[3] Cura Rápida");
Console.Write("Digite o número da sua escolha: ");
int escolha1 = int.Parse(Console.ReadLine());

switch (escolha1)
{
    case 1:
        Console.WriteLine("Você sente uma força incrível percorrendo seu corpo!");
        break;
    case 2:
        Console.WriteLine("Você fica invisível por alguns segundos.");
        break;
    case 3:
        hpAtual += 20;
        Console.WriteLine($"Você recupera HP! Seu HP agora é: {hpAtual}");
        break;
    default:
        Console.WriteLine("Escolha inválida, nenhum power-up aplicado.");
        break;
}


// Mini Jogo de Adivinhação com Tentativas Limitadas
int numeroSecreto1 = 7;

Console.WriteLine("Jogo de Adivinhação");
for (int tentativa = 1; tentativa <= 5; tentativa++)
{
    Console.Write($"Tentativa {tentativa}/5: Digite seu palpite: ");
    int palpite1 = int.Parse(Console.ReadLine());

    if (palpite1 == numeroSecreto1)
    {
        Console.WriteLine("Parabéns! Você acertou!");
        break;
    }
    else if (palpite1 < numeroSecreto1)
    {
        Console.WriteLine("O número secreto é maior!");
    }
    else
    {
        Console.WriteLine("O número secreto é menor!");
    }

    if (tentativa == 5)
    {
        Console.WriteLine($"Suas tentativas acabaram! O número secreto era {numeroSecreto1}.");
    }
}



// Inventário com Opção de Usar Item
string[] inventario1 = { "Poção", "Espada", "Mapa" };

Console.WriteLine("Seu inventário");
for (int i = 0; i < inventario1.Length; i++)
{
    Console.WriteLine($"Slot {i}: {inventario1[i]}");
}

Console.Write("Digite o número do slot do item que você quer usar: ");
int escolha2 = int.Parse(Console.ReadLine());

if (escolha2 >= 0 && escolha2 < inventario1.Length)
{
    string itemEscolhido = inventario1[escolha2];

    switch (itemEscolhido)
    {
        case "Poção":
            Console.WriteLine("Você bebe a poção e recupera HP!");
            break;
        case "Espada":
            Console.WriteLine("Você equipa a espada e se prepara para lutar!");
            break;
        case "Mapa":
            Console.WriteLine("Você consulta o mapa e descobre um caminho secreto.");
            break;
        default:
            Console.WriteLine("Item desconhecido.");
            break;
    }
}
else
{
    Console.WriteLine("Slot inválido.");
}



//Simulador de Loja com Carrinho de Compras
string[] nomesItens = { "Espada", "Poção", "Escudo" };
float[] precosItens = { 100f, 25f, 75f };
float totalCompra = 0f;

Console.WriteLine("Bem-vindo à Loja do Aventureiro");
Console.WriteLine("Itens disponíveis:");
for (int i = 0; i < nomesItens.Length; i++)
{
    Console.WriteLine($"{nomesItens[i]}, R$ {precosItens[i]}");
}

while (true)
{
    Console.Write("Digite o nome do item para comprar ou 'finalizar' para encerrar: ");
    string escolha3 = Console.ReadLine().ToLower();

    if (escolha3 == "finalizar")
    {
        break;
    }

    bool itemEncontrado = false;

    for (int i = 0; i < nomesItens.Length; i++)
    {
        if (escolha3 == nomesItens[i].ToLower())
        {
            totalCompra += precosItens[i];
            Console.WriteLine($"Item {nomesItens[i]} adicionado ao carrinho.");
            itemEncontrado = true;
            break;
        }
    }

    if (!itemEncontrado)
    {
        Console.WriteLine("Item não encontrado.");
    }
}

if (totalCompra > 200f)
{
    Console.WriteLine("Você ganhou um desconto de 10%!");
    totalCompra *= 0.9f;
}

Console.WriteLine($"Total da compra: R$ {totalCompra}");




//Gerador de Masmorra Simples
string[] tiposDeSala = { "Corredor Vazio", "Sala com Armadilha", "Sala com Tesouro", "Sala com Monstro Fraco", "Chefe da Masmorra" };

Console.Write("Quantas salas terá a masmorra? ");
int totalSalas = int.Parse(Console.ReadLine());

for (int i = 0; i < totalSalas; i++)
{
    string tipoSala = tiposDeSala[i % tiposDeSala.Length];

    Console.WriteLine($"Sala {i + 1}: Você entra em um(a) {tipoSala}.");

    if (tipoSala == "Sala com Armadilha")
    {
        Console.WriteLine("Cuidado! Uma armadilha é ativada!");
    }
    else if (tipoSala == "Sala com Tesouro")
    {
        Console.WriteLine("Você encontra um baú repleto de ouro!");
    }
    else if (tipoSala == "Chefe da Masmorra")
    {
        Console.WriteLine("Prepare-se! O grande chefe aparece!");
    }
}


//Sistema de Diálogo com Múltiplas respostas e Consequências
string[] opcoes = { "Saudar educadamente", "Ignorar o NPC", "Insultar o NPC" };
int relacionamentoNPC = 0;

Console.WriteLine("O NPC pergunta algo para você. Como você responde?");
for (int i = 0; i < opcoes.Length; i++)
{
    Console.WriteLine($"[{i}] {opcoes[i]}");
}

Console.Write("Escolha o número da sua resposta: ");
int escolha4 = int.Parse(Console.ReadLine());

switch (escolha4)
{
    case 0:
        Console.WriteLine("NPC sorri e parece gostar de você.");
        relacionamentoNPC += 10;
        break;
    case 1:
        Console.WriteLine("NPC fica indiferente.");
        break;
    case 2:
        Console.WriteLine("NPC fica irritado.");
        relacionamentoNPC -= 10;
        break;
    default:
        Console.WriteLine("Resposta inválida. NPC fica confuso.");
        break;
}

if (relacionamentoNPC > 5)
{
    Console.WriteLine("O NPC parece gostar de você!");
}
else if (relacionamentoNPC < -5)
{
    Console.WriteLine("O NPC está muito irritado com você!");
}
else
{
    Console.WriteLine("O NPC não demonstra grandes emoções.");
}



//Batalha de Cartas Simplificada
int[] cartasJogador = { 5, 8, 6 };
int[] cartasOponente = { 4, 7, 9 };
int pontosJogador = 0;
int pontosOponente = 0;

Console.WriteLine("Batalha de Cartas");

for (int turno = 0; turno < 3; turno++)
{
    Console.WriteLine($"Turno {turno + 1}: Suas cartas são:");
    for (int i = 0; i < cartasJogador.Length; i++)
    {
        Console.WriteLine($"[{i}] Poder: {cartasJogador[i]}");
    }

    Console.Write("Escolha o índice da carta para jogar: ");
    int escolha = int.Parse(Console.ReadLine());

    int cartaJogador = cartasJogador[escolha];
    int cartaOponente = cartasOponente[turno]; 

    Console.WriteLine($"O oponente jogou uma carta de poder {cartaOponente}.");

    if (cartaJogador > cartaOponente)
    {
        Console.WriteLine("Você venceu o turno!");
        pontosJogador++;
    }
    else if (cartaJogador < cartaOponente)
    {
        Console.WriteLine("O oponente venceu o turno!");
        pontosOponente++;
    }
    else
    {
        Console.WriteLine("Empate!");
    }
}

Console.WriteLine($"Resultado final: Você {pontosJogador} x {pontosOponente} Oponente");
if (pontosJogador > pontosOponente)
{
    Console.WriteLine("Você venceu a partida!");
}
else if (pontosJogador < pontosOponente)
{
    Console.WriteLine("O oponente venceu a partida!");
}
else
{
    Console.WriteLine("A partida terminou empatada!");
}



//Decodificador de Mensagem Rúnica
string palavraSecreta = "TESOURO";
char[] progresso = new char[palavraSecreta.Length];
for (int i = 0; i < progresso.Length; i++)
{
    progresso[i] = '_';
}

int tentativas = 10;

while (tentativas > 0)
{
    Console.WriteLine("Palavra: " + new string(progresso));
    Console.Write("Digite uma letra: ");
    char letra = char.Parse(Console.ReadLine().ToUpper());
    bool acertou = false;

    for (int i = 0; i < palavraSecreta.Length; i++)
    {
        if (palavraSecreta[i] == letra)
        {
            progresso[i] = letra;
            acertou = true;
        }
    }

    if (acertou)
    {
        Console.WriteLine("Boa! Você encontrou uma letra.");
    }
    else
    {
        Console.WriteLine("Letra não encontrada.");
        tentativas--;
    }

    
    bool venceu = true;
    for (int i = 0; i < progresso.Length; i++)
    {
        if (progresso[i] == '_')
        {
            venceu = false;
            break;
        }
    }

    if (venceu)
    {
        Console.WriteLine("Parabéns! Você decifrou a palavra: " + palavraSecreta);
        return;
    }

    Console.WriteLine($"Tentativas restantes: {tentativas}");
}

Console.WriteLine("Suas tentativas acabaram! A palavra era: " + palavraSecreta);



//Aventura Textual com Inventário e Uso de Itens
string[] inventario2 = new string[3]; 
string salaAtual = "entrada"; 
bool jogando = true;

Console.WriteLine("Bem-vindo à Aventura!");

while (jogando)
{
    Console.WriteLine($"Você está na sala: {salaAtual}");
    Console.WriteLine("Comandos possíveis: olhar, pegar chave, usar chave, ir norte, inventario, sair");
    Console.Write("Digite seu comando: ");
    string comando = Console.ReadLine().ToLower();

    if (comando == "olhar")
    {
        if (salaAtual == "entrada")
        {
            Console.WriteLine("Você vê uma chave brilhando no chão.");
        }
        else if (salaAtual == "corredor")
        {
            Console.WriteLine("Você vê um grande portão trancado.");
        }
    }
    else if (comando == "pegar chave")
    {
        if (salaAtual == "entrada")
        {
            bool pegou = false;
            for (int i = 0; i < inventario2.Length; i++)
            {
                if (inventario2[i] == null)
                {
                    inventario2[i] = "chave";
                    pegou = true;
                    Console.WriteLine("Você pegou a chave.");
                    break;
                }
            }
            if (!pegou)
            {
                Console.WriteLine("Seu inventário está cheio!");
            }
        }
        else
        {
            Console.WriteLine("Não há chave aqui.");
        }
    }
    else if (comando == "usar chave")
    {
        bool temChave = false;
        for (int i = 0; i < inventario2.Length; i++)
        {
            if (inventario2[i] == "chave")
            {
                temChave = true;
                break;
            }
        }

        if (temChave)
        {
            if (salaAtual == "corredor")
            {
                Console.WriteLine("Você usa a chave e abre o portão! Vitória!");
                jogando = false;
            }
            else
            {
                Console.WriteLine("Não há onde usar a chave aqui.");
            }
        }
        else
        {
            Console.WriteLine("Você não tem uma chave.");
        }
    }
    else if (comando == "ir norte")
    {
        if (salaAtual == "entrada")
        {
            salaAtual = "corredor";
            Console.WriteLine("Você caminha para o corredor.");
        }
        else
        {
            Console.WriteLine("Não há como ir mais ao norte.");
        }
    }
    else if (comando == "inventario")
    {
        Console.WriteLine("Itens no inventário:");
        for (int i = 0; i < inventario2.Length; i++)
        {
            if (inventario2[i] != null)
            {
                Console.WriteLine($"Slot {i}: {inventario2[i]}");
            }
            else
            {
                Console.WriteLine($"Slot {i}: Vazio");
            }
        }
    }
    else if (comando == "sair")
    {
        jogando = false;
        Console.WriteLine("Você decidiu encerrar a aventura.");
    }
    else
    {
        Console.WriteLine("Comando não reconhecido.");
    }
}
    