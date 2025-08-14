//1

int ouro = 150;
Console.WriteLine("[1] poção de cura (custa 15 ouro)");
Console.WriteLine("[2] poção de força (custa 25 ouro)");
Console.WriteLine("[3] poção de mana (custa 35 ouro)");
Console.WriteLine("escolha sua poção digitando um número:");
int escolhaPocao = int.Parse(Console.ReadLine());

switch (escolhaPocao)
{
    case 1:
        ouro -= 20;
        Console.WriteLine("você comprou uma poção de cura. seu ouro restante é: " + ouro);
        break;
    case 2:
        ouro -= 40;
        Console.WriteLine("você comprou uma poção de força. seu ouro restante é: " + ouro);
        break;
    case 3:
        ouro -= 30;
        Console.WriteLine("você comprou uma poção de mana. seu ouro restante é: " + ouro);
        break;
    default:
        Console.WriteLine("ops! escolha inválida.");
        break;
}


//2
Console.WriteLine("diga o nome da cidade que você quer viajar! (ventobravo, orgrimmar ou dalaran):");
string cidade = Console.ReadLine();

switch (cidade)
{
    case "ventobravo":
        Console.WriteLine("custo: 35 ouro. ventobravo é um lugar agitado, com tempo chuvoso e ventanias constantes. É uma cidade bela e romântica, mas não ideal caso você queira aproveitar a praia ou um dia de sol com sua família.");
        break;
    case "orgrimmar":
        Console.WriteLine("custo: 45 ouro. orgrimmar é uma cidade divertida e ensolarada!");
        break;
    case "dalaran":
        Console.WriteLine("custo: 55 ouro. dalaran é famosa pelo seu centrinho! ideal para quem busca fazer compras, bastante variedade de coisas pelos comerciantes locais!");
        break;
    default:
        Console.WriteLine("essa cidade é inválida.");
        break;
}


//3

Console.WriteLine("qual é o seu estado emocional? 1 (feliz), 2 (neutro), 3 (triste), 4 (irritado)");
int estadoEmocional = int.Parse(Console.ReadLine());

switch (estadoEmocional)
{
    case 1:
        Console.WriteLine("NPC: 'como você está linda hoje!'");
        break;
    case 2:
        Console.WriteLine("NPC 'tô meio cansada, mas tô bem sim. e você?'");
        break;
    case 3:
        Console.WriteLine("NPC: 'não tô me sentindo muito bem...");
        break;
    case 4:
        Console.WriteLine("NPC: 'não tô pra conversa hoje, cara. me deixa em paz!'");
        break;
    default:
        Console.WriteLine("estado emocional inválido.");
        break;
}


//4

Console.WriteLine("escolha um tipo de arma: espada, machado ou arco");
string arma = Console.ReadLine();

int dano = 25;
int velocidadeDeAtaque = 15;

switch (arma)
{
    case "espada":
        dano += 5;
        velocidadeDeAtaque += 3;
        break;
    case "machado":
        dano += 8;
        velocidadeDeAtaque -= 2;
        break;
    case "arco":
        dano += 4;
        velocidadeDeAtaque += 5;
        break;
    default:
        Console.WriteLine("arma desconhecida.");
        break;
}

Console.WriteLine("seus atributos finais são: dano = " + dano + "; velocidade de ataque = " + velocidadeDeAtaque);


//5

Console.WriteLine("digite um símbolo de runa!: ('F', 'A' ou 'T'):");
char runa = char.Parse(Console.ReadLine());

switch (runa)
{
    case 'F':
        Console.WriteLine("elemento: fogo");
        break;
    case 'A':
        Console.WriteLine("elemento: água");
        break;
    case 'T':
        Console.WriteLine("elemento: terra");
        break;
    default:
        Console.WriteLine("runa inválida.");
        break;
}