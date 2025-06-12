// atividade 1

using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;
using System.Text;

string resposta;

Console.WriteLine("Elara, você quer beber a poção? (sim/nao)");
resposta = Console.ReadLine();

{
    if (resposta == "sim")
    {
        Console.WriteLine("Você bebe a poção! Um calor percorre seu corpo. (HP +10)");
     }
    else
    {
        Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz?");
    }
}

// atividade 2

string resposta2;

Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)");
resposta2 = Console.ReadLine();

{
    if (resposta2 == "sim")
    {
        Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
    }
    else
    {
        Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
    }
}

// atividade 3

string resposta3;

Console.WriteLine("A ponte parece instável. Você quer atravessar? (sim/nao)");
resposta3 = Console.ReadLine();

{
    if (resposta3 == "sim")
    {
        Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
    }
    else
    {
        Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
    }
}

// atividade 4

int nivel;

Console.WriteLine("Qual é o seu nível atual? (em numéro)");
nivel = int.Parse(Console.ReadLine());

{
    if (nivel >= 5)
    {
        Console.WriteLine("Você é forte o bastante! A caverna se abre.");
    }
    else
    {
        Console.WriteLine("Volte quando estiver mais forte, Elara.");
    }
}

// atividade 5

int cores;

Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
cores = int.Parse(Console.ReadLine());

{
    if (cores == 2)
    {
        Console.WriteLine("A porta se abre! O botão Azul estava certo.");
    }
    else if (cores == 3)
    {
        Console.WriteLine("O botão Verde não funcionou.");
    }
    else if (cores == 1)
    {
        Console.WriteLine("Nada acontece com o botão Vermelho.");
    }
    else
    {
        Console.WriteLine("Escolha inválida, Elara.");
    }
}

// atividade 6
int moedas;
string resp;

Console.WriteLine("Quantas moedas de ouro você tem?");
moedas = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
resp = Console.ReadLine();

{
    if (moedas >= 100 && resp == "sim")
    {
        Console.WriteLine("Oferta especial! Você recebe uma espada mágica com desconto!");
    }
    else if (moedas >= 100 && resp == "nao")
    {
        Console.WriteLine("Você pode comprar uma espada normal");
    }
    else if (moedas < 100 && resp == "sim")
    {
        Console.WriteLine("Como membro, você recebe um escudo");
    }
    else
    {
        Console.WriteLine("Volte quando tiver moedas ou entrar pra guilda");
    }
}

// atividade 7
string gema;
string orbe;
string poder;

Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
gema = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar ? (sim/nao)");
orbe = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
poder = Console.ReadLine();

{
    if ((gema == "sim" && orbe == "sim") || poder == "sim")
    {
        Console.WriteLine("O portal se estabiliza e você pode atravessar!");
    }
    else
    {
        Console.WriteLine("O portal continua instável. Você não pode passar.");
    }
}

// atividade 8
string goblin;
string olho;

Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
goblin = Console.ReadLine();
Console.WriteLine("Você tem um 'Olho de Dragão Polido? (sim/nao)");
olho = Console.ReadLine();

{
    if ((goblin == "sim") || (olho == "sim"))
    {
        Console.WriteLine("O goblin aceitou negociar");
    }
    else
    {
        Console.WriteLine("O goblin não aceitou negociar");
    }
}

// atividade 9
int tunel;
string escolha;
string escolha2;

Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
tunel = int.Parse(Console.ReadLine());

{
    if (tunel == 1) 
    {
        Console.WriteLine("Você sente o chão escorregadio");
        Console.WriteLine("Continuar mesmo assim ou voltar? (continuar / voltar)");
        escolha = Console.ReadLine();
        if (escolha == "continuar")
        {
            Console.WriteLine("Você escorrega, mas cai em um local com tesouros");
        }
        else if (escolha == "voltar")
        {
            Console.WriteLine("Você volta, mas sem descobrir os segredos da caverna");
        }
        else
        {
            Console.WriteLine("Você fica parado, ouvindo o barulho da caverna");
        }
    }
    else if (tunel == 2)
    {
        Console.WriteLine("O brilho aumenta...");
        Console.WriteLine("Tocar no cristal ou ignorar? (tocar/ignorar)");
        escolha2 = Console.ReadLine();

        if (escolha2 == "tocar")
        {
            Console.WriteLine("Você ganha poderes temporários");
        }
        else if (escolha2 == "ignorar")
        {
            Console.WriteLine("Você ignora e continua por um túnel escuro");
        }
        else
        {
            Console.WriteLine("O brilho sumiu");
        }
    }
    else
    {
        Console.WriteLine("Você fica perdido na entrada da caverna");
    }
}

//atividade 10
string pericia;
string feitico;
string cristal;

Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
pericia = Console.ReadLine();

Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
feitico = Console.ReadLine();

Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
cristal = Console.ReadLine();

{
    if ((pericia == "sim" && feitico == "sim") || (feitico == "sim" && cristal == "sim"))
    {
    Console.WriteLine("Elara liberta o grifo");
    }
    else
    {
    Console.WriteLine("O grifo continua preso");
    }
}