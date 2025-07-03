// Fase 1

string nome;

Console.WriteLine("Qual é seu nome aventureiro");

nome = Console.ReadLine();

Console.WriteLine("Seja Bem Vindo avetureiro " + nome);

// Fase 2

Console.WriteLine("Distribua seus 10 pontos entre Força e Agilidade ");

int forca = 0;

int agilidade = 0;

Console.WriteLine("Quantos pontos em força");

forca = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos pontos em Agilidade");

agilidade = int.Parse(Console.ReadLine());

if ((forca + agilidade) > 10)

{

    Console.WriteLine("ERROR");

    while ((forca + agilidade) > 10)
    {


        Console.WriteLine("Quantos pontos em força");

        forca = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantos pontos em Agilidade");

        agilidade = int.Parse(Console.ReadLine());
    }
}

// Fase 3

Console.WriteLine("Em uma mesa você ganha uma mapa e 25 moedas de ouros");
Console.ReadLine();

string[] itens = new string[4];

int moedas = 25;

itens[0] = "Mapa";

// Fase 4

Console.WriteLine("Ficha de Personagem");

Console.WriteLine($"Nome: {nome}");

Console.WriteLine($"Força: {forca}");

Console.WriteLine($"Agilidade: {agilidade}");

for (int i = 0; i < 3; i++)

{

    Console.WriteLine($"Itens {1 + i}: {itens[i]}");

}
Console.ReadLine();

// Fase 5

Console.WriteLine("???: Vejo que está bem equipado tem uma missão apra você precisa encontrar os 3 Fragmentos de Código para derrotar o Lich do Loop Infinito");
Console.ReadLine();

// Fase 6

Console.Write("Você chega a uma encruzilhada. Quer ir para a 'floresta' ou 'montanhas'? ");
string caminho = Console.ReadLine();
if (caminho == "floresta")
{
    Console.WriteLine("Você adentra uma floresta sombria e úmida.");
}
else if (caminho == "montanhas") 
{
    Console.WriteLine("Você escala montanhas íngremes e geladas.");
}

// Fase 7

Console.WriteLine($"Passando pelo caminho da {caminho} você encontra um portão bloqueando a passagem");
if (forca > 5)
{
    Console.WriteLine("Você usa sua força para abrir o portão trancado!");
}
else if (agilidade > 7)
{
    Console.WriteLine("Você se esgueira por uma brecha no portão!");
}
else
{
    Console.WriteLine("Você não consegue abrir o portão. Precisa ficar mais forte ou ágil.");
}

Console.ReadLine();


// Fase 8

Console.WriteLine("Andando pelo caminho você acha uma caverna");
Console.WriteLine("1 - entrar na caverna");
Console.WriteLine("2 - passar reto");
int escolha = int.Parse(Console.ReadLine());
bool chave1 = false;
bool chave2 = false;
switch (escolha)
{
    case 1:
         chave1 = true;
         chave2 = true;
        Console.WriteLine("Você encontra duas chaves e pega para você e sai da caverna");
        break;
    case 2:
        Console.WriteLine("Você passa reto");
        break;
}
Console.WriteLine("Andando mais um pouco você vê um báu e tenta abrir ");
if (chave1 == true && chave2 == true)
{
    Console.WriteLine("Você abre o baú selado e encontra o Primeiro Fragmento de Código!");
}
else
{
    Console.WriteLine("Você não tem os itens necessários para abrir o baú.");
}
Console.ReadLine();

//Fase 9 

string[] inventario = {"Poção de Cura","Adaga","Fragmento de Código",""};

//Fase 10

if (inventario[0] == "Poção de Cura")
{
    Console.WriteLine("Você tem uma Poção de Cura pronta para usar.");
}
else
{
    Console.WriteLine("Como você não tem poção de cura impossivel");
}
Console.ReadLine();
//Fase 11
Random dado = new Random();
int RNG = dado.Next(1, 21);
Console.WriteLine("Seja Bem vindo, aventureiro deixe-me falar seu numero da sorte ");
Console.WriteLine($"Oráculo do Caos: 'Seu numero da sorte é... {RNG}'");
Console.ReadLine();
//Fase 12 
string[] vendendo = { "Espada Rúnica", "Armadura Lendária", "Anel Místico" };
int item = dado.Next(1, 4);
Console.WriteLine("Olá, jovem aventureiro de uma olhadas no itens e ele um com você");
switch (item)
{
    case 1:
        Console.WriteLine("O vendedor oferece uma Espada Rúnica!");
        inventario[3] = vendendo[0];
        break;
    case 2:
        Console.WriteLine("O vendedor oferece uma Armadura Lendária!");
        inventario[3] = vendendo[1];
        break;
    case 3:
        Console.WriteLine("O vendedor oferece um Anel Místico!");
        inventario[3] = vendendo[2];
        break;
}
Console.ReadLine();

//Fase 13

Console.WriteLine("Inventário");
for (int i = 0; i < 4; i++)
    Console.WriteLine($"Slot {i + 1}: {inventario[i]}");
Console.ReadLine();

//Fase 14
Console.WriteLine("Opa aventureiro que tal tentar da um up na sua arma");
Console.ReadLine();
float bonus = 0;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Ciclo de Forja {i} iniciado...");
    if (dado.Next(1, 5) == 1)
    {
        Console.WriteLine("Sucesso! Você conseguiu uma melhoria crítica!");
        bonus = (bonus + 0.5f);
    }
    else
    {
        Console.WriteLine("Nada de especial aconteceu...");
    }
}
Console.ReadLine();

//Fase 15 

int goblins = dado.Next(2, 6);
Console.WriteLine($"Você foi emboscado por {goblins} goblins!");
for (int i = 1; i <= goblins; i++)
    Console.WriteLine($"Goblin {i} derrotado!");
Console.ReadLine();

// Fase 16

int hpHeroi = 100;
int hpLich = dado.Next(120, 181);
Console.WriteLine("Você chega no covil do mal e algo cai do céu");
Console.WriteLine($"O Lich aparece com {hpLich} HP! Prepare-se!");
Console.ReadLine();

// Fase 17,18,19

while (hpHeroi > 0 && hpLich > 0)
{
    Console.Write("Você quer 'atacar' ou 'usar pocao'? ");
    string acao = Console.ReadLine();

    if (acao == "usar pocao" && inventario[0] == "Poção de Cura")
    {
        int cura = dado.Next(15, 40);
        hpHeroi = hpHeroi + cura;
        Console.WriteLine($"Você usou uma Poção de Cura e recuperou {cura} HP! HP atual: {hpHeroi}");
        Console.WriteLine("Você gastou sua única poção de cura");
        inventario[0] = "";
    }
    else
    {
        int danoHeroi = dado.Next(10, 21);
        hpLich =hpLich - danoHeroi;
        Console.WriteLine($"Você ataca o Lich causando {danoHeroi * (1+bonus)} de dano! HP do Lich: {hpLich}");
    }

    if (hpLich > 0)
    {
        int danoLich = dado.Next(10, 21);
        hpHeroi =hpHeroi- danoLich;
        Console.WriteLine($"O Lich ataca causando {danoLich} de dano! Seu HP: {hpHeroi}");

        if (hpLich < 50 && dado.Next(0, 2) == 0)
        {
            int feitiço = 30;
            hpHeroi =hpHeroi - feitiço;
            Console.WriteLine($"O Lich lança um Feitiço Desesperado causando {feitiço} de dano extra!");
        }
    }
}
if (hpHeroi > 0)
    Console.WriteLine($"Parabéns, {nome}! Você derrotou o Lich do Loop Infinito");
else if (hpLich > 0)
    Console.WriteLine($"O Lich devorou sua alma, {nome}...");
else
    Console.WriteLine("Ambos caem juntos...");

