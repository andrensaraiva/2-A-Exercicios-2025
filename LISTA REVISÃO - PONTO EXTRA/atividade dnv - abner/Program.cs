// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

string Nomemonstro = "monark";
int hpMonstro = 120;
float VelocidadeDoAtaque = 4.0f;
bool chefeDaFase = false;
Console.WriteLine("O monstro se chama: " + Nomemonstro);
Console.WriteLine("O monstro tem uma velocidade de : " + VelocidadeDoAtaque);
Console.WriteLine("O monstro tem: " + hpMonstro + " de hp");
Console.WriteLine("se ele é o chefe da fase: " + chefeDaFase);
int danoPersonagem;
int defesaMonstro;
Console.WriteLine("Quanto de dano seu personagem deu? ");
danoPersonagem = int.Parse(Console.ReadLine());
Console.WriteLine("Quanto de defesa o monstro deu? ");
defesaMonstro= int.Parse(Console.ReadLine());
int danoFinal = danoPersonagem - defesaMonstro;
Console.WriteLine("seu dano final é " + danoFinal);
float vidaRestante = 100.0f - danoFinal;
Console.WriteLine(vidaRestante+"%");


Console.WriteLine("quantos dolars vc tem?");
float dolar = int.Parse(Console.ReadLine());
float dolarVenezuelanos = dolar * 15.5f;
Console.WriteLine("voce caiu em um golpe de bitcoin e agora " + dolarVenezuelanos + " dolares venezuelanos" );

Console.WriteLine("a porta está aberta?");
bool portaAberta = bool.Parse(Console.ReadLine());
Console.WriteLine("voce tem chave?");
bool terAChave = bool.Parse(Console.ReadLine());
bool entrar = (portaAberta || terAChave);
if (entrar)
{
    Console.WriteLine("voce entrou");

        }
Console.WriteLine("fala se nome, sua classe e seu nivel");
  string nome = Console.ReadLine(); 
 string classe = Console.ReadLine();
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("Sr/a " + nome + " da/o classe " + classe + " e de nivel " + nivel);
// segunda parte
Console.WriteLine(" voce encontrou um bau, qual seu nivel de sapecagem?");
int sapecagem = int.Parse(Console.ReadLine());
if (sapecagem > 15)
{

    Console.WriteLine("voce abriu a armadilha e pegou a grana");
    dolar = 100 + dolar;

}

else if (sapecagem < 15 && sapecagem >= 10)
{
    Console.WriteLine("você escapou por pouco da armadilha mas não ganhou nada");


}


else if (sapecagem < 10)
{
    Console.WriteLine("voce caiu na armadilha");
    dolar = 0;

}
Console.WriteLine("voce quer passsar para cidade mas tem um guarda chato");
Console.WriteLine("quer: subornar, persuardir ou lutar");
int hp = 100;
string escolhas = Console.ReadLine();
bool passarPeloGuarda;
if (escolhas == "subornar")
{
    Console.WriteLine("quanto de dinehiro voce quer ofecerer?");
    int suborno = int.Parse(Console.ReadLine());
    if (suborno >= 50) ;
    {
        passarPeloGuarda = true;


    }

}
else if (escolhas == "persuadir")
{
    Random dado = new Random();
     int valueDado = dado.Next(1,50);
    if (valueDado >= 25) ;
    {
        passarPeloGuarda = true;

    }


}
else if  (escolhas == "lutar")
{
    hp = hp - 30;
    Console.WriteLine("voce passou mas agr tem " + hp);
    passarPeloGuarda = true;



}
if (passarPeloGuarda = true)
{

    Console.WriteLine("voce passou pelo guarda");


}
else if (passarPeloGuarda = false) 
{
    Console.WriteLine("voce não passou");
}
Console.WriteLine("voce tera que enfrentar um desafio, escolha seu ataque ");
Console.WriteLine("agua");
Console.WriteLine("terra");
Console.WriteLine("fogo");
string escolhaHEroi =  Console.ReadLine ();
Console.WriteLine("voce tera que enfrentar um desafio, escolha a classe do seu oponente");
Console.WriteLine("agua");
Console.WriteLine("terra");
Console.WriteLine("fogo");
string escolhaOponente = Console.ReadLine();
Console.WriteLine("quanto de dano voce pretende dar?");

int dano = int.Parse(Console.ReadLine()); 
if (escolhaHEroi == "fogo" && escolhaOponente == "grama" )
{
    dano = dano * 2;
    Console.WriteLine("voce dobrou seu ataque " + dano);



}
else if (escolhaHEroi == "agua" && escolhaOponente == "fogo")
{
    dano = dano * 2;
    Console.WriteLine("voce dobrou seu ataque " + dano);



}
else if (escolhaHEroi == "grama" && escolhaOponente == "agua")
{
    dano = dano * 2;
    Console.WriteLine("voce dobrou seu ataque " + dano);



}

else if (escolhaHEroi == "grama" && escolhaOponente == "grama")
{
    dano = dano / 2;
    Console.WriteLine("voce si deu mal seu ataque " + dano);



}
else if (escolhaHEroi == "agua" && escolhaOponente == "agua")
{
    dano = dano / 2;
    Console.WriteLine("voce si deu mal seu ataque " + dano);



}
else if (escolhaHEroi == "fogo" && escolhaOponente == "fogo")
{
    dano = dano / 2;
    Console.WriteLine("voce si deu mal seu ataque " + dano);



}
else
{
    Console.WriteLine("seu ataque deu certo");


}
int velocidade;
int forca;
Console.WriteLine("voce quer qual arma?");
Console.WriteLine("1.espada");
Console.WriteLine("2. machado");
Console.WriteLine("3.arco");
int escolhaArma = int.Parse(Console.ReadLine());
switch (escolhaArma)    
    {
    case 1:
        velocidade = 5; 
        forca = 5;
        break;
    case 2:
        velocidade = 2;
        forca = 8;
        break;
    case 3:
        velocidade = 8;
        forca = 2;
        break;
    
}


string[] nomeItens = new string[3];
nomeItens[0] = "sapato do mario";
nomeItens[1] = "sandalia do rari poter";
nomeItens[2] = "tenis do sonic";
int[] valorItens = new int[3];
valorItens[0] = 30;
valorItens[1] = 40;
valorItens[2] = 50;
Console.WriteLine("escolha um numero de 1 a 3");
int escolhaItens = int.Parse(Console.ReadLine());
switch (escolhaItens)
{
    case 1:
       Console.WriteLine("voce ganhou " + nomeItens[0] + "que vale " + valorItens[0] );
        break;
    case 2:
        Console.WriteLine("voce ganhou " + nomeItens[1]+ "que vale " + valorItens[1]);
        break;
    case 3:
        Console.WriteLine("voce ganhou " + nomeItens[2] + "que vale " + valorItens[2]);
        break;

}

string[] inimigosDaFase = { "1.cuspe apaixonante", "2.catarro toxico", "3.bundada insana" };

int hpChefe = 100;
Console.WriteLine("escolha um ataque");
while (hpChefe > 0)
{
    for (int i = 0; i < inimigosDaFase.Length; i++)
    {
        Console.WriteLine($"seus ataques restantes: {inimigosDaFase[i]}");
       
    }
    int escolhaDoAtaque = int.Parse(Console.ReadLine());
    switch (escolhaDoAtaque)
    {
        case 1:
            Random dado = new Random();
            hpChefe = hpChefe - dado.Next(1, 50);
            Console.WriteLine("restam  " + hpChefe + " de hp");
            break;
        case 2:
            Random dado1 = new Random();
            hpChefe = hpChefe - dado1.Next(1, 50);
            Console.WriteLine("restam  " + hpChefe + " de hp");
            break;
        case 3:
            Random dado2 = new Random();
            hpChefe = hpChefe - dado2.Next(1, 50);
            Console.WriteLine("restam  " + hpChefe + " de hp");
            break;

    }
}