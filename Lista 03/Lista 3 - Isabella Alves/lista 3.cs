//1- A Poção Misteriosa

using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Elara, você quer beber a poção?(sim/não)");
string resposta1 = Console.ReadLine();
if (resposta1 == "sim")
{
    Console.WriteLine("Você bebe a poção! Um calor percorre seu corpo. (HP + 10)");
}
else
{
    Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz ? ");
}

//2- O Baú Trancado

Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)");
string resposta2 = Console.ReadLine();
if (resposta2 == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}
else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
}

//3- A Ponte Frágil

Console.WriteLine("A ponte parece instável. Você quer atravessar?(sim / nao)");
string resposta3 = Console.ReadLine();
if (resposta3 == "sim")
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
}
else
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
}

//4- O Nível do Desafio

Console.WriteLine("Qual é o seu nível atual?");
int numero1 = int.Parse(Console.ReadLine());
if (numero1 >= 5)
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}
else
{
    Console.WriteLine("Volte quando estiver mais forte, Elara.");
}

//5- O Enigma das Cores

Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
int numero2 = int.Parse(Console.ReadLine());
if (numero2 == 2)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");
}
else if (numero2 == 1)
{
    Console.WriteLine("Nada acontece com o botão Vermelho.");
}
else if (numero2 == 3)
{
    Console.WriteLine("O botão Verde não funcionou.");
}
else
{
    Console.WriteLine("Escolha inválida, Elara.");
}

//6- A Oferta do Ferreiro

Console.WriteLine("Quantas moedas de ouro você tem?(precisa de mais de 50)");
int numero3 = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
string resposta4 = Console.ReadLine();

if (resposta4 == "sim" && numero3 < 50)
{
    Console.WriteLine("Você é da guilda mas nao consegue comprar muita coisa");
}
else if (resposta4 == "nao" && numero3 > 50)
{
    Console.WriteLine("Você nao possui desconto na ferralharia");
}
else if (numero3 <= 10 && resposta4 == "nao")
{
    Console.WriteLine("Voce nao consegue comprar nada");
}
else if (resposta4 == "sim" && numero3 > 50)
{
    Console.WriteLine("Voce consegue comprar a maioria das coisas da loja");
}

//7- O Portal Instável

Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string resposta5 = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string resposta6 = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string resposta7 = Console.ReadLine();

if (resposta5 == "sim" && resposta6 == "sim" || resposta7 == "sim")
{
    Console.WriteLine("Passagem é permitida");
}

//8- A Negociação com o Goblin Astuto

Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
string resposta8 = Console.ReadLine();
Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
string resposta9 = Console.ReadLine();

if (resposta8 == "sim" || resposta9 == "sim")
{
    Console.WriteLine("O goblin aceita negociar!");
}

//9- A Caverna dos Ecos

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

//10- Resgate do Grifo

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

