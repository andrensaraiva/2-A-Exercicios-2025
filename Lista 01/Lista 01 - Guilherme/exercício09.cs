string Ingrediente1 = "salvo";
Console.WriteLine("Escolha 1 ingrediente (ex: Asa de Morcego, Pó de Fada, Lágrima de Unicórnio).");
Ingrediente1 = Console.ReadLine();

string Ingrediente2 = "salvo";
Console.WriteLine("Escolha mais 1 ingrediente (ex: Asa de Morcego, Pó de Fada, Lágrima de Unicórnio).");
Ingrediente2 = Console.ReadLine();

string Ingrediente3 = "salvo";
Console.WriteLine("Escolha o último ingrediente (ex: Asa de Morcego, Pó de Fada, Lágrima de Unicórnio).");
Ingrediente1 = Console.ReadLine();

string Nome = "salvo";
Console.WriteLine("Escolha o nome da poção");
Nome = Console.ReadLine();

Console.WriteLine("--- Receita da Poção: " + Nome + "] ---");
Console.WriteLine("1. Adicione " + Ingrediente1);
Console.WriteLine("2. Misture com " + Ingrediente2);
Console.WriteLine("3. Finalize com uma pitada de " + Ingrediente3);
Console.WriteLine("Sua poção '" + Nome + "' está pronta!");
