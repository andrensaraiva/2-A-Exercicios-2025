string nome = "Thiago";
string At1 = "força";
string At2 = "agilidade";
string At3 = "inteligência";
int valorForça = 100;
int ValorAgilidade = 50;
int ValorInteligência = 70;
float HPBase = 110;
float DanoFísico = 200;
float PoderMágico = 500;

Console.WriteLine("Qual é o seu nome, jogador?");

nome = Console.ReadLine();

Console.WriteLine(" Bem vindo," + nome + "!" + "Qual é o seu primeiro atributo?");

At1 = Console.ReadLine();

Console.WriteLine("Qual é o seu segundo atributo?");

At2 = Console.ReadLine();


Console.WriteLine("E o terceiro?");

At3 = Console.ReadLine();

Console.WriteLine("Diga o valor do(a)" + At1);

valorForça = int.Parse(Console.ReadLine());

Console.WriteLine(" Agora, diga o valor do(a)" + At2);

ValorAgilidade = int.Parse(Console.ReadLine());

Console.WriteLine(" E o valor do(a)" + At3 + "?");

ValorInteligência = int.Parse(Console.ReadLine());

HPBase = valorForça * 5;
DanoFísico = valorForça + (ValorAgilidade / 2);
PoderMágico = ValorInteligência * 3;

Console.WriteLine("Resultados:");
Console.WriteLine(" O valor de" + At1 + "=" + valorForça);
Console.WriteLine(" valor de" + At2 + "=" + ValorAgilidade);
Console.WriteLine(" valor de" + At3 + "=" + ValorInteligência);
Console.WriteLine(" O seu HPBase =" + HPBase);
Console.WriteLine(" O seu dano físico =" + DanoFísico);
Console.WriteLine(" O seu Poder mágico =" + PoderMágico);








