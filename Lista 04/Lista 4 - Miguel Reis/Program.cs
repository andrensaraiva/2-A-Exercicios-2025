using System.ComponentModel.Design;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Possui Pena de Grifo? (sim/não)");
string pena = Console.ReadLine();
Console.WriteLine("Possui Escama de Basilisco? (sim/não)");
string escama = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
string flor = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui? (valor inteiro)");
int moedas = int.Parse(Console.ReadLine());

if (pena == "sim" && escama == "sim" && flor == "sim" && moedas > 499)
{
    Console.WriteLine("poção será criada com sucesso");
}
else if (pena == "sim" && escama == "sim" && flor == "sim" && moedas < 500)
{
    Console.WriteLine("consiga mais moedas");
}
else if (pena == "sim" && escama == "sim" && flor == "nao" && moedas > 499)
{
    Console.WriteLine("consiga flor");
}

else if (pena == "sim" && escama == "nao" && flor == "sim" && moedas > 499)
{
    Console.WriteLine("consiga escama");
}
else if (pena == "nao" && escama == "sim" && flor == "sim" && moedas > 499)
{
    Console.WriteLine("consiga flor");
}
else if (pena == "nao" && escama == "sim" && flor == "sim" && moedas < 499)
{
    Console.WriteLine("consiga o item que falta e moedas");
}







Console.WriteLine("cipo ou cipozin?");
string cipozin = Console.ReadLine();
Console.WriteLine("abu ou abada?");
string abu = Console.ReadLine();
Console.WriteLine("Pc ou ps5?");
string pc = Console.ReadLine();

if (cipozin == "cipo" && abu == "abu" && pc == "pc")
{
    Console.WriteLine("escapou");
}
else if (cipozin == "cipo" && abu == "abu" && pc == "ps5")
{
    Console.WriteLine("dois enigmas certos, parcialmente desativada");
}
else if (cipozin == "cipo" && abu == "abada" && pc == "ps5")
{
    Console.WriteLine("tchau e benca");
}






Console.WriteLine("Defender a floresta?");
string floresta = Console.ReadLine();
Console.WriteLine("Ajudar os mercadores?");
string mercadores = Console.ReadLine();
Console.WriteLine("Atacar osdois lados? ");
string lados = Console.ReadLine();


if (floresta == "defender" && mercadores == "ajudar" && lados == "nao")
{
    Console.WriteLine("reputaçao maxima");
}
else if (floresta == "defender" && mercadores == "ajudar" && lados == "atacar")
{
    Console.WriteLine("reputaçao media");
}
else if (floresta == "nao" && mercadores == "nao" && lados == "atacar")
{
    Console.WriteLine("reputaçao minima");
}







Console.WriteLine("Atributos base(força 10, agilidade 10, inteligência 10, defesa 10)");
Console.WriteLine("Equipamentos equipados (elmo, armadura, arma)");
Console.WriteLine("calculando.........");
Console.WriteLine("Atributos atualizados (força 20, agilidade 7, inteligência 10, defesa 28)");






Console.WriteLine("Possui chave de bronze? (sim/não)");
string chave = Console.ReadLine();
Console.WriteLine("Código inserido (número)?");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
string amuleto = Console.ReadLine();

if (chave == "sim" && codigo == 0207 && amuleto == "sim")
{
    Console.WriteLine("abriu");
}
else if (chave == "sim" && amuleto == "sim")
{
    Console.WriteLine("duas travas abertas");
}
else if (chave == "sim")
{
    Console.WriteLine("uma trava");
}








Console.WriteLine("Clima atual (ex: chuva, sol, neve)?");
string tempo = Console.ReadLine();
Console.WriteLine("Movimento?");
int movimento = int.Parse(Console.ReadLine());
Console.WriteLine("dano mágico base ? ");
int dano = int.Parse(Console.ReadLine());

if (tempo == "sol")
{
    Console.WriteLine(movimento + 2);
}
else if (tempo == "neve")
{
    Console.WriteLine((movimento - 2) + " dano:" + (dano - 2));
}
else if (tempo == "chuva")
{
    Console.WriteLine((movimento - 1) + " dano:" + (dano - 1));
}






Console.WriteLine("Fama do jogador (ex: herói, vilão, neutro)?");
string fama = Console.ReadLine();

if (fama == "heroi")
{
    Console.WriteLine("vc é incrivel sou seu fa");
}
else if (fama == "vilao")
{
    Console.WriteLine("vc é um fdp nao gosto de vc");
}
else if (fama == "neutro")
{
    Console.WriteLine("vc é de boa cabecudo");
}






Console.WriteLine("escolha dois itens ( coloque o nomne apenas)?");
Console.WriteLine("cu de lobo = regenera vida, bunda de dragao = resiste a fogo, pele de grilo = dar pulos altos, ovo de urubu = fede tanto que nenhum inimingo te ataca, cabelo do jogador do vasco = jogadore e inimigos fracos nao te atacam");
string ingrediente1 = Console.ReadLine();
string ingrediente2 = Console.ReadLine();
Console.WriteLine("efeito do item?");
string efeito = Console.ReadLine();
string efeito1 = Console.ReadLine();
Console.WriteLine((ingrediente1) + " com " + (ingrediente2) + "  efeito da poçao =  " + (efeito) + " e " + (efeito1));










Console.WriteLine("HP do jogador?");
int hpjogador = int.Parse(Console.ReadLine());
Console.WriteLine("HP do monstro?");
int hpmonstro = int.Parse(Console.ReadLine());
Console.WriteLine("Dano de ataque ? ");
int danoatk = int.Parse(Console.ReadLine());
Console.WriteLine("Ação escolhida (atacar ou defender)");
string acao = Console.ReadLine();

if (acao == "defender")
{
    Console.WriteLine(danoatk - hpjogador);
}
else if (acao == "atacar")
{
    Console.WriteLine((danoatk - hpmonstro));
}






Console.WriteLine("qual item vc tem? (escudo, moedas, item raro)");
string item = Console.ReadLine();

if (item == "escudo")
{
    Console.WriteLine("vc se livra do inimigos");
}
else if (item == "moedas")
{
    Console.WriteLine("roubaram suas moedas");
}
else if (item == "item raro")
{
    Console.WriteLine("vc foi morto e te roubaram");
}










Console.WriteLine("alavanca pra cima ou pra baixo");
string al1 = Console.ReadLine();
Console.WriteLine("alavanca pra cima ou pra baixo");
string al2 = Console.ReadLine();
Console.WriteLine("alavanca pra cima ou pra baixo");
string al3 = Console.ReadLine();

if (al1 == "pra cima" && al2 == "pra baixo" && al3 == "pra cima")
{
    Console.WriteLine("vc sai");
}
else
{
    Console.WriteLine("se fudeu");
}










Console.WriteLine(" Criar um item");
Console.WriteLine("qual seu nivel?");
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("material? (ex: ferro, aço, mithril)");
string material = Console.ReadLine();



if (nivel <= 20 && material == "ferro")
{
    Console.WriteLine("ponta de ferro, item comum");
}
else if (nivel > 20 && material == "aço")
{
    Console.WriteLine("ponta de aço; incomum");
}
else if (nivel >= 49 && material == "mithrill")
{
    Console.WriteLine("ponta de mithrill, raro");
}






Console.WriteLine("Nível inicial de moral");
int moral = int.Parse(Console.ReadLine());
Console.WriteLine("Evento recente (ex: vitória, derrota, bônus)");
string evento = Console.ReadLine();



if (evento == "vitoria")
{
    Console.WriteLine("moral" + (moral + 20));
}
else if (evento == "derrota")
{
    Console.WriteLine("moral" + (moral - 10));
}
else if (evento == "bonus")
{
    Console.WriteLine("moral" + (moral + 5));
}











Console.WriteLine("Ordem das runas ativadas");
Console.WriteLine("Código inserido (número)?");
int codigorunas = int.Parse(Console.ReadLine());


if (codigorunas == 0207)
{
    Console.WriteLine("abriu");
}
else
{
    Console.WriteLine("nao abriu");
}








Console.WriteLine("Nível inicial de tesouro");
int tesouro = int.Parse(Console.ReadLine());
Console.WriteLine("Nível inicial de  felicidade");
int felicidade = int.Parse(Console.ReadLine());
Console.WriteLine("Nível inicial de força militar");
int forçamilitar = int.Parse(Console.ReadLine());
Console.WriteLine("Evento recente (ex: vitória, derrota, bônus)");
string evento1 = Console.ReadLine();



if (evento1 == "vitoria")
{
    Console.WriteLine("moral" + (moral + 20));
}
else if (evento1 == "derrota")
{
    Console.WriteLine("moral" + (moral - 10));
}
else if (evento1 == "bonus")
{
    Console.WriteLine("moral" + (moral + 5));
}
