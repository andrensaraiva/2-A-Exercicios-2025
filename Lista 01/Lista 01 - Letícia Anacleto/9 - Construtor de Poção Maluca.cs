// See https://aka.ms/new-console-template for more information
Console.WriteLine("Diga três ingredientes (ex: Asa de Morcego, Pó de Fada, Lágrima de Unicórnio).");
string ingrediente1 = Console.ReadLine();
string ingrediente2 = Console.ReadLine();
string ingrediente3 = Console.ReadLine();

Console.WriteLine("Diga o nome da poção.");
string nome = Console.ReadLine();

Console.WriteLine("--- Receita da Poção: " + nome + " ---");
Console.WriteLine("1. Adicione " + ingrediente1);
Console.WriteLine("2. Misture com " + ingrediente2);
Console.WriteLine("3. Finalize com uma pitada de " + ingrediente3);
Console.WriteLine("Sua poção " + nome + " está pronta!");