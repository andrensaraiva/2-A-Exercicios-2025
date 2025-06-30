Console.WriteLine("Possui Pena de Grifo? (sim/não)");
string pena = Console.ReadLine();
Console.WriteLine("Possui Escama de Basilisco? (sim/não)");
string escama = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
string flor = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui? (valor inteiro)");
int moedas = int.Parse(Console.ReadLine());

if (pena == "sim" && escama == "sim" && flor == "sim" && moedas >= 500)
{
    Console.WriteLine("A poção será criada com sucesso");
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
else if (moedas < 500)
{
    Console.WriteLine("Você precisa de mais moedas");
}


Console.WriteLine("O que tem dentes, mas não morde?");
string pente = Console.ReadLine();
Console.WriteLine("O que anda com os pés na cabeça?");
string piolho = Console.ReadLine();
Console.WriteLine("O que tem olho mágico mas não é mago?");
string porta = Console.ReadLine();

if (pente == "pente" && piolho == "piolho" && porta == "porta")
{
    Console.WriteLine("Todos os enigmas foram acertados e a armadilha foi completamente desativada");
}
else if (pente == "pente" && piolho != "piolho" && porta != "porta")
{
    Console.WriteLine("Alguns enigmas foram acertados e a armadilha foi parcialmente desativada");
}
else if (pente != "pente" && piolho != "piolho" && porta != "porta")
{
    Console.WriteLine("Nenhum enigma foi acertado e a armadilha não foi desativada");
}


Console.WriteLine("Sistema de Reputação com Facções");
Console.WriteLine("Defender a floresta?");
string defender = Console.ReadLine();
Console.WriteLine("Ajudar os mercadores?");
string ajudar = (Console.ReadLine());
Console.WriteLine("Atacar os dois lados?");
string atacar = Console.ReadLine();
if (defender == "sim" && ajudar == "não" && atacar == "não")
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
if (equipamento == " elmo")
{
    Console.WriteLine("Você agora tem 30 de inteligência");
}
else if (equipamento == "armadura")
{
    Console.WriteLine("Você agora tem 30 de força");
}
else if (equipamento == "arma")
{
    Console.WriteLine("Você agora tem 30 de agilidade");
}


Console.WriteLine("Possui chave de bronze? (sim/não)");
string chave = Console.ReadLine();
Console.WriteLine("Código inserido (número)");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
string amuleto = Console.ReadLine();

if (chave == "sim" && codigo == 12345 && amuleto == "sim")
{
    Console.WriteLine("Todas travas foram abertas e o cofre foi aberto");
}
else
{
    Console.WriteLine("Nenhuma trava foi aberta e o cofre permanece trancado");
}


Console.WriteLine("Clima Dinâmico e Seus Efeitos");
Console.WriteLine("Movimento - 10 e dano mágico base - 20");
Console.WriteLine("Clima atual(ex: chuva, sol, neve");
string clima = Console.ReadLine();
if (clima == "sol")
{
    Console.WriteLine("Movimento - 20 e dano base - 30");
}
else if (clima == "neve")
{
    Console.WriteLine("Movimento - 5 e dano base - 10");
}
else if (clima == "chuva")
{
    Console.WriteLine("Movimento - 15 e dano base - 25");
}


Console.WriteLine("Fama do jogador (ex: herói, vilão, neutro)");
string fama = Console.ReadLine();

if (fama == "herói")
{
    Console.WriteLine("É um pássaro? É um avião? OH MEU DEUS, É ELE!");
}
else if (fama == "vilão")
{
    Console.WriteLine("Socorro! Não faça nada comigo, por favor, eu sou inocente!");
}
else if (fama == "neutro")
{
    Console.WriteLine("Quem é você? Saia imediatamente.");
}


Console.WriteLine("Escolha de dois ingredientes entre a lista: Perna de pau, Olho de vidro, Nariz de pica-pau");
string ingrediente = Console.ReadLine();
string ingrediente2 = Console.ReadLine();
if (ingrediente == "Perna de pau" && ingrediente2 == "Olho de vidro")
{
    Console.WriteLine("Você fez uma poção de super visão");
}
else if (ingrediente == "Perna de pau" && ingrediente2 == "Nariz de pica-pau")
{
    Console.WriteLine("Você fez uma poção de voo");
}
else if (ingrediente == "Olho de vidro" && ingrediente2 == "Nariz de pica-pau")
{
    Console.WriteLine("Você fez uma poção de raio de enrgia ");
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
if (acao == "defender")
{
    Console.WriteLine(" Você agora tem " + (hpj - da));
}
else if (acao == "ataque")
{
    Console.WriteLine("O monstro agora tem " + (hpm - da));
}


Console.WriteLine("Tipo de evento (ex: ataque de bandidos)");
string evento = Console.ReadLine();
Console.WriteLine("Itens ou defesas disponíveis (ex: escudo, poção)");
string item = Console.ReadLine();

if (evento == "ataque de bandidos" && item == "escudo")
{
    Console.WriteLine("Você se protege e não é roubado");
}
else if (evento == "ataque de bandidos" && item == "poção")
{
    Console.WriteLine("Os bandidos são atacados e recuam");
}


Console.WriteLine("Para abrir a porta secreta, posicione as alavancas (cima ou baixo)");
string alavanca = Console.ReadLine();
string alavanca2 = Console.ReadLine();
string alavanca3 = Console.ReadLine();

if (alavanca == "baixo" && alavanca2 == "baixo" && alavanca3 == "cima")
{
    Console.WriteLine("Parabéns! Você abriu a porta secreta.");
}
else
{
    Console.WriteLine("Combinação incorreta, tente novamente");
}


Console.WriteLine("Material utilizado (ex: ferro, aço, mithril)");
string material = Console.ReadLine();
Console.WriteLine("Nível de habilidade (número inteiro)");
int nível = int.Parse(Console.ReadLine());

if (material == "ferro" && nível == 10)
{
    Console.WriteLine("Você criou uma espada comum");
}
else if (material == "aço" && nível == 100)
{
    Console.WriteLine("Você criou um escudo raro");
}
else if (material == "mithril" && nível == 100)
{
    Console.WriteLine("Você criou uma mega espada épica");
}


Console.WriteLine("Nível inicial de moral");
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("Evento recente (ex: vitória, derrota, bônus)");
string evento1 = Console.ReadLine();
if (evento1 == "vitória")
{
    Console.WriteLine("A tropa está motivada e a moral é " + (nivel + 10));
}
else if (evento1 == "derrota")
{
    Console.WriteLine("A tropa está desanimada e a moral é " + (nivel - 10));
}
else if (evento1 == "bônus")
{
    Console.WriteLine("A tropa está animada e a moral é " + (nivel + 5));
}


Console.WriteLine("Ordem das runas ativadas");
int ordem = int.Parse(Console.ReadLine());
Console.WriteLine("Código correto (conhecido pelo sistema)");
int codigo1 = int.Parse(Console.ReadLine());
if (ordem == 123 && codigo1 == 1234)
{
    Console.WriteLine("Você ativa as runas");
}
else if (ordem == 132 || ordem == 213 && codigo1 == 1234)
{
    Console.WriteLine("Somente uma runa está correta, inverta duas runas");
}
else if (ordem == 231)
{
    Console.WriteLine("Todas as runas estão erradas, as inverta");
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
    Console.WriteLine("O tesouro aumenta e a felicidade decai levemente. T= " + (tesouro + 100) + "F= " + (felicidade - 50));
}
else if (decisao == "investir em festas")
{
    Console.WriteLine("O tesouro diminui e a felicidade decai. T= " + (tesouro - 100) + "F= " + (felicidade - 80));
}
else if (ordem == 231)
{
    Console.WriteLine("O tesouro diminui e as forças aumentam. T= " + (tesouro - 100) + "FM= " + (forcam + 80));
}
