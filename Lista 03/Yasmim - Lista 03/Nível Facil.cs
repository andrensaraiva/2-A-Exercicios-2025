// 1. A Poção Misteriosa

string resposta;
Console.WriteLine("Elara, você quer beber a poção? (sim/nao)")
resposta = Console.ReadLine();
if (resposta = "sim");
{
    Console.WriteLine("Você bebe a poção! Um calor percorre seu corpo. (HP +10)"); 
}

else (resposta = "não") ;
{
    Console.WriteLine("Você guarda a poção para depois. Quem sabe o que ela faz?");
}

// 2. O Baú Trancado

string resposta;
Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)")
resposta = Console.ReadLine();
if (resposta = "sim") ;
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}

else (resposta = "não");
{
    Console.WriteLine("O baú está trancado.Você precisa da chave certa.");
}

// 3. A Ponte Frágil

string resposta;
Console.WriteLine("A ponte parece instável. Você quer atravessar? (sim/nao)")
resposta = Console.ReadLine();
if (resposta = "sim") ;
{
    Console.WriteLine("Você atravessa com cuidado e chega em segurança.");
}

else (resposta = "não");
{
    Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!");
}

// 4. O Nível do Desafio

string numero;
Console.WriteLine("Qual é o seu nível atual?")
numero = int. Parse(Console.ReadLine());
if (numero >= 5) ;
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}

else (resposta <= 5);
{
    //Console.WriteLine("Volte quando estiver mais forte, Elara.");
}