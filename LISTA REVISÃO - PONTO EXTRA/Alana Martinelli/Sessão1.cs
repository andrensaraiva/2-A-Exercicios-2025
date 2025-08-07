//O dominio das variaveis e tipos

//Ficha de monstro

string nome = "Lobisomem";
int hp = 80;
float velocidadeDeAtaque = 30.5f;
bool chefeDeFase = false;
Console.WriteLine("Nome: " + nome + "; HP: " + hp + "; Velocidade: " + velocidadeDeAtaque + ";" + "`É chefe de fase: " + chefeDeFase);

//Calculadora de batalha

int danoDoJogador;
int defesaDoMonstro;
Console.WriteLine("Digite o seu dano.");
danoDoJogador = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a defesa do monstro.");
defesaDoMonstro = int.Parse(Console.ReadLine());
int danoFinal = danoDoJogador - defesaDoMonstro;
Console.WriteLine("O dano final é: " + danoFinal);
float vidaRestantePercentual = 100f;
Console.WriteLine("A vida restante é " + (vidaRestantePercentual - danoFinal));

//Conversor de moedas arcanas

float dragaoDeOuro = 15.5f;
Console.WriteLine("Quantos Dragões de Ouro você possui?");
int dragoesDoJogador = int.Parse(Console.ReadLine());
float gemasDePrata = dragoesDoJogador * dragaoDeOuro;
Console.WriteLine("Você tem " + gemasDePrata + " gemas de prata");

//Verificador de condição

bool jogadorTemChave;
bool portaEstaAberta;
Console.WriteLine("Você tem a chave? (true/false)");
jogadorTemChave = bool.Parse(Console.ReadLine());
Console.WriteLine("A porta está aberta? (true/false)");
portaEstaAberta = bool.Parse(Console.ReadLine());
if (jogadorTemChave == true || portaEstaAberta == true)
{
    bool podePassar = true;
    Console.WriteLine("Você pode passar.");
}
else
{
    Console.WriteLine("Você não pode passar.");
}

//Criador de titulo de heroi

Console.WriteLine("Qual seu nome de herói?");
string nomeHeroi = Console.ReadLine();

Console.WriteLine("Qual sua classe?");
string classeHeroi = Console.ReadLine();

Console.WriteLine("Qual seu nível?");
int nivelHeroi = int.Parse(Console.ReadLine());

Console.WriteLine("Sr.(a) " + nomeHeroi + ", o " + classeHeroi + " de nível " + nivelHeroi);