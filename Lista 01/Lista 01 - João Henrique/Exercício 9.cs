string a = "b";
string c = "d";
string e = "f";
string g = "h";

Console.WriteLine("Escolha um nome para a poção");
c = Console.ReadLine();
Console.WriteLine("Escolha o primeiro ingrediente");
a = Console.ReadLine();
Console.WriteLine("O segundo ingrediente");
e = Console.ReadLine();

Console.WriteLine("Só mais um por favor!");
g = Console.ReadLine();

Console.WriteLine("Receita da Poção: " + c);
Console.WriteLine("1. Adicione: " + a);
Console.WriteLine("2. Misture com: " + e);
Console.WriteLine("3. Finalize com uma pitada de: " + g);
Console.WriteLine("Sua Poção " + c + " está pronta!");