// Seção 1
string nome = "";
int hp = 0;
float velocidadeDeAtaque = 0;
bool ehChefeDeFase = false;

Console.WriteLine("ficha:");
Console.WriteLine("HP: " + hp);
Console.WriteLine("Nome: " + nome);
Console.WriteLine("velocidade: " + velocidadeDeAtaque);
Console.WriteLine("Chefe: " + ehChefeDeFase);

int danoDoJogador;
int defesaDoMonstro;
Console.WriteLine("atribua valores para dano do jogador e defesa do monstro");
Console.WriteLine("Dano do jogador:");
danoDoJogador = int.Parse(Console.ReadLine());
Console.WriteLine("defesa do monstro:");
defesaDoMonstro = int.Parse(Console.ReadLine());
Console.WriteLine((danoDoJogador - defesaDoMonstro));
float vidaRestantePercentual = 100f;
Console.WriteLine("vida restante percentual:");
Console.WriteLine(vidaRestantePercentual - (danoDoJogador - defesaDoMonstro));

float DragaodeOuro = 0;
float GemasdePrata = 15.5f;
Console.WriteLine("tem quantos dragões de ouro?");
DragaodeOuro = float.Parse(Console.ReadLine());
Console.WriteLine("isso vai dar: " + (DragaodeOuro * GemasdePrata) + " gemas");

bool jogadorTemChave;
bool portaEstaAberta;
bool podePassar;
Console.WriteLine("jogador Tem Chave?  digite true ou false");
jogadorTemChave = bool.Parse(Console.ReadLine());
Console.WriteLine("porta Esta Aberta?  digite true ou false");
portaEstaAberta = bool.Parse(Console.ReadLine());
if (jogadorTemChave = true)
{
    Console.WriteLine("Pode Passar");
}

if (portaEstaAberta = true)
{
    Console.WriteLine("Pode Passar");
}
else
{
    Console.WriteLine(" não pode passar");
}

string nomeUsuario;
string classe;
int nivel;
Console.WriteLine("seu nome?");
nomeUsuario = Console.ReadLine();
Console.WriteLine("sua classe?");
classe = Console.ReadLine();
Console.WriteLine("seu nivel?");
nivel = int.Parse(Console.ReadLine());
string tituloCompleto = "Sir " + nomeUsuario + ", o " + classe + "de nivel " + nivel;
Console.WriteLine(tituloCompleto);


// seção 2
int ladinagem;
Console.WriteLine("qual seu nivel de ladinagem");
ladinagem = int.Parse(Console.ReadLine());
if (ladinagem > 15)
{
    Console.WriteLine("desarma a armadilha e ganha o tesouro");

}
else if (ladinagem > 10)
{
    Console.WriteLine("ele desarmarna armadilha mas não ganha nada");
}
else
{
    Console.WriteLine("armadilha dispara e perde HP");
}

Console.WriteLine("Um guarda bloqueia seu caminho. Como você vai abordar o guarda: persuadir, subornar ou lutar");
string escolhaJogador = Console.ReadLine();
Random random = new Random();
int rnd = random.Next(20);
if (escolhaJogador == "persuadir")
{
    if (rnd >= 10)
    {
        Console.WriteLine("consegue passar");
    }
    else
    {
        Console.WriteLine("o guarda fica irritado.");
    }
}
else if (escolhaJogador == "subornar")
{
    Console.WriteLine("quanto ouro ele oferece");
    int ouro1 = int.Parse(Console.ReadLine());
    if (ouro1 > 50)
    {
        Console.WriteLine("ele passa");
    }
    else
    {
        Console.WriteLine("nao passa");
    }
}
else
{
    Console.WriteLine("o jogador perde HP, mas consegue passar");
}

int nivelFurtividade;
int nivelAgilidade;
Console.WriteLine(" nível de futividade ");
nivelFurtividade = int.Parse(Console.ReadLine());
Console.WriteLine(" nível de Agilidade ");
nivelAgilidade = int.Parse(Console.ReadLine());
bool cartaDeRecomendacao;
Console.WriteLine("Carta de Recomendação");
cartaDeRecomendacao = bool.Parse(Console.ReadLine());

if (nivelFurtividade > 12 && nivelAgilidade > 14)
{
    Console.WriteLine("aceito");
}
else if (cartaDeRecomendacao = true)
{
    Console.WriteLine("aceito");
}
else
{
    Console.WriteLine("nao aceito");
}


string clima;
Console.WriteLine("Qual o clima atual? (Ensolarado, Chuvoso ou Nevando)");
clima = Console.ReadLine();
string montaria;
Console.WriteLine("Qual sua montaria? (Cavalo, Lobo ou Nenhuma)");
montaria = Console.ReadLine();

int tempoDaViagem = 10;

if (clima == "Chuvoso")
{
    tempoDaViagem += 2;
}
else if (clima == "Nevando")
{
    if (montaria == "Nenhuma")
    {
        tempoDaViagem += 5 * 2;
    }
    else
    {
        tempoDaViagem += 5;
    }
}

if (montaria == "Cavalo")
{
    tempoDaViagem -= 3;
}
else if (montaria == "Lobo")
{
    tempoDaViagem -= 4;
}

Console.WriteLine("Tempo previsto da viagem: " + tempoDaViagem + " horas");

// seção 3

int ouro = 500;
int escolhaPocao;
Console.WriteLine("qual poção vc quer?");
Console.WriteLine("[1] Poção de Cura (custa 120 ouro)");
Console.WriteLine("[2] Poção de Força (custa 300 ouro)");
Console.WriteLine("[3] Poção de Mana (custa 150 ouro)");
Console.WriteLine("Escolha sua poção digitando o número:");
escolhaPocao = int.Parse(Console.ReadLine());

switch (escolhaPocao)
{
    case 1:
        ouro -= 120;
        Console.WriteLine("Vc comprou a poção de cura. ouro restante: " + ouro);
        break;
    case 2:
        ouro -= 300;
        Console.WriteLine("Vc comprou a poção de força. ouro restante: " + ouro);
        break;
    case 3:
        ouro -= 150;
        Console.WriteLine("Vc comprou a poção de mana. ouro restante: " + ouro);
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

string cidade;
Console.WriteLine("para qual cidade deseja viajar? (Ventobravo, Orgrimmar ou Dalaran):");
cidade = Console.ReadLine();

switch (cidade)
{
    case "Ventobravo":
        Console.WriteLine("Custo: 200 ouro. Uma cidade calma e tranquila, vc vai ser muito feliz lá.");
        break;
    case "Orgrimmar":
        Console.WriteLine("Custo: 180 ouro. Orgrimmar, uma cidade com as melhores tecnologias do planeta.");
        break;
    case "Dalaran":
        Console.WriteLine("Custo: 160 ouro. Dalaran, a cidade dos marombas viciados em proteína.");
        break;
    default:
        Console.WriteLine("cidade não encontrada.");
        break;
}
