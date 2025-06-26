using System.Runtime.ConstrainedExecution;

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
string resp = Console.ReadLine();





if (resp == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}
else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
}



Console.WriteLine("A ponte parece instável. Você quer atravessar?(sim / nao)");
string respo = Console.ReadLine();




if (respo == "sim")
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
}
else
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
}









Console.WriteLine("Qual é o seu nível atual?");
string nivel = Console.ReadLine();
int nivel = int.Parse(Console.ReadLine());



if (nivel >= 5)
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}
else if (nivel <= 5)
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
string respostag = Console.ReadLine();


if (moedas < 10 && respostag == "nao")
{
    Console.WriteLine("Nada de promoção.");
}
else
{
    Console.WriteLine("promoção");
}







Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string respostae = Console.ReadLine();

Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string respostao = Console.ReadLine();

Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string respostap = Console.ReadLine();


if (respostae == "sim" && respostao == "sim" || respostap == "sim")
{
    Console.WriteLine("portao estabiliza");
}
else
{
    Console.WriteLine("Portao nao disponivel");
}




Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
string gema = Console.ReadLine();

if (gema == "sim" || )
{
    Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
}

else
{
    Console.WriteLine("O goblin não está de bom humor hoje, volte outra hora.");
}





Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
string tunel1 = Console.ReadLine();

if (tunel1 == "esquerda" || )
{
    Console.WriteLine("Você entrou no túnel da esquerda, úmido e escuro.");
}

else
{
    Console.WriteLine("Você entrou no túnel da direita, com brilho e aparentemente aconchegante.");
}





int per = 5;

string fei = "sdasd";

string cris = "sfhji";

Console.WriteLine("um grifo esta preso em uma armadilha");

Console.WriteLine("qual o seu nivel de pericia de armadilha?");

per = int.Parse(Console.ReadLine());

Console.WriteLine("voce conhece o feitiço de dissipação melhor?");

fei = Console.ReadLine();

Console.WriteLine("você possui o cirstal de amplificação?");

cris = Console.ReadLine();

if (per >= 7 && fei == "sim" || fei == "sim" && cris == "sim")

{

    Console.WriteLine("parabens voce libertou o grifo!");

}

else
{

    Console.WriteLine("voce nao conseguiu liberar o grifo");

}
