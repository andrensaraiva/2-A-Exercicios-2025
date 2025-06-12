string a = "";
string b = "";

Console.WriteLine("você entra na caverna escura e pode seguir para dois lados, para qual vc vai? " +
    "esquerda ou direita?");
a = Console.ReadLine();
if (a == "esquerda")
{
    Console.WriteLine("o tunel da esquerda é escuro e parece seguir por vários kilômetros");
    Console.WriteLine("você pode seguir em frente ou usar o seu feitiço de visão do futuro para ver se esse caminho é o certo");
    Console.WriteLine("seguir ou feitiço?");
    b = Console.ReadLine();
    if (b == "seguir")
    {
        Console.WriteLine("você seguiu reto e encontrou uma saída da caverna, porém ela estava trancada, você vai ter que voltar ao inicio");
    }
    else if (b == "feitiço")
    {
        Console.WriteLine("seu feitiço mostrou que você está no caminho certo, então você segue em frente e encontra uma sala com vários tesouros"); 
    } 
    else
    {
        Console.WriteLine("não entendi");
    }
}
else if (a == "direita")
{
    Console.WriteLine("o tunel da direita é grande e humido e você ouve um barulho ao longe ");
    Console.WriteLine("você pode seguir em frente ou usar o seu feitiço de visão do futuro para ver se esse caminho é o certo");
    Console.WriteLine("seguir ou feitiço?");
    b = Console.ReadLine();
    if (b == "seguir")
    {
        Console.WriteLine("você seguiu até o final do tunel e achou o seu cão-tartaruga que você tinha perdido. ele quase morreu de felicidade quando te viu.");
    }
    else if (b == "feitiço")
    {
        Console.WriteLine("seu feitiço mostrou que você está no caminho certo, mas quando você seguiu até o final não achou um tesouro, mas sim a saída da caverna");
    }
    else
    {
        Console.WriteLine("não entendi");
    }
}
14