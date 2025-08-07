//O seletor de opções
// Máquina de poções
int ouro = 100;
Console.WriteLine("[1] Poção de Cura (custa 20 ouro)");
Console.WriteLine("[2] Poção de Força (custa 35 ouro)");
Console.WriteLine("[3] Poção de Mana (custa 30 ouro)");
Console.WriteLine("Escolha sua poção digitando o número:");
int escolhaPocao = int.Parse(Console.ReadLine());

switch (escolhaPocao)
{
    case 1:
        ouro -= 20;
        Console.WriteLine("Você comprou a Poção de Cura. Ouro restante: " + ouro);
        break;
    case 2:
        ouro -= 40;
        Console.WriteLine("Você comprou a Poção de Força. Ouro restante: " + ouro);
        break;
    case 3:
        ouro -= 30;
        Console.WriteLine("Você comprou a Poção de Mana. Ouro restante: " + ouro);
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}


//Teletransportador entre cidades
Console.WriteLine("Digite o nome da cidade que você deseja viajar (Ventobravo, Orgrimmar ou Dalaran):");
string cidade = Console.ReadLine();

switch (cidade)
{
    case "Ventobravo":
        Console.WriteLine("Custo: 40 ouro. Ventobravo é uma cidade ensolarada e bela.");
        break;
    case "Orgrimmar":
        Console.WriteLine("Custo: 50 ouro. Orgrimmar é uma cidade fria e misteriosa");
        break;
    case "Dalaran":
        Console.WriteLine("Custo: 60 ouro. Dalaran é a famosa cidade dos magos");
        break;
    default:
        Console.WriteLine("Cidade não encontrada.");
        break;
}


//NPC com personalidades multiplas

Console.WriteLine("Digite o estado emocional do NPC (1: Feliz, 2: Neutro, 3: Triste, 4: Irritado):");
int estadoEmocional = int.Parse(Console.ReadLine());

switch (estadoEmocional)
{
    case 1:
        Console.WriteLine("NPC: 'Que belo dia!'");
        break;
    case 2:
        Console.WriteLine("NPC: 'O que você quer?'");
        break;
    case 3:
        Console.WriteLine("NPC: 'Não me sinto bem...'");
        break;
    case 4:
        Console.WriteLine("NPC: 'Saia da minha frente!'");
        break;
    default:
        Console.WriteLine("Estado desconhecido.");
        break;
}


//Aplicando bonus de arma

Console.WriteLine("Escolha uma arma (Espada, Machado ou Arco):");
string arma = Console.ReadLine();

int dano = 15;
int velocidadeDeAtaque = 10;

switch (arma)
{
    case "Espada":
        dano += 5;
        velocidadeDeAtaque += 3;
        break;
    case "Machado":
        dano += 8;
        velocidadeDeAtaque -= 2;
        break;
    case "Arco":
        dano += 4;
        velocidadeDeAtaque += 5;
        break;
    default:
        Console.WriteLine("Arma desconhecida.");
        break;
}

Console.WriteLine("Atributos finais: Dano = " + dano + "; Velocidade de Ataque = " + velocidadeDeAtaque);


//Conversor de runa para elemento

Console.WriteLine("Digite um símbolo de runa ('F', 'A' ou 'T'):");
char runa = char.Parse(Console.ReadLine());

switch (runa)
{
    case 'F':
        Console.WriteLine("Elemento: Fogo");
        break;
    case 'A':
        Console.WriteLine("Elemento: Água");
        break;
    case 'T':
        Console.WriteLine("Elemento: Terra");
        break;
    default:
        Console.WriteLine("Runa desconhecida.");
        break;
}