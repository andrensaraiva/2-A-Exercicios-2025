// See https://aka.ms/new-console-template for more information
Console.WriteLine("Forneça três ingredientes");
string Ingrediente1 = Console.ReadLine();
string Ingrediente2 = Console.ReadLine();
string Ingrediente3 = Console.ReadLine();
Console.WriteLine("Forneça um nome para poção");
string Nome = Console.ReadLine();
Console.WriteLine("Receita da Poção: " + Nome);
Console.WriteLine("1.Adicione " + Ingrediente1);
Console.WriteLine("2.Misture com " + Ingrediente2);
Console.WriteLine("3.Finalize com uma pitada de " + Ingrediente3);
Console.WriteLine("Sua poção " + Nome + " está pronta!");