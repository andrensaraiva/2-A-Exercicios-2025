// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("A poção misteriosa");
Console.WriteLine("Você quer beber a poção?");
string resposta = Console.ReadLine();
if (resposta == "sim")
{
    Console.WriteLine("Um calor percorre seu corpo. (HP +10)");
}
  else 
{
    Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz");   
}

Console.WriteLine("O baú trancado");
Console.WriteLine("Você tem a 'Chave de Cobre'?");
string resposta2 = Console.ReadLine();
if (resposta2 == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}
else
{
    Console.WriteLine("O baú está trancado, você precisa da chave correta");
}

Console.WriteLine("A ponte frágil");
Console.WriteLine("A ponte parece instável. Você quer atravessar? ");
string resposta3 = Console.ReadLine();
if (resposta3 == "sim")
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança ");
}
else
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor se prevenir");
}


Console.WriteLine("O nível do desafio");
Console.WriteLine("Qual é o seu nível atual? ");
int numero = int.Parse(Console.ReadLine());
if (numero >= 5)
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre ");
}
else
{
    Console.WriteLine("Volte quando estiver mais forte Elara");
}


Console.WriteLine("O enigma das cores");
Console.WriteLine("Qual botão você aperta? 1 = Vermelho, 2 = Azul, 3 = Verde");
int numero1 = int.Parse(Console.ReadLine());
if (numero1 == 2)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo. ");
}
else if (numero1 == 1)
{
    Console.WriteLine("Nada acontece com o botão Vermelho");
}
else if (numero1 == 3)
{
    Console.WriteLine("O botão Verde não funcionou.");
}
else
{
    Console.WriteLine("Escolha inválida, Elara.");
}


Console.WriteLine("A Oferta do Ferreiro");
Console.WriteLine("Quantas moedas de ouro você tem?");
int moeda = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
string guilda = Console.ReadLine();
if (moeda >= 30 && guilda == "sim")
{
    Console.WriteLine("Você pode comprar vários items ");
}
else if (moeda >= 30 && guilda == "não")

{
    Console.WriteLine("Você não consegue comprar alguns items");
}
 else if (moeda < 30 && guilda == "sim")
{
    Console.WriteLine("Você não consegue comprar alguns items");
}
else if (moeda < 30 && guilda == "não")
{
    Console.WriteLine("Você não consegue comprar nada");
}


Console.WriteLine(" O Portal Instável ");
Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string gema = (Console.ReadLine());
Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string orbe = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string poder = Console.ReadLine();
if (gema == "sim " && orbe == "sim" || poder == "sim")
{
    Console.WriteLine("Você pode passar pelo portal");
}
else
{
    Console.WriteLine("Você não pode passar pelo portal");
}


Console.WriteLine("A Negociação com o Goblin Astuto");
Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
string humor = Console.ReadLine();
Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
string olho = Console.ReadLine();
if ( humor == "sim" || olho == "sim" )
{
    Console.WriteLine("Você pode negociar");
}
else
{
    Console.WriteLine("Você não pode negociar");
}




Console.WriteLine(" A Caverna dos Ecos");
Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
int caverna = int.Parse(Console.ReadLine());
if (caverna == 1)
{
    Console.WriteLine("Ao entrar no túnel você encontra um lampião");
    Console.WriteLine("Você pega(Sim/Não)");
    string condicao = Console.ReadLine();
    if (condicao == "Sim")
    {
        Console.WriteLine("Você ganha um lampião");
    }
    else
    {
        Console.WriteLine("Você deixa a caverna");
    }
}
else if (caverna == 2)
{
    Console.WriteLine("Você entra no túnel e encontra uma espada brilhante ");
    Console.WriteLine("Você pega(Sim/Não)");
    string condicao2 = Console.ReadLine();
    if (condicao2 == "Sim")
    {
        Console.WriteLine("Você tem a espada justiceira");
    }

    else
    {
        Console.WriteLine("Você tenta sair, mas encontra um inimigo");
    }
}





Console.WriteLine("Resgate do Grifo");
Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
string pericia = Console.ReadLine();
Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
 string feitico = Console.ReadLine();
Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
string cristal = Console.ReadLine();
if (pericia == "Sim" && feitico == "Sim")
{
    Console.WriteLine("O grifo foi liberado");
}
else if (pericia == "Sim" && cristal == "Sim")
{
    Console.WriteLine("O grifo foi liberado");
}
else
{
    Console.WriteLine("O grifo continua preso");
}