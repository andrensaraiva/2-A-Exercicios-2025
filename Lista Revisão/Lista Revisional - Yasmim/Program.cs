// Fase 1: O Despertar do Herói

Console.Write("Digite o nome do seu herói: ");
string nome = Console.ReadLine();
Console.WriteLine("Bem-vindo," + nome + ", à Saga do Herói do Console!");

//Fase 2: A Forja dos Atributos

int forca = 5;
int agilidade = 5;
int pontosBonus = 10;

Console.Write("Distribua quantos pontos deseja adicionar à força: ");
int bonusForca = int.Parse(Console.ReadLine());
int bonusAgilidade = pontosBonus - bonusForca;

forca += bonusForca;
agilidade += bonusAgilidade;

Console.WriteLine("Atributos finais - Força:" + forca + ", Agilidade:" + agilidade);

//Fase 3: A Bolsa Inicial

float ouro = 25.50f;
bool mapa = true;

// Fase 4: A Ficha do Personagem

Console.WriteLine("Ficha do Personagem");
Console.WriteLine("Nome:" + nome);
Console.WriteLine("Força:" + forca);
Console.WriteLine("Agilidade:" + agilidade);
Console.WriteLine("Ouro:" + ouro);
Console.WriteLine("Mapa:" + mapa);

//Fase 5: A Primeira Missão

Console.WriteLine("Sábio Ancião:" + "Sua missão é encontrar os 3 Fragmentos de Código para derrotar o Lich do Loop Infinito!");

//Fase 6: A Encruzilhada do Destino

Console.Write("Escolha seu caminho (floresta ou montanhas): ");
string caminho = Console.ReadLine();
if
{
    caminho = "floresta";
    Console.WriteLine("Você adentra uma floresta densa e misteriosa.");
}
else
{
    Console.WriteLine("Você escala as montanhas geladas e traiçoeiras.");
}

//Fase 7: O Guardião do Portão

if (forca > 12)
{
    Console.WriteLine("Você usa a força bruta para abrir o portão.");
}
else if (agilidade > 12)
{
    Console.WriteLine("Você se move rapidamente e passa pelo portão.");
}
else
{
    Console.WriteLine("Você não tem atributos suficientes para passar.");
}

//Fase 8: O Baú Selado

bool chave1 = true;
bool chave2 = true;

if (mapa && chave1 && chave2)
{
    Console.WriteLine("Você abriu o baú com segurança e encontrou um Fragmento de Código!");
}
else
{
    Console.WriteLine("Você não tem os itens necessários para abrir o baú.");
}

//Fase 9: A Bolsa Dimensional

string[] inventario = ("Poção de Cura", "Adaga", "Fragmento de Código");

//Fase 10: Verificando Suprimentos

string Fase;
string Verificando;
string Suprimentos;

if (inventario[0] == "Poção de Cura")
{ 
    Console.WriteLine("Você tem uma Poção de Cura no inventário.");
    Fase=10;
    Verificando=Suprimentos;
}
if (inventario[0] == "Poção de Cura")
{
    Console.WriteLine("Você tem uma Poção de Cura no inventário.");
}

//Fase 11: O Oráculo do Caos

Random dado = new Random();
int previsao = dado.Next(1, 21);"
Console.WriteLine("O Oráculo prevê:" + previsao);

//Fase 12:Vendedor e o Item do Dia 

int escolhaItem = dado.Next(1, 4);
switch (escolhaItem)
{
    case 1:
        Console.WriteLine("Item do dia: Espada Flamejante!");
        break;
    case 2:
        Console.WriteLine("Item do dia: Escudo Congelante!");
        break;
    case 3:
        Console.WriteLine("Item do dia: Poção de Invisibilidade!");
        break;
}

//Fase 13: Inventário Completo

for (int i = 0; i < inventario.Length; i++)
{
    Console.WriteLine("Slot" + {i + 1}: {inventario[i]});
}

//Fase 14: Forja com Chance Crítica

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Ciclo de forja" + {i});
    if (dado.Next(1, 5) == 1)
        Console.WriteLine("Melhoria crítica! Obra-prima forjada!");
    else
        Console.WriteLine("Item comum forjado.");
}

//Fase 15: Emboscada dos Goblins

int goblins = dado.Next(2, 6);
Console.WriteLine({goblins} + "goblins atacam!");

for (int i = 1; i <= goblins; i++)
{
    Console.WriteLine("Goblin" + {i} + "derrotado!");
}

//Fase 16: Setup da Batalha

int hpHeroi = 100;
int hpLich = dado.Next(120, 181);
Fase 17: Batalha Final
while (hpHeroi > 0 && hpLich > 0)
int danoHeroi = dado.Next(10, 21);
int danoLich = dado.Next(10, 21);

hpLich -= danoHeroi;
hpHeroi -= danoLich;

Console.WriteLine("Você causa" + {danoHeroi} + "de dano. Lich tem" + {hpLich} + "de HP.");
Console.WriteLine("Lich causa" + {danoLich} "de dano. Você tem" + {hpHeroi} "de HP.");

//Fase 18: Uso de Poção
  
Console.Write("Deseja 'atacar' ou 'usar pocao'? ");
string acao = Console.ReadLine().ToLower();

if (acao == "usar pocao" && inventario[0] == "Poção de Cura")
{
    int cura = dado.Next(15, 26);
    hpHeroi += cura;
    inventario[0] = "";
    Console.WriteLine("Você usou uma poção e recuperou" + {cura} "de HP!");
}

//Fase 19: Feitiço do Lich
  
if (hpLich < 50 && dado.Next(1, 101) <= 50)
    {
        int danoExtra = 30;
hpHeroi -= danoExtra;
Console.WriteLine("O Lich lançou um feitiço desesperado! Você tomou" + {danoExtra} "de dano!");
    }

//Fase 20: Final da Saga

if (hpHeroi > 0)
    Console.WriteLine("Você venceu o Lich e salvou Syntaxia!");
else if (hpLich > 0)
    Console.WriteLine("Você foi derrotado... o Lich reina em Syntaxia.");
else
    Console.WriteLine("Ambos caíram em batalha... o destino permanece incerto.");