// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Diagnostics.Tracing;
using System.Security.Claims;

Console.WriteLine("O Alquimista Exigente");
Console.WriteLine("Possui pena de grifo? (sim/não)");
string pena = Console.ReadLine();
Console.WriteLine("Possui escama de Basilisco? (sim/não)");
string escama = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
string flor = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui?");
int moeda = int.Parse(Console.ReadLine());
if (pena == "sim" && escama == "sim" && flor == "sim" && moeda >= 500)
{
    Console.WriteLine("a poção será criada com sucesso.");
}
else if (pena == "não")
{
    Console.WriteLine("Você precisa da pena");
}
else if (escama == "não")
{
    Console.WriteLine("Você precisa da escama");
}
else if (flor == "não")
{
    Console.WriteLine("Você precisa da flor");
}
else if (moeda < 500)
{
    Console.WriteLine("Você precisa de mais moedas");
}



Console.WriteLine("A Armadilha do Enigma Triplo");
Console.WriteLine("Eu pertenço ao mês de dezembro, e não a qualquer outro mês. Eu não sou um feriado. O que eu sou?");
string mes = Console.ReadLine();
Console.WriteLine("Quantas patas têm um casal de patos?");
int pato = int.Parse(Console.ReadLine());
Console.WriteLine("O que pode correr, mas nunca anda; tem leito, mas nunca dorme; nasce, mas não morre?");
string enigma = Console.ReadLine();
if (mes == "d" && pato == 5 && enigma == "rio")
{ 
    Console.WriteLine("Você acertou todos os enigmas e a armadilha foi desativada");
}
else if (mes == "d" && pato <= 5 && enigma == "rio")
  { 
    Console.WriteLine("Você errou o segundo enigma e a armadilha foi parcialmente desativada");
}
else if (mes != "d" &&  pato != 5 && enigma != "rio")
{
    Console.WriteLine(" Você errou todos os enigmas e a armadilha não foi desativada");
}


Console.WriteLine("Sistema de Reputação com Facções");
Console.WriteLine("Defender a floresta?");
string defender = Console.ReadLine();
Console.WriteLine("Ajudar os mercadores?");
string ajudar = (Console.ReadLine());
Console.WriteLine("Atacar os dois lados?");
string atacar = Console.ReadLine();
if ( defender == "sim" && ajudar == "não" &&  atacar == "não")
{
    Console.WriteLine(" Reputação Máxima ");
}
else if (defender == " não" && ajudar == "sim" && atacar == "não")
{
    Console.WriteLine(" Reputaçã mediana ");
}
else if (defender == "não" && ajudar == "não" && atacar == "sim")
{
    Console.WriteLine(" Reputação Mínima ");
}


Console.WriteLine("Cálculo de Bônus de Atributo por Equipamento");
Console.WriteLine("Atributos base (força - 10, agilidade - 10, inteligência - 10)");
Console.WriteLine("Equipamentos utilizados (elmo, armadura, arma)");
string equipamento = Console.ReadLine();
if ( equipamento == " elmo")
{
    Console.WriteLine("Você agora tem 30 de inteligência");
}
else if ( equipamento == "armadura")
{
    Console.WriteLine("Você agora tem 30 de força");
}
else if ( equipamento == "arma")
{
    Console.WriteLine("Você agora tem 30 de agilidade");
}



Console.WriteLine("O Cofre com Múltiplas Travas");
Console.WriteLine("Possui chave de bronze? (sim/não)");
string chave = Console.ReadLine();
Console.WriteLine("Código inserido (número)");
int codigo =int.Parse(Console.ReadLine());
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
string amuleto = Console.ReadLine();
if ( chave == "sim" && codigo == 1234 && amuleto == "sim")
{
    Console.WriteLine("Todas as travas foram abertas e o cofre foi destrancado");
}
else if (chave == "não" && codigo != 1234 && amuleto == "não")
{
    Console.WriteLine(" nenhuma trava foi aberta e o cofre continua trancado");
}




Console.WriteLine("Clima Dinâmico e Seus Efeitos");
Console.WriteLine("Movimento - 10 e dano mágico base - 20");
Console.WriteLine("Clima atual(ex: chuva, sol, neve");
string clima = Console.ReadLine();
if (clima == "sol")
{
    Console.WriteLine("Movimento - 20 e dano base - 30");
}
else if ( clima == "neve")
{
    Console.WriteLine("Movimento - 5 e dano base - 10");
}
else if (clima == "chuva")
{
    Console.WriteLine("Movimento - 15 e dano base - 25");
}




Console.WriteLine("Diálogo com NPC Reativo à Fama");
Console.WriteLine("Fama do jogador (ex: herói, vilão, neutro)");
string fama = Console.ReadLine();
if (fama == "herói")
{
    Console.WriteLine("Meu deus eu sou seu fã");
}
else if (fama == "neutro")
{
    Console.WriteLine("Quem é você?");
}
else if (fama == "vilão")
{
    Console.WriteLine("Meu deus que medoooooo");
}



Console.WriteLine("Criação de Poções com Efeitos Variados");
Console.WriteLine("Escolha de dois ingredientes entre a lista: Raiz de mandrágora, Olho de tritão, Asas de morcego, chifre de unicórnio");
string ingrediente = Console.ReadLine();
string ingrediente2 = Console.ReadLine();
if (ingrediente == "Raiz de mandrágora" && ingrediente2 == "Olho de tritão")
{
    Console.WriteLine("Você fez uma poção de super visão");
}
else if (ingrediente == "asas de morcego" && ingrediente2 == " chifre de unicórnio" )
{
    Console.WriteLine("Você fez uma poção de voo");
}
else if (ingrediente == "Raiz de mandrágora" && ingrediente2 == "chifre de unicórnio")
{
    Console.WriteLine("Você fez uma poção de raio de enrgia ");
}
else if (ingrediente == "asas de morcego" && ingrediente2 == "Olho de tritão")
{
    Console.WriteLine("Você fez uma poção de telepatia");
}




Console.WriteLine("Sistema de Combate por Turnos Simplificado");
Console.WriteLine("HP do jogador");
int hpj = int.Parse(Console.ReadLine());
Console.WriteLine("HP do monstro");
int hpm = int.Parse(Console.ReadLine());
Console.WriteLine("Dano de ataque");
int da = int.Parse(Console.ReadLine());
Console.WriteLine("Ação escolhida (atacar ou defender)");
string acao = Console.ReadLine();
if ( acao == "defender")
{
    Console.WriteLine(" Você agora tem " + (hpj - da));
}
else if ( acao == "ataque")
{
    Console.WriteLine("O monstro agora tem " + (hpm - da));
}


Console.WriteLine("Gerador de Eventos Aleatórios com Consequências");
Console.WriteLine("Tipo de evento (ex: ataque de bandidos)");
string evento = Console.ReadLine();
Console.WriteLine("Itens ou defesas disponíveis (ex: escudo, poção)");
string item = Console.ReadLine();
if (evento == "ataque de bandido" && item == "escudo")
{
    Console.WriteLine(" Você não se machuca mas perde seu dinheiro");
}
else if (evento == "ataque de bandido" && item == "poção")
{
    Console.WriteLine("Você se defende e não é roubado");
}



Console.WriteLine("Quebra-Cabeça de Alavancas Interdependentes");
Console.WriteLine("Posição de cada alavanca (cima ou baixo)");
string alavanca = Console.ReadLine();
string alavanca2 = Console.ReadLine();
string alavanca3 = Console.ReadLine();
if ( alavanca == "cima" && alavanca2 == "baixo" && alavanca3 == "cima")
{
    Console.WriteLine(" A combinação está correta, a porta se abre");
}
else if (alavanca != "cima" && alavanca2 != "baixo" && alavanca3 != "cima")
{
    Console.WriteLine("nada acontece.");
}


Console.WriteLine("Sistema de Crafting com Qualidade de Item");
Console.WriteLine("Material utilizado (ex: ferro, aço, mithril)");
string material = Console.ReadLine();
Console.WriteLine("Nível de habilidade (número inteiro)");
int nivel = int.Parse(Console.ReadLine());
if ( material == "ferro" && nivel == 50)
{
    Console.WriteLine("Você cria a espada justiceira épica" );
}
else if ( material == "mithril" && nivel < 50)
{
    Console.WriteLine("Você cria o escudo atreides raro");
}
else if (material == "aço" && nivel < 50)
{
    Console.WriteLine("Você cria a lança perfuradora comum");
}




Console.WriteLine("Simulador de Moral de Tropa");
Console.WriteLine("Nível inicial de moral");
int nivel2 = int.Parse(Console.ReadLine());
Console.WriteLine("Evento recente (ex: vitória, derrota, bônus)");
string evento2 = Console.ReadLine();
if (evento2 == "vitória")
{
    Console.WriteLine("A tropa está motivada e a moral é " + ( nivel2 + 10));
}
else if ( evento2 == "derrota")
{
    Console.WriteLine("A tropa está desanimada e a moral é " + (nivel2 - 10));
}
else if (evento2 == "bônus")
{
    Console.WriteLine("A tropa está animada e a moral é " + (nivel2 + 5));
}



Console.WriteLine("Decifrando um Código Rúnico");
Console.WriteLine("Ordem das runas ativadas");
int ordem = int.Parse(Console.ReadLine());
Console.WriteLine("Código correto (conhecido pelo sistema)");
int codigo2 = int.Parse(Console.ReadLine());
if (ordem == 123 && codigo2 == 1234 )
{
    Console.WriteLine("Está tudo certo");
}
else if (ordem == 321 && codigo == 1234)
{
    Console.WriteLine("Somente uma runa está correta, inverta duas runas");
}
else if (ordem == 231)
{
    Console.WriteLine("Duas runas estão erradas, as inverta");
}
else if (ordem == 132)
{
    Console.WriteLine("Duas runas estão erradas, as inverta");
}



Console.WriteLine("Nível inicial de tesouro");
int tesouro = int.Parse(Console.ReadLine());
Console.WriteLine("Nível inicial de  felicidade");
int felicidade = int.Parse(Console.ReadLine());
Console.WriteLine("Nível inicial de força militar");
int forcam = int.Parse(Console.ReadLine());
Console.WriteLine("Decisão tomada(ex: aumentar impostos, investir em festas, investir nas forças)");
string decisao = Console.ReadLine();
if (decisao == "aumentar impostos")
{
    Console.WriteLine("O tesouro aumenta e a felicidade decai levemente. T= " + (tesouro + 100) + "F= " + ( felicidade - 50));
}
else if (decisao == "investir em festas")
{
    Console.WriteLine("O tesouro diminui e a felicidade decai. T= " + (tesouro - 100) + "F= " + ( felicidade - 80));
}
else if (ordem == 231)
{
    Console.WriteLine("O tesouro diminui e as forças aumentam. T= " + (tesouro - 100) + "FM= " + (forcam + 80)); 
}

