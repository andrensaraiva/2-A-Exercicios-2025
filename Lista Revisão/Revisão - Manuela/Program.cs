Random dado = new Random();

// Fase 1: O Despertar do Herói - Criando uma Lenda

Console.Write("Qual o nome do seu herói? ");

string nomeHeroi = Console.ReadLine();

Console.WriteLine($"Bem-vindo, {nomeHeroi}!");


// Fase 2: A Forja dos Atributos - Distribuindo Poder
int forca = 5;
int agilidade = 5;
int pontosBonus = 10;
Console.WriteLine("Você tem 10 pontos para distribuir entre Força e Agilidade.");
Console.Write("Quantos pontos quer colocar em Força? ");
int pontosForca = int.Parse(Console.ReadLine());
if (pontosForca > pontosBonus)
{
    pontosForca = pontosBonus;
}
forca += pontosForca;
agilidade += (pontosBonus - pontosForca);
Console.WriteLine($"Atributos finais - Força: {forca}, Agilidade: {agilidade}");



// Fase 3: A Bolsa Inicial - Primeiros Equipamentos
float ouro = 25.50f;

bool possuiMapa = true;


// Fase 4: A Ficha do Personagem - Conheça seu Herói

Console.WriteLine("Ficha do Personagem");

Console.WriteLine($"Nome: {nomeHeroi}");

Console.WriteLine($"Força: {forca}");

Console.WriteLine($"Agilidade: {agilidade}");

Console.WriteLine($"Ouro: {ouro}");

Console.WriteLine($"Possui Mapa: {possuiMapa}");


// Fase 5: A Primeira Missão - O Chamado à Aventura

Console.WriteLine("Um Sábio Ancião diz: 'Encontre os 3 Fragmentos de Código e derrote o Lich do Loop Infinito!'");


// Fase 6: A Encruzilhada do Destino - A Primeira Escolha

Console.Write("Você escolhe ir para 'floresta' ou 'montanhas'? ");

string caminho = Console.ReadLine().ToLower();

if (caminho == "floresta")

{

    Console.WriteLine("Você entra na floresta sombria, cheia de segredos.");

}

else

{

    Console.WriteLine("Você escala as montanhas geladas, enfrentando ventos cortantes.");

}


// Fase 7: O Guardião do Portão - Força ou Agilidade?

if (forca > 12)

{

    Console.WriteLine("Você empurra o portão com sua força impressionante e passa!");

}

else if (agilidade > 12)

{

    Console.WriteLine("Você encontra uma passagem estreita e passa com agilidade!");

}

else

{

    Console.WriteLine("Você não consegue passar pelo portão agora.");

}


// Fase 8: O Baú Selado - O Poder do 'E'

bool chave1 = true;

bool chave2 = true;

if (possuiMapa && chave1 && chave2)

{

    Console.WriteLine("Você abre o baú com segurança e encontra o primeiro Fragmento de Código!");

}

else

{

    Console.WriteLine("Você não tem tudo que precisa para abrir o baú.");

}



// Fase 9: A Bolsa Dimensional - Organizando o Inventário

string[] inventario = new string[4] { "Poção de Cura", "Adaga", "Fragmento de Código", null };




// Fase 10: Verificando Suprimentos - Preparação para a Batalha

if (inventario[0] == "Poção de Cura")

{

    Console.WriteLine("Você tem uma Poção de Cura no primeiro slot.");

}



// Fase 11: O Oráculo do Caos - Aprendendo a usar o Random

int previsao = dado.Next(1, 21);

Console.WriteLine($"O Oráculo revela: {previsao}");




// Fase 12: O Vendedor com 'Item do Dia' - Usando switch com Random

int numeroItem = dado.Next(1, 4);

switch (numeroItem)

{

    case 1:

        Console.WriteLine("Item especial do dia: Elixir Místico!");

        break;

    case 2:

        Console.WriteLine("Item especial do dia: Escudo Antigo!");

        break;

    case 3:

        Console.WriteLine("Item especial do dia: Botas de Velocidade!");

        break;

}



// Fase 13: Inventário Completo - A Varredura com for

Console.WriteLine("Inventário");

for (int i = 0; i < inventario.Length; i++)

{

    string item = inventario[i] != null ? inventario[i] : "Vazio";

    Console.WriteLine($"Slot {i}: {item}");

}



// Fase 14: A Forja com Chance de Obra-Prima - for e Random

for (int ciclo = 1; ciclo <= 3; ciclo++)

{

    int chance = dado.Next(1, 5);

    if (chance == 1)

    {

        Console.WriteLine($"Ciclo {ciclo}: Forja crítica! Obra-prima criada!");

    }

    else

    {

        Console.WriteLine($"Ciclo {ciclo}: Item forjado normalmente.");

    }

}



// Fase 15: Emboscada dos Goblins - Inimigos Aleatórios

int qtdGoblins = dado.Next(2, 6);

Console.WriteLine($"{qtdGoblins} goblins atacam!");

for (int i = 1; i <= qtdGoblins; i++)

{

    Console.WriteLine($"Você derrota o goblin {i}!");

}



// Fase 16: O Covil do Lich - Setup com Dano Variável

int hpHeroi = 100;

int hpLich = dado.Next(120, 181);

Console.WriteLine($"HP do Lich: {hpLich}");




// Fase 17: A Batalha Final - O Ciclo do while
while (hpHeroi > 0 && hpLich > 0)
{
    Console.Write("\nEscolha sua ação: atacar ou usar pocao: ");
    string acao = Console.ReadLine().ToLower();

    if (acao == "atacar")
    {
        int danoHeroi = dado.Next(10, 21);
        hpLich -= danoHeroi;
        if (hpLich < 0) { hpLich = 0; }
        Console.WriteLine($"Você causa {danoHeroi} de dano. HP do Lich: {hpLich}");
    }
    else if (acao == "usar pocao")
    {
        bool temPocao = false;
        for (int i = 0; i < inventario.Length; i++)
        {
            if (inventario[i] == "Poção de Cura")
            {
                temPocao = true;
                inventario[i] = null;
                break;
            }
        }
        if (temPocao)
        {
            int cura = dado.Next(15, 26);
            hpHeroi += cura;
            Console.WriteLine($"Você usa a poção e recupera {cura} de HP. Seu HP agora é {hpHeroi}");
        }
        else
        {
            Console.WriteLine("Você não tem mais poções!");
        }
    }

    int danoLich = dado.Next(10, 21);
    hpHeroi -= danoLich;
    if (hpHeroi < 0) { hpHeroi = 0; }
    Console.WriteLine($"O Lich ataca e causa {danoLich} de dano. Seu HP: {hpHeroi}");


    // Fase 18: Poções com Cura Instável - Decisão e Incerteza na Batalha
    if (acao == "usar pocao")
    {
        bool temPocao = false;
        for (int i = 0; i < inventario.Length; i++)
        {
            if (inventario[i] == "Poção de Cura")
            {
                temPocao = true;
                inventario[i] = null;
                break;
            }
        }
        if (temPocao)
        {
            int cura = dado.Next(15, 26);
            hpHeroi += cura;
            Console.WriteLine($"Você usa a poção e recupera {cura} de HP. Seu HP agora é {hpHeroi}");
        }
        else
        {
            Console.WriteLine("Você não tem mais poções!");
        }



        // Fase 19: O Feitiço Desesperado do Lich - Condição Complexa com Random
        if (hpLich < 50)
        {
            int chanceFeitico = dado.Next(1, 3);
            if (chanceFeitico == 1)
            {
                int danoExtra = 25;
                hpHeroi -= danoExtra;
                if (hpHeroi < 0) { hpHeroi = 0; }
                Console.WriteLine($"O Lich lança um feitiço desesperado e causa {danoExtra} de dano extra! Seu HP: {hpHeroi}");
            }
        }




        // Fase 20: O Destino de Syntaxia - A Vitória ou a Derrota

        if (hpHeroi > 0 && hpLich <= 0)

        {

            Console.WriteLine("Você derrota o Lich e salva Syntaxia!");

        }

        else if (hpLich > 0 && hpHeroi <= 0)

        {

            Console.WriteLine("O Lich vence e Syntaxia cai nas trevas!");

        }

        else

        {

            Console.WriteLine("Ambos caem, e o destino de Syntaxia permanece incerto!");

        }
    }
}