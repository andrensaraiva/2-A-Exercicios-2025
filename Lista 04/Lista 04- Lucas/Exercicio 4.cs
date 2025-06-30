string F, AG, IN;

Console.WriteLine("Você abre um baú misterioso e encontra um Elmo, uma Armadura, e uma Arma.");
Console.WriteLine("Você deseja equipar o Elmo?");
IN = Console.ReadLine();
Console.WriteLine("Você deseja equipar a Arma?");
F = Console.ReadLine();
Console.WriteLine("Você deseja equipar a Armadura?");
AG = Console.ReadLine();

if (IN == "sim" & F == "sim" & AG == "sim")
{
    Console.WriteLine("Ao equipar todos os itens seu bônus de atributo agora é de 120");
}
else if (IN == "não" & F == "não" & AG == "não")
{
    Console.WriteLine("Seu bonus não aumentou em nada");
}
else
{
    Console.WriteLine("Seu bonus que antes era de 20, agora é de 50");
}