using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        // programa 1
Console.WriteLine("Voce possui pena de grifo? (sim/nao)");
string pena = Console.ReadLine().ToLower();

Console.WriteLine("Voce possui escama de basilisco? (sim/nao)");
string escama = Console.ReadLine().ToLower();

Console.WriteLine("Voce possui flor da lua sangrenta? (sim/nao)");
string flor = Console.ReadLine().ToLower();

Console.WriteLine("Quantas moedas de ouro voce possui?");
int moedas = int.Parse(Console.ReadLine());

if (pena == "sim" && escama == "sim" && flor == "sim" && moedas >= 500)
{
    Console.WriteLine("Pocao criada com sucesso!");
}
else
{
    Console.WriteLine("A pocao falhou! Ingredientes ou moedas insuficientes.");
}

// programa 2
int acertos = 0;

Console.WriteLine("Enigma 1: Qual e a capital da Franca?");
string resp1 = Console.ReadLine().ToLower();
if (resp1 == "paris") acertos++;

Console.WriteLine("Enigma 2: Quanto e 5 x 6?");
string resp2 = Console.ReadLine();
if (resp2 == "30") acertos++;

Console.WriteLine("Enigma 3: Qual e a cor do ceu em um dia claro?");
string resp3 = Console.ReadLine().ToLower();
if (resp3 == "azul") acertos++;

if (acertos == 3)
{
    Console.WriteLine("Voce desativou completamente a armadilha!");
}
else if (acertos == 2 || acertos == 1)
{
    Console.WriteLine("Voce desativou a armadilha parcialmente.");
}
else
{
    Console.WriteLine("Voce falhou em desativar a armadilha!");
}

Console.WriteLine("Enigmas corretos: " + acertos + "/3");

// programa 3
Console.WriteLine("Escolha uma acao:");
Console.WriteLine("1 - Defender a floresta");
Console.WriteLine("2 - Ajudar os mercadores");
Console.WriteLine("3 - Atacar os dois lados");
string escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.WriteLine("Faccao dos Druidas: +10 reputacao (Apoiam sua decisao).");
    Console.WriteLine("Faccao dos Mercadores: -10 reputacao (Desaprovam sua escolha).");
}
else if (escolha == "2")
{
    Console.WriteLine("Faccao dos Mercadores: +10 reputacao (Agradecem sua ajuda).");
    Console.WriteLine("Faccao dos Druidas: -10 reputacao (Voce ignorou a natureza).");
}
else if (escolha == "3")
{
    Console.WriteLine("Ambas as faccoes: -15 reputacao (Voce virou inimigo de todos).");
}
else
{
    Console.WriteLine("Acao invalida.");
}

// programa 4
Console.WriteLine("Digite sua forca base:");
int forca = int.Parse(Console.ReadLine());

Console.WriteLine("Digite sua agilidade base:");
int agilidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite sua inteligencia base:");
int inteligencia = int.Parse(Console.ReadLine());

Console.WriteLine("Equipou elmo? (sim/nao)");
string elmo = Console.ReadLine().ToLower();

Console.WriteLine("Equipou armadura? (sim/nao)");
string armadura = Console.ReadLine().ToLower();

Console.WriteLine("Equipou arma? (sim/nao)");
string arma = Console.ReadLine().ToLower();

if (elmo == "sim")
{
    inteligencia += 5;
}
if (armadura == "sim")
{
    forca += 10;
}
if (arma == "sim")
{
    agilidade += 7;
}

Console.WriteLine("Atributos finais:");
Console.WriteLine("Forca: " + forca);
Console.WriteLine("Agilidade: " + agilidade);
Console.WriteLine("Inteligencia: " + inteligencia);

// programa 5
int destravadas = 0;

Console.WriteLine("Possui chave de bronze? (sim/nao)");
string chave = Console.ReadLine().ToLower();
if (chave == "sim") destravadas++;

Console.WriteLine("Digite o codigo:");
int codigo = int.Parse(Console.ReadLine());
if (codigo == 1234) destravadas++;

Console.WriteLine("Possui amuleto da serpente? (sim/nao)");
string amuleto = Console.ReadLine().ToLower();
if (amuleto == "sim") destravadas++;

Console.WriteLine("Travas abertas: " + destravadas + "/3");

if (destravadas == 3)
    Console.WriteLine("Cofre destrancado com sucesso!");
else
    Console.WriteLine("O cofre ainda esta trancado.");

// programa 6
Console.WriteLine("Clima atual (chuva, sol, neve):");
string clima = Console.ReadLine().ToLower();

Console.WriteLine("Digite o valor de movimento base:");
int movimento = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dano magico base:");
int danoMagico = int.Parse(Console.ReadLine());

switch (clima)
{
    case "chuva":
        movimento -= 2;
        danoMagico += 5;
        break;
    case "sol":
        movimento += 3;
        danoMagico -= 2;
        break;
    case "neve":
        movimento -= 4;
        danoMagico -= 1;
        break;
    default:
        Console.WriteLine("Clima desconhecido, sem efeitos aplicados.");
        break;
}

Console.WriteLine("Movimento ajustado: " + movimento);
Console.WriteLine("Dano magico ajustado: " + danoMagico);

// programa 7
Console.WriteLine("Qual sua fama? (heroi, vilao, neutro)");
string fama = Console.ReadLine().ToLower();

switch (fama)
{
    case "heroi":
        Console.WriteLine("NPC: Ah, o grande salvador do reino! E uma honra velo.");
        break;
    case "vilao":
        Console.WriteLine("NPC: Voce nao e bem-vindo aqui. Saia antes que cause problemas!");
        break;
    case "neutro":
        Console.WriteLine("NPC: Hmm... nao me lembro de voce. E novo por aqui?");
        break;
    default:
        Console.WriteLine("NPC: Nao sei como reagir a essa reputacao.");
        break;
}

// programa 8
Console.WriteLine("Escolha dois ingredientes entre: raiz sombria, lagrima de fada, po de dragao");

Console.Write("Ingrediente 1: ");
string ing1 = Console.ReadLine().ToLower();

Console.Write("Ingrediente 2: ");
string ing2 = Console.ReadLine().ToLower();

if ((ing1 == "raiz sombria" && ing2 == "lagrima de fada") || (ing2 == "raiz sombria" && ing1 == "lagrima de fada"))
    Console.WriteLine("Voce criou a pocao da visao oculta: revela inimigos escondidos.");
else if ((ing1 == "raiz sombria" && ing2 == "po de dragao") || (ing2 == "raiz sombria" && ing1 == "po de dragao"))
    Console.WriteLine("Voce criou a pocao de furia ardente: aumenta seu ataque.");
else if ((ing1 == "lagrima de fada" && ing2 == "po de dragao") || (ing2 == "lagrima de fada" && ing1 == "po de dragao"))
    Console.WriteLine("Voce criou a pocao da cura luminosa: restaura 50 HP.");
else
    Console.WriteLine("Combinacao desconhecida. A pocao se transforma em fumaca...");

// programa 9
Console.WriteLine("HP do jogador: ");
int hpJogador = int.Parse(Console.ReadLine());

Console.WriteLine("HP do monstro: ");
int hpMonstro = int.Parse(Console.ReadLine());

Console.WriteLine("Dano de ataque: ");
int dano = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha sua acao (atacar/defender):");
string acao = Console.ReadLine().ToLower();

if (acao == "atacar")
{
    hpMonstro -= dano;
    Console.WriteLine($"Voce atacou o monstro e causou {dano} de dano!");
}
else if (acao == "defender")
{
    Console.WriteLine("Voce se defendeu e reduziu o dano recebido pela metade!");
    dano /= 2;
}
else
{
    Console.WriteLine("Acao invalida, voce perdeu o turno!");
}

Console.WriteLine("O monstro contra-ataca!");
hpJogador -= dano;

Console.WriteLine($"HP do jogador: {hpJogador}");
Console.WriteLine($"HP do monstro: {hpMonstro}");

// programa 10
Random rnd = new Random();
string[] eventos = { "ataque de bandidos", "desabamento", "tempestade magica" };
string evento = eventos[rnd.Next(eventos.Length)];

Console.WriteLine("Evento inesperado: " + evento);
Console.WriteLine("Voce possui escudo? (sim/nao)");
string escudo = Console.ReadLine().ToLower();

Console.WriteLine("Voce possui pocao? (sim/nao)");
string pocao = Console.ReadLine().ToLower();

if (evento == "ataque de bandidos")
{
    if (escudo == "sim")
        Console.WriteLine("Voce se defendeu bem e nao sofreu dano.");
    else
        Console.WriteLine("Voce foi ferido! Perdeu 30 HP.");
}
else if (evento == "desabamento")
{
    if (pocao == "sim")
        Console.WriteLine("Voce usou a pocao e escapou com agilidade.");
    else
        Console.WriteLine("Voce ficou preso e perdeu um item.");
}
else if (evento == "tempestade magica")
{
    if (escudo == "sim" && pocao == "sim")
        Console.WriteLine("Voce resistiu a tempestade com sucesso!");
    else
        Console.WriteLine("Voce sofreu efeitos magicos negativos.");
}

// programa 11
Console.WriteLine("Digite a posicao da alavanca 1 (cima/baixo):");
string a1 = Console.ReadLine().ToLower();

Console.WriteLine("Digite a posicao da alavanca 2 (cima/baixo):");
string a2 = Console.ReadLine().ToLower();

Console.WriteLine("Digite a posicao da alavanca 3 (cima/baixo):");
string a3 = Console.ReadLine().ToLower();

if (a1 == "cima" && a2 == "baixo" && a3 == "cima")
    Console.WriteLine("A porta secreta se abre!");
else
    Console.WriteLine("Nada acontece...");

// programa 12
Console.WriteLine("Digite o material utilizado (ferro, aco, mithril): ");
string material = Console.ReadLine().ToLower();

Console.WriteLine("Digite seu nivel de habilidade (inteiro): ");
int habilidade = int.Parse(Console.ReadLine());

string qualidade = "comum";
if (habilidade >= 70) qualidade = "epico";
else if (habilidade >= 40) qualidade = "raro";

Console.WriteLine($"Item criado: espada de {material} ({qualidade})");

// programa 13
Console.WriteLine("Digite o nivel inicial de moral (0-100): ");
int moral = int.Parse(Console.ReadLine());

Console.WriteLine("Evento recente (vitoria, derrota, bonus):");
string eventoTropa = Console.ReadLine().ToLower();

if (eventoTropa == "vitoria") moral += 15;
else if (eventoTropa == "derrota") moral -= 20;
else if (eventoTropa == "bonus") moral += 10;

string efeito = moral >= 70 ? "Motivacao" : (moral < 30 ? "Desanimo" : "Neutro");
Console.WriteLine($"Moral atual: {moral}. Efeito na tropa: {efeito}");

// programa 14
string[] codigoCorreto = { "sol", "lua", "estrela" };
Console.WriteLine("Digite as 3 runas ativadas (uma por linha):");
string[] ativadas = new string[3];
int corretas = 0;

for (int i = 0; i < 3; i++)
{
    ativadas[i] = Console.ReadLine().ToLower();
    if (ativadas[i] == codigoCorreto[i])
        corretas++;
}

Console.WriteLine($"Runas corretas na posicao: {corretas}/3");
Console.WriteLine("Dica: pense na ordem natural do ceu durante o dia e a noite.");

// programa 15
Console.WriteLine("Digite o tesouro atual: ");
int tesouro = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a felicidade atual: ");
int felicidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a forca militar atual: ");
int forcaMilitar = int.Parse(Console.ReadLine());

Console.WriteLine("Decisao tomada (aumentar impostos, investir em festas):");
string decisao = Console.ReadLine().ToLower();

if (decisao == "aumentar impostos")
{
    tesouro += 50;
    felicidade -= 20;
}
else if (decisao == "investir em festas")
{
    tesouro -= 30;
    felicidade += 30;
}

Console.WriteLine($"Novos valores - Tesouro: {tesouro}, Felicidade: {felicidade}, Forca Militar: {forcaMilitar}");


        }
    }
}