//O poder das escolhas

//O bau do tesouro com armadilha

Console.WriteLine("Qual seu nível de Ladinagem?");
int nivelLadinagem = int.Parse(Console.ReadLine());
if (nivelLadinagem > 15)
{
    Console.WriteLine("Você desarma a armadilha e ganha o tesouro.");
}
else if (nivelLadinagem > 10 && nivelLadinagem < 15)
{
    Console.WriteLine("Você desarma a armadilha, mas não ganha o tesouro.");
}
else
{
    Console.WriteLine("A armadilha dispara e voce perde HP.");
}

//Dialogo com consequencias

Console.WriteLine("Um guarda bloqueia seu caminho. Como você irá abordá-lo: persuadir(1), subornar(2) ou lutar(3).");
int acao = int.Parse(Console.ReadLine());
int hp = 40;

if (acao == 1)
{
    Random dado = new Random();
    int resultado = dado.Next(1, 21);
    if (resultado > 10)
    {
        Console.WriteLine("Você convenceu o guarda. Resultado do dado: " + resultado);
    }
    else
    {
        Console.WriteLine("O guarda ficou irritado. Resultado do dado: " + resultado);
    }
}
else if (acao == 2)
{
    Console.WriteLine("Quanto ouro você oferece?");
    int ouroOferecido = int.Parse(Console.ReadLine());
    if (ouroOferecido > 50)
    {
        Console.WriteLine("O guarda aceita e deixa você passar.");
    }
    else
    {
        Console.WriteLine("O guarda recusou sua oferta.");
    }
}
else if (acao == 3)
{
    hp -= 10;
    Console.WriteLine("Você lutou e passou, mas perdeu 10 de HP. HP restante: " + hp);
}
else
{
    Console.WriteLine("Escolha uma das opções 1, 2 ou 3");
}

//Sistema de dano elemental

Console.WriteLine("Escolha o tipo do seu ataque (Fogo, Água ou Grama):");
string tipoAtaque = Console.ReadLine();

Console.WriteLine("Escolha o tipo do inimigo (Fogo, Água ou Grama):");
string tipoInimigo = Console.ReadLine();

if ((tipoAtaque == "Fogo" && tipoInimigo == "Grama") ||
    (tipoAtaque == "Água" && tipoInimigo == "Fogo") ||
    (tipoAtaque == "Grama" && tipoInimigo == "Água"))
{
    float multiplicador = 0.5f;
    Console.WriteLine("É super eficaz!");
}
else if (tipoAtaque == tipoInimigo)
{
    float multiplicador = 0.5f;
    Console.WriteLine("É pouco eficaz!");
}
else
{
    Console.WriteLine("Dano normal.");
}

//Verificador de acesso à guilda

Console.WriteLine("Qual seu nível de Furtividade?");
int furtividade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual seu nível de Agilidade?");
int agilidade = int.Parse(Console.ReadLine());

Console.WriteLine("Você tem Carta de Recomendação? (true/false)");
bool cartaRecomendacao = bool.Parse(Console.ReadLine());

if ((furtividade > 12 && agilidade > 14) || cartaRecomendacao)
{
    Console.WriteLine("Você foi aceito na Guilda dos Ninjas.");
}
else
{
    Console.WriteLine("Você foi recusado na Guilda dos Ninjas.");
}

//Clima e viagem

Console.WriteLine("Qual o clima atual? (ensolarado, chuvoso ou nevando)");
string clima = Console.ReadLine();

Console.WriteLine("Qual sua montaria? (cavalo, lobo ou nenhuma)");
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

Console.WriteLine("Tempo estimado da viagem: " + tempoViagem + " horas");