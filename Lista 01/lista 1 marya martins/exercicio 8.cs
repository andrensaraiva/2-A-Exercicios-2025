// See https://aka.ms/new-console-template for more information

string ingre1 = ("");
Console.WriteLine("me de um ingrediente");
ingre1 = Console.ReadLine();

string ingre2 = ("");
Console.WriteLine("agora me de um segundo ingrediente");
ingre2 = Console.ReadLine();

string ingre3 = ("");
Console.WriteLine("me de um 3 ingrediente para finalizar");
ingre3 = Console.ReadLine();

string nome = ("");
Console.WriteLine(" agora me fale o nome da poção");
nome = Console.ReadLine();

Console.WriteLine("--- Receita da Poção:" + nome + " --- ");
Console.WriteLine("Adicione " + ingre1 );
Console.WriteLine("Misture com " + ingre2);
Console.WriteLine("Finalize com uma pitada de " + ingre3);
Console.WriteLine("Sua poção " + nome + " está pronta!");


