// 1. O Alquimista Exigente

using System;

Console.WriteLine("Possui pena de Grifo? (sim/não)");
string resposta1 = Console.ReadLine();
Console.WriteLine("Possui escama de Basilisco? (sim/não)");
string resposta2 = Console.ReadLine();
Console.WriteLine("Possui flor da Lua Sangrenta? (sim/não)");
string resposta3 = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui? (valor inteiro)");
int numero1 = int.Parse(Console.ReadLine());
if (resposta1 == "sim" && resposta2 == "sim" && resposta3 == "sim" && numero1 >= 500)
{
    Console.WriteLine("a poção será criada com sucesso.");
}
else
{
    Console.WriteLine("Não será criada.");
}



// 2. A Armadilha do Enigma Triplo

Console.WriteLine("Tenho cidades, mas não casas.Tenho rios, mas não água.Tenho estradas, mas não ando. O que sou?");
string resposta4 = Console.ReadLine();
Console.WriteLine("Anda sem pés,corre sem descanso,nunca volta. O que é ?");
string resposta5 = Console.ReadLine();
Console.WriteLine("Se você me disser, eu desapareço.Quem sou?");
string resposta6 = Console.ReadLine();
if (resposta4 == "mapa" && resposta5 == "tempo" && resposta6 == "silencio" )
{
    Console.WriteLine("a armadilha foi completamente desativada");
}
else if (resposta4 == "mapa" && resposta5 == "tempo" && resposta6 == "silencio")
{
    Console.WriteLine("a armadilha foi completamente desativada");
}
else if (resposta4 != "mapa" && resposta5 == "tempo" && resposta6 == "silencio")
{
    Console.WriteLine("2 enigmas foram acertados e a armadilha foi parcialmente desativada");
}
else if (resposta4 == "mapa" && resposta5 == "tempo" && resposta6 != "silencio")
{
    Console.WriteLine("2 enigmas foram acertados e a armadilha foi parcialmente desativada");
}
else if (resposta4 == "mapa" && resposta5 != "tempo" && resposta6 == "silencio")
{
    Console.WriteLine("2 enigmas foram acertados e a armadilha foi parcialmente desativada");
}
else if (resposta4 != "mapa" && resposta5 != "tempo" && resposta6 == "silencio")
{
    Console.WriteLine("1 enigma foi acertado e a armadilha foi parcialmente desativada");
}
else if (resposta4 == "mapa" && resposta5 != "tempo" && resposta6 != "silencio")
{
    Console.WriteLine("1 enigma foi acertado e a armadilha foi parcialmente desativada");
}
else if (resposta4 != "mapa" && resposta5 == "tempo" && resposta6 != "silencio")
{
    Console.WriteLine("1 enigma foi acertado e a armadilha foi parcialmente desativada");
}
else
{
    Console.WriteLine("Nenhum enigma foi acertado e a armadilha nao foi desativada");
}



//3. Sistema de Reputação com Facções

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
    Console.WriteLine(" Reputação Media");
}
else if (defender == "não" && ajudar == "não" && atacar == "sim")
{
    Console.WriteLine(" Reputação Mínima ");
}



//4. Cálculo de Bônus de Atributo por Equipamento

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



//5. O Cofre com Múltiplas Travas

Console.WriteLine("Possui chave de bronze? (sim/não)");
string chave = Console.ReadLine();
Console.WriteLine("Código inserido (número)");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
string amuleto = Console.ReadLine();
if (chave == "sim" && codigo == 1234 && amuleto == "sim")
{
    Console.WriteLine("Todas as travas foram abertas e o cofre foi destrancado");
}
else if (chave == "não" && codigo != 1234 && amuleto == "não")
{
    Console.WriteLine(" nenhuma trava foi aberta e o cofre continua trancado");
}



//6. Clima Dinâmico e Seus Efeitos

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



//7. Diálogo com NPC Reativo à Fama

Console.WriteLine("Fama do jogador (ex: herói, vilão, neutro)");
string fama = Console.ReadLine();
if (fama == "herói")
{
    Console.WriteLine("Você é meu idolo!");
}
else if (fama == "neutro")
{
    Console.WriteLine("Não sei quem você é");
}
else if (fama == "vilão")
{
    Console.WriteLine("Não faça mal para nós meros plebeus");
}



//8. Criação de Poções com Efeitos Variados

Console.WriteLine("Escolha de dois ingredientes entre a lista: Flor da Lua, Pó de Estrela Cadente, Lágrima de Fênix, Raiz da Árvore da Eternidade");
string ingrediente1 = Console.ReadLine();
string ingrediente2 = Console.ReadLine();
if (ingrediente1 == "Flor da Lua" && ingrediente2 == "Pó de Estrela Cadente")
{
    Console.WriteLine("Você fez uma poção de Invisibilidade");
}
else if (ingrediente1 == "Lágrima de Fênix" && ingrediente2 == "Raiz da Árvore da Eternidade")
{
    Console.WriteLine("Você fez uma poção de Resurreição");
}
else if (ingrediente1 == "Flor da Lua" && ingrediente2 == "Raiz da Árvore da Eternidade")
{
    Console.WriteLine("Você fez uma poção de Parar o Tempo");
}
else if (ingrediente1 == "Lágrima de Fênix" && ingrediente2 == "Pó de Estrela Cadente")
{
    Console.WriteLine("Você fez uma poção de Purificação de Maldições");
}



//9. Sistema de Combate por Turnos Simplificados

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



//10. Gerador de Eventos Aleatórios com Consequências

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



//11. Quebra-Cabeça de Alavancas Interdependentes

Console.WriteLine("Quebra-Cabeça de Alavancas Interdependentes");
Console.WriteLine("Posição de cada alavanca (cima ou baixo)");
string alavanca1 = Console.ReadLine();
string alavanca2 = Console.ReadLine();
string alavanca3 = Console.ReadLine();
if (alavanca1 == "cima" && alavanca2 == "baixo" && alavanca3 == "cima")
{
    Console.WriteLine(" A combinação está correta, a porta se abre");
}
else if (alavanca1 != "cima" && alavanca2 != "baixo" && alavanca3 != "cima")
{
    Console.WriteLine("nada acontece.");
}



//12. Sistema de Crafting com Qualidade de Item

Console.WriteLine("Sistema de Crafting com Qualidade de Item");
Console.WriteLine("Material utilizado (ex: ferro, aço, mithril)");
string material = Console.ReadLine();
Console.WriteLine("Nível de habilidade (número inteiro)");
int nivel = int.Parse(Console.ReadLine());
if (material == "ferro" && nivel == 50)
{
    Console.WriteLine("Você cria a Escudo do Guardião Ancestral");
}
else if (material == "mithril" && nivel < 50)
{
    Console.WriteLine("Você cria o Arco dos Ventos");
}
else if (material == "aço" && nivel < 50)
{
    Console.WriteLine("Você cria a Espada perfuradora comum");
}



//13. Simulador de Moral de Tropa

Console.WriteLine("Simulador de Moral de Tropa");
Console.WriteLine("Nível inicial de moral");
int nivel2 = int.Parse(Console.ReadLine());
Console.WriteLine("Evento recente (ex: vitória, derrota, bônus)");
string evento2 = Console.ReadLine();
if (evento2 == "vitória")
{
    Console.WriteLine("A tropa está motivada e a moral é " + (nivel2 + 10));
}
else if (evento2 == "derrota")
{
    Console.WriteLine("A tropa está desanimada e a moral é " + (nivel2 - 10));
}
else if (evento2 == "bônus")
{
    Console.WriteLine("A tropa está animada e a moral é " + (nivel2 + 5));
}



//14. Decifrando um Código Rúnico

Console.WriteLine("Decifrando um Código Rúnico");
Console.WriteLine("Ordem das runas ativadas");
int ordem = int.Parse(Console.ReadLine());
Console.WriteLine("Código correto (conhecido pelo sistema)");
int codigo2 = int.Parse(Console.ReadLine());
if (ordem == 123 && codigo2 == 1234)
{
    Console.WriteLine("Tudo está correto");
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



//15. Gerenciamento de Reino

Console.WriteLine("Nível inicial de tesouro");
int tesouro = int.Parse(Console.ReadLine());
Console.WriteLine("Nível inicial de  felicidade");
int felicidade = int.Parse(Console.ReadLine());
Console.WriteLine("Nível inicial de força militar");
int forca = int.Parse(Console.ReadLine());
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
    Console.WriteLine("O tesouro diminui e as forças aumentam. T= " + (tesouro - 100) + "FM= " + (forca + 80));
}
