//1

string nome = "Vampiro";
int hp = 100;
float velocidadeDeAtaque = 50.5f;
bool chefeDeFase = false;
Console.WriteLine("nome: " + nome + "; HP: " + hp + "; velocidade: " + velocidadeDeAtaque + ";" + "é chefe de fase: " + chefeDeFase);

//2

int danoDoJogador;
int defesaDoMonstro;
Console.WriteLine("qual é o seu dano?");
danoDoJogador = int.Parse(Console.ReadLine());
Console.WriteLine("digite a defesa do monstro.");
defesaDoMonstro = int.Parse(Console.ReadLine());
int danoFinal = danoDoJogador - defesaDoMonstro;
Console.WriteLine("seu dano final é: " + danoFinal);
float vidaRestantePercentual = 100f;
Console.WriteLine("sua vida que resta é " + (vidaRestantePercentual - danoFinal));

//3

float dragaoOuro = 15.5f;
Console.WriteLine("quantos dragões de ouro você possui?");
int dragoesDoJogador = int.Parse(Console.ReadLine());
float gemasDePrata = dragoesDoJogador * dragaoOuro;
Console.WriteLine("você tem " + gemasDePrata + " gemas de prata");

//4

bool jogadorPossuiUmaChave;
bool portaEstaAberta;
Console.WriteLine("você tem possui uma chave? (true/false)");
jogadorPossuiUmaChave = bool.Parse(Console.ReadLine());
Console.WriteLine("a porta está aberta? (true/false)");
portaEstaAberta = bool.Parse(Console.ReadLine());
if (jogadorPossuiUmaChave == true || portaEstaAberta == true)
{
    bool podeSeguirEmFrente = true;
    Console.WriteLine("vá em frente.");
}
else
{
    Console.WriteLine("você não pode seguir em frente");
}


//5

Console.WriteLine("qual é o seu nome?");
string nomeHeroi = Console.ReadLine();

Console.WriteLine("qual é a sua classe?");
string classeHeroi = Console.ReadLine();

Console.WriteLine("qual é o seu nível?");
int nivelHeroi = int.Parse(Console.ReadLine());

Console.WriteLine("sr.(a) " + nomeHeroi + ", o " + classeHeroi + " de nível " + nivelHeroi);