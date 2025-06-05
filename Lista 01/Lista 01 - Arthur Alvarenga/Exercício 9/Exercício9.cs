String Ingrediente_1 = "1";
String Ingrediente_2 = "2";
String Ingrediente_3 = "3";
String Nome = "Nome da poção";

Console.WriteLine("Qual poção você deseja?");
Nome = Console.ReadLine();

Console.WriteLine("Escolha 3 ingredientes.");
Ingrediente_1 = Console.ReadLine();
Ingrediente_2 = Console.ReadLine();
Ingrediente_3 = Console.ReadLine();


Console.WriteLine("Receita da poção: " + Nome);

Console.WriteLine("Adicione: " + Ingrediente_1);
Console.WriteLine("Misture com: " + Ingrediente_2);
Console.WriteLine("Finalize com uma pitada de: " + Ingrediente_3);

Console.WriteLine("Sua poção '" + Nome + "' está pronta!");


