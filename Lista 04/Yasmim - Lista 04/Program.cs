// 1. O Alquimista Exigente

Console.WriteLine("Você deve informar se possui os 3 ingredientes mágicos e se tem moedas suficientes para criar uma poção poderosa.");

int numero = 0;
Console.WriteLine("Possui Pena de Grifo? (sim/não)");
Console.WriteLine("Possui Escama de Basilisco? (sim/não)");
Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
string resposta = Console.ReadLine();
numero = int.Parse(Console.ReadLine());

if (resposta == "sim" || resposta == "não")
{
    Console.WriteLine("A poção foi criada com sucesso, parabéns!");
}
else
{
    Console.WriteLine("Parabéns, você falhou na criação da poção, isso é deplorável!");
}

// 2. A Armadilha do Enigma Triplo

Console.WriteLine("Você precisa resolver 3 enigmas para escapar de uma armadilha mágica.");

string resposta;
Console.WriteLine("O que tem um pescoço, mas não tem cabeça?");
Console.WriteLine("O que sempre aumenta, mas nunca fica maior?");
Console.WriteLine("Que palavra tem todos os dias da semana dentro dela?");
string resposta = Console.ReadLine();

if (resposta == "Uma garrafa" || resposta == "Uma dívida" || resposta == "Domingo")
{
    Console.WriteLine("Parabéns! Você acertou todos os enigmas. As armadilhas foram completamente desativadas.");
}
else
{
    Console.WriteLine("Todos os enigmas estão incorretos. O nível vai piorar");
}

// 3. Sistema de Reputação com Facções

Console.WriteLine("Com base na ação escolhida por você, diferentes facções vão aumentar ou diminuir sua reputação com ele.");

Console.WriteLine("Defender a floresta");
Console.WriteLine("Ajudar os mercadores");
Console.WriteLine("Atacar os dois lados");
int escolha = int.Parse(Console.ReadLine());

Console.WriteLine("Qual você escolhe?");
escolha = int.Parse(Console.ReadLine());
if (escolha == 1)
{
    Console.WriteLine("Parabéns, as facções vão diminuir sua reputação!");

}
else if (escolha == 2)
{
    Console.WriteLine("Parabéns, as facções vão diminuir a sua reputação do mesmo jeito!");

}
else if (escolha == 3)
{
    Console.WriteLine("Oh até que fim, alguém escolheu certo, as facções vão AUMENTAR a sua reputação!!!");

}

// 4. Cálculo de Bônus de Atributo por Equipamento

int forca;
int agilidade;
int inteligencia;
string elmo;
string armadura;
string arma;
if (elmo == "Elmo de Força")
{
    forca + = 5;
}
if (armadura == "Armadura de Agilidade")
{
    agilidade + = 5;
}
if (arma == "Cajado de Inteligência")
{
    inteligencia + = 5;
}

Console.WriteLine("Força:" + forca + ", Agilidade:" + agilidade + ", Inteligência:" + inteligencia);

// 5. O Cofre com Múltiplas Travas

Console.WriteLine("Você deve informar se possui os 3 ingredientes mágicos e se tem moedas suficientes para criar uma poção poderosa.");

Console.WriteLine("Possui chave de bronze? (sim/não)");
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
Console.WriteLine("Código inserido" + numero);
string resposta = Console.ReadLine();
numero = int.Parse(Console.ReadLine());

if (resposta == "sim" || resposta == "não")
{
    Console.WriteLine("Todas as travas foram destravadas e o cofre está aberto, seja bem-vindo!");
}
else
{
    Console.WriteLine("Você errou, e agora está tudo bloqueado para o acesso");
}

// 6.Clima Dinâmico e Seus Efeitos

string clima;
int movimento;
int danoMagico;
if (clima == "chuva")
{
    danoMagico + = 5;
}
if (clima == "sol")
{
    movimento + = 2;
}
if (clima == "neve")
{
    movimento - = 2;
}
Console.WriteLine("Movimento:" + movimento + ",Dano Mágico:" + danoMagico);

// 7.Diálogo com NPC Reativo à Fama

string fama;
if (fama == "herói")
{
    Console.WriteLine("Bem-vindo, salvador do reino!");
}
else if (fama == "vilão")
{
    Console.WriteLine("Fique longe, maldito!");
}
else
{
    Console.WriteLine("Olá, viajante.");
}

// 8.Criação de Poções com Efeitos Variados

string ingr1;
string ingr2;
if (ingr1 == "Raiz" && ingr2 == "Orvalho") || (ingr1 == "Orvalho" && ingr2 == "Raiz")
{
    Console.WriteLine("Poção de Cura: Restaura 50 HP.");
}
else if (ingr1 == "Fumaça" && ingr2 == "Espinho")
{
    Console.WriteLine("Poção de Invisibilidade: Torna-se invisível por 30s.");
}
else
{ 
    Console.WriteLine("Poção desconhecida.");
}

// 9.Sistema de Combate por Turnos Simplificado

ref int hpJogador;
ref int hpMonstro;
int dano;
string ação;
if (ação == "atacar")
{
   hpMonstro - = dano;
   hpJogador - = 10; 
}
else if (ação == "defender")
{
    hpJogador - = 5; 
    Console.WriteLine("HP Jogador:" + hpJogador + ",HP Monstro:" + hpMonstro);
}

// 10.Gerador de Eventos Aleatórios com Consequências

string tipo;
bool temEscudo;
bool temPocao;
if (tipo == "ataque de bandidos")
if (temEscudo)
{
  Console.WriteLine("Você se defendeu com sucesso!");
}
else
{ 
  Console.WriteLine("Você perdeu 20 HP.");
}
else if (tipo == "fogo mágico")
}
if (temPocao)
{
    Console.WriteLine("Você usou a poção para resistir ao fogo.");
}
else
{ 
    Console.WriteLine("Você foi queimado: -30 HP.");
}

// 11.Quebra - Cabeça de Alavancas Interdependentes

string a1;
string a2;
string a3;
if (a1 == "cima" && a2 == "baixo" && a3 == "cima")
{
    Console.WriteLine("Porta secreta aberta!");
}
else
{ 
    Console.WriteLine("Nada acontece...");
}

// 12.Sistema de Crafting com Qualidade de Item

string material;
int habilidade;
string qualidade = "comum";
if (habilidade > = 50 && material == "aço")
{
    qualidade = "raro";
}
if (habilidade > = 80 && material == "mithril")
{
    qualidade = "épico";
} 
  Console.WriteLine("Item: Espada de " + material + qualidade);

// 13.Simulador de Moral de Tropa

int moral;
string evento;
if (evento == "vitória") ]
{
    moral + = 10;
}
else if (evento == "derrota")
{
    moral - = 10;
}
else if (evento == "bônus")
{
    moral + = 5;
}
string efeito = moral > = 70 ? "Motivação Alta" :
                moral > = 40 ? "Moral Estável" :
                "Tropa desmotivada";
Console.WriteLine("Moral:" + moral + "-" + efeito);

// 14.Decifrando um Código Rúnico

string runas;
string codigoCorreto
int corretas = 0;
if (runas == codigoCorreto);
{ 
  Console.WriteLine("Runas corretas:" + corretas);
}

// 15.Gerenciamento de Reino

int tesouro;
int felicidade;
int militar;
string decisao;
if (decisao == "aumentar impostos")
{ 
  tesouro + = 100;
  felicidade - = 20;
}
else if (decisao == "investir em festas")
{
  tesouro - = 50;
  felicidade + = 30;
}
Console.WriteLine("Tesouro:" + tesouro + ", Felicidade:" + felicidade + ", Força Militar:" + militar);
