// --- Declaração e Inicialização de Variáveis -------------------------------------------------------------------------------------------------------------------

// string: para guardar texto (nomes, mensagens, etc.)
string nomeDoJogador = "Lyra a Valente";
string nomeDoItemMagico = "Amuleto do Sol";

// int: para guardar números inteiros (HP, MP, nível, score, quantidade)
int hpAtual = 100;
int mpAtual = 50;
int nivelDoJogador = 5;
int quantidadeDePocoes = 3;

// float: para guardar números com casas decimais (dano preciso, velocidade, percentuais)
// Lembre-se do 'f' no final para literais float!
float danoBaseDaEspada = 12.5f;
float velocidadeDeMovimento = 3.2f;
float chanceDeCritico = 0.15f; // Representa 15%

// bool: para guardar valores verdadeiros ou falsos (condições, estados)
bool temChaveDaMasmorra = true;
bool inimigoEstaAtordoado = false;
bool missaoCompleta = false;

// --- Exibindo os Valores das Variáveis Usando Interpolação de String ---
Console.WriteLine("--- Ficha do Personagem ---");
Console.WriteLine($"Nome: {nomeDoJogador}");
Console.WriteLine($"Nível: {nivelDoJogador}");
Console.WriteLine($"HP: {hpAtual} | MP: {mpAtual}");
Console.WriteLine($"Poções no inventário: {quantidadeDePocoes}");

Console.WriteLine("\n--- Equipamento e Habilidades ---");
Console.WriteLine($"Item Mágico Principal: {nomeDoItemMagico}");
Console.WriteLine($"Dano da Espada: {danoBaseDaEspada}");
Console.WriteLine($"Velocidade: {velocidadeDeMovimento} unidades/s");
Console.WriteLine($"Chance de Crítico: {chanceDeCritico * 100}%"); // Multiplica por 100 para exibir como percentual

Console.WriteLine("\n--- Status da Aventura ---");
Console.WriteLine($"Possui a chave da masmorra? {temChaveDaMasmorra}");
Console.WriteLine($"Inimigo está atordoado? {inimigoEstaAtordoado}");
Console.WriteLine($"Missão principal completa? {missaoCompleta}");


// --- Lendo Entrada de Variaveis ----------------------------------------------------------------------------------------------------------------

Console.WriteLine("=== Bem-vindo ao Criador de Personagens! ===");

// Lendo uma string (nome do personagem)
Console.Write("Digite o nome do seu herói: ");
string nomeHeroi = Console.ReadLine(); // Console.ReadLine() sempre retorna string

// Lendo um inteiro (idade/nível) e convertendo com int.Parse()
Console.Write("Digite o nível inicial do seu herói (ex: 1): ");
string textoNivel = Console.ReadLine(); // Lê como texto
int nivelHeroi = int.Parse(textoNivel); // Converte o texto para inteiro

// Lendo um float (altura/peso/dinheiro inicial) e convertendo com float.Parse()
Console.Write("Quanto de ouro inicial seu herói possui (ex: 25.50)? ");
string textoOuro = Console.ReadLine();     // Lê como texto
float ouroHeroi = float.Parse(textoOuro); // Converte o texto para float

// Lendo um booleano (uma escolha sim/não) e convertendo com bool.Parse()
// O usuário DEVE digitar "true" ou "false" (sem aspas) para bool.Parse() funcionar.
Console.Write("Seu herói já começa com uma espada básica? (Digite 'true' ou 'false'): ");
string textoEspada = Console.ReadLine();        // Lê como texto
bool possuiEspada = bool.Parse(textoEspada); // Converte o texto para booleano

Console.WriteLine("\n--- Ficha do Herói Criado ---");
Console.WriteLine($"Nome: {nomeHeroi}");
Console.WriteLine($"Nível: {nivelHeroi}");
Console.WriteLine($"Ouro: {ouroHeroi:F2}g"); // :F2 formata para 2 casas decimais
Console.WriteLine($"Possui Espada Inicial? {possuiEspada}");

// Demonstração de erro se o Parse falhar (apenas para o professor explicar)
// Console.Write("Tente digitar 'muitos' para a idade: ");
// int idadeInvalida = int.Parse(Console.ReadLine()); // Isso causaria uma FormatException


// --- Usando Operadores Aritméticos ----------------------------------------------------------------------------------------------------------------

// --- Definindo alguns valores iniciais para o jogo ---
int vidaAtualJogador = 80;
int danoDoMonstro = 15;
int pontosDeExperiencia = 500;
int xpParaProximoNivel = 1000;
int pocaoDeCura = 25; // Quanto uma poção cura
int moedasColetadas = 17;
int numeroDeInimigos = 3;

Console.WriteLine("--- Simulação de Eventos de Jogo ---");

// Subtração: Jogador toma dano
Console.WriteLine($"Vida inicial: {vidaAtualJogador}");
vidaAtualJogador = vidaAtualJogador - danoDoMonstro;
Console.WriteLine($"Após ataque do monstro, vida: {vidaAtualJogador}");

// Adição: Jogador usa poção de cura
vidaAtualJogador = vidaAtualJogador + pocaoDeCura;
Console.WriteLine($"Após usar poção de cura, vida: {vidaAtualJogador}");

// Adição: Ganhando experiência
Console.WriteLine($"XP inicial: {pontosDeExperiencia}");
pontosDeExperiencia = pontosDeExperiencia + (danoDoMonstro * 10); // Ganha 10x o dano do monstro em XP
Console.WriteLine($"Após derrotar monstro, XP: {pontosDeExperiencia}");

// Multiplicação: Calculando bônus de ouro por combo
int comboMultiplicador = 3;
int ouroBonus = moedasColetadas * comboMultiplicador;
Console.WriteLine($"Moedas coletadas: {moedasColetadas}, com bônus de combo x{comboMultiplicador}, total bônus: {ouroBonus}");

// Divisão (Inteira): Distribuindo loot igualmente
int totalLoot = 20; // 20 itens de loot
int jogadoresNoGrupo = 3;
int lootPorJogador = totalLoot / jogadoresNoGrupo; // Divisão inteira, 20 / 3 = 6
Console.WriteLine($"{totalLoot} itens de loot divididos para {jogadoresNoGrupo} jogadores: cada um recebe {lootPorJogador} itens.");

// Divisão (Float): Calculando dano médio
float danoTotalCausado = 150.0f; // Dano total em 5 ataques
int numeroDeAtaques = 5;
float danoMedioPorAtaque = danoTotalCausado / numeroDeAtaques; // 150.0f / 5 = 30.0f
Console.WriteLine($"Dano médio por ataque: {danoMedioPorAtaque:F1}"); // :F1 formata para 1 casa decimal

// Módulo (Resto da Divisão): Itens restantes após distribuição
int itensRestantes = totalLoot % jogadoresNoGrupo; // 20 % 3 = 2
Console.WriteLine($"Itens restantes após a divisão: {itensRestantes}");

// Módulo: Verificando se um número é par (útil para turnos alternados, etc.)
int numeroDoTurno = 7;
bool ehTurnoPar = (numeroDoTurno % 2 == 0); // 7 % 2 é 1, então 1 == 0 é false
Console.WriteLine($"O turno {numeroDoTurno} é par? {ehTurnoPar}");

// Precedência de Operadores
// O jogador ganha XP = (dano_base + bonus_arma) * multiplicador_vitoria
int danoBase = 10;
int bonusArma = 5;
float multiplicadorVitoria = 1.5f;
float xpGanho = (danoBase + bonusArma) * multiplicadorVitoria; // (10+5)*1.5 = 15 * 1.5 = 22.5
                                                               // Sem parênteses: danoBase + bonusArma * multiplicadorVitoria = 10 + (5 * 1.5) = 10 + 7.5 = 17.5 (resultado diferente!)
Console.WriteLine($"XP ganho na vitória (com precedência correta): {xpGanho}");