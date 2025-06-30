Console.WriteLine("Elara, você quer beber a poção? (sim/nao)");
string resposta = Console.ReadLine();


if (resposta == "sim")
{
    Console.WriteLine("Você bebe a poção! Um calor percorre seu corpo. (HP + 10)");
}
else
{
    Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz ? ");
}





Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)");
string ans = Console.ReadLine();


if (ans == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}
else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
}






Console.WriteLine("A ponte parece instável. Você quer atravessar? (sim / nao)");
string resp = Console.ReadLine();


if (resp == "sim")
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
}
else
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
}







Console.WriteLine("Qual é o seu nível atual?");
string respo = Console.ReadLine();


if (respo == "sim")
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}
else
{
    Console.WriteLine("Volte quando estiver mais forte, Elara.");
}







Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
int numero = int.Parse(Console.ReadLine());


if (numero == 1)
{
    Console.WriteLine("Nada acontece com o botão Vermelho.");
}
else if (numero == 2)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");
}
else if (numero == 3)
{
    Console.WriteLine("O botão Verde não funcionou.");
}
else if (numero >= 4)
{
    Console.WriteLine("Escolha inválida, Elara.");
}
else if (numero <= 0)
{
    Console.WriteLine("Escolha inválida, Elara.");
}







Console.WriteLine("Quantas moedas de ouro você tem?");
int moedas = int.Parse(Console.ReadLine());

Console.WriteLine("Você é membro da Guilda? (sim/nao)");
string respos = Console.ReadLine();


if (moedas >= 100 && respos == "sim")
{
    Console.WriteLine("Oferta especial! Você recebe um desconto de 50%!");
}
else if (moedas >= 100 && respos == "nao")
{
    Console.WriteLine("Você pode comprar, mas sem desconto.");
}
else if (moedas < 100 && respos == "sim")
{
    Console.WriteLine("Você é da Guilda, mas não tem ouro suficiente.");
}
else
{
    Console.WriteLine("Volte quando for membro da Guilda e tiver mais ouro.");
}








Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string respostae = Console.ReadLine();

Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string respostao = Console.ReadLine();

Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string respostaa = Console.ReadLine();


if (respostae == "sim" && respostao == "sim" || respostaa == "sim")
{
    Console.WriteLine("portão estabiliza");
}
else
{
    Console.WriteLine("Portão não disponível");
}



Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
string respostboa = Console.ReadLine();

Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
string respostcerta = Console.ReadLine();

if (respostboa == "sim" || respostcerta == "sim")
{
    Console.WriteLine("O goblin aceita negociar com você.");
}
else
{
    Console.WriteLine("O goblin se recusa a negociar.");
}



Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
string escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.WriteLine("Você escolheu o túnel úmido. Deseja seguir o som da água? (sim/nao)");
    string seguirAgua = Console.ReadLine();

    if (seguirAgua == "sim")
    {
        Console.WriteLine("Você encontra um lago subterrâneo com peixes luminescentes.");
    }
    else
    {
        Console.WriteLine("Você se perde entre as paredes escorregadias da caverna.");
    }
}
else if (escolha == "2")
{
    Console.WriteLine("Você escolheu o túnel com brilho. Deseja investigar a luz? (sim/nao)");
    string investigarLuz = Console.ReadLine();

    if (investigarLuz == "sim")
    {
        Console.WriteLine("Você encontra cristais mágicos que restauram sua energia.");
    }
    else
    {
        Console.WriteLine("Você ignora a luz e acaba em um beco sem saída.");
    }
}
else
{
    Console.WriteLine("Escolha inválida. A caverna permanece em silêncio.");
}





Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
string periciaAlta = Console.ReadLine();

Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
string conheceFeitico = Console.ReadLine();

Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
string temCristal = Console.ReadLine();

if ((periciaAlta == "sim" && conheceFeitico == "sim") || (conheceFeitico == "sim" && temCristal == "sim"))
{
    Console.WriteLine("Você consegue libertar o grifo da armadilha mágica!");
}
else
{
    Console.WriteLine("Você falha na tentativa e o grifo permanece preso.");
}