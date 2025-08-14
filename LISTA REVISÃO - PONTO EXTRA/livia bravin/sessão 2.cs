//1

Console.WriteLine("qual é o seu nível de ladinagem?");
int nivelLadinagem = int.Parse(Console.ReadLine());
if (nivelLadinagem > 15)
{
    Console.WriteLine("você desarmou a armadilha e ganha o tesouro.");
}
else if (nivelLadinagem > 10 && nivelLadinagem < 15)
{
    Console.WriteLine("você desarmou a armadilha, mas não ganhou o tesouro.");
}
else
{
    Console.WriteLine("a armadilha dispara e voce perdeu o HP.");
}

//2

Console.WriteLine("um guarda bloqueou seu caminho. como você irá abordá-lo? 1 (persuadir), 2 (subornar) ou 3 (lutar).");
int ação = int.Parse(Console.ReadLine());
int hp = 50;

if (ação == 1)
{
    Random dado = new Random();
    int resultado = dado.Next(1, 21);
    if (resultado > 10)
    {
        Console.WriteLine("parabéns! você convenceu o guarda. resultado do dado: " + resultado);
    }
    else
    {
        Console.WriteLine("ops! o guarda se irritou. resultado do dado: " + resultado);
    }
}
else if (ação == 2)
{
    Console.WriteLine("quanto ouro você oferece?");
    int ouroOferecido = int.Parse(Console.ReadLine());
    if (ouroOferecido > 50)
    {
        Console.WriteLine("o guarda aceitou, pode seguir em frente!");
    }
    else
    {
        Console.WriteLine("o guarda recusou sua oferta :(");
    }
}
else if (ação == 3)
{
    hp -= 10;
    Console.WriteLine("você lutou e seguiu em frente, mas perdeu 10 de HP. HP restante: " + hp);
}
else
{
    Console.WriteLine("escolha dessas opções: 1, 2 ou 3.");
}

//3

Console.WriteLine("qual é o tipo do seu ataque? fogo, água ou grama?:");
string tipoAtaque = Console.ReadLine();

Console.WriteLine("qual é o tipo do inimigo? fogo, água ou grama?:");
string tipoInimigo = Console.ReadLine();

if ((tipoAtaque == "fogo" && tipoInimigo == "grama") ||
    (tipoAtaque == "água" && tipoInimigo == "fogo") ||
    (tipoAtaque == "grama" && tipoInimigo == "água"))
{
    float multiplicador = 0.5f;
    Console.WriteLine("é super eficaz!");
}
else if (tipoAtaque == tipoInimigo)
{
    float multiplicador = 0.5f;
    Console.WriteLine("é pouco eficaz.");
}
else
{
    Console.WriteLine("dano normal.");
}

//4

Console.WriteLine("qual seu nível de furtividade?");
int furtividade = int.Parse(Console.ReadLine());

Console.WriteLine("qual seu nível de agilidade?");
int agilidade = int.Parse(Console.ReadLine());

Console.WriteLine("você tem carta de recomendação? (true/false)");
bool cartaRecomendacao = bool.Parse(Console.ReadLine());

if ((furtividade > 12 && agilidade > 14) || cartaRecomendacao)
{
    Console.WriteLine("você foi aceito na guilda dos ladrões.");
}
else
{
    Console.WriteLine("você foi recusado na guilda dos ladrões.");
}

//5

Console.WriteLine("qual é o clima atual? ensolarado, chuvoso ou nevando?");
string clima = Console.ReadLine();

Console.WriteLine("qual é a sua montaria? cavalo, lobo ou nenhuma?");
string montaria = Console.ReadLine();

int tempoViagem = 10;

if (clima == "chuvoso")
{
    tempoViagem += 2;
}
else if (clima == "nevando")
{
    if (montaria == "nenhuma")
    {
        tempoViagem += 5 * 2;
    }
    else
    {
        tempoViagem += 5;
    }
}

if (montaria == "cavalo")
{
    tempoViagem -= 3;
}
else if (montaria == "lobo")
{
    tempoViagem -= 4;
}

Console.WriteLine("seu tempo estimado de viagem é: " + tempoViagem + " horas");