string ingredientes = "a";
string pocao = "p";
string ingredientes2 = "b";
string ingrediente3 = "q";

Console.WriteLine("escolha 1 ingrediente base");
ingredientes = Console.ReadLine();

Console.WriteLine("escolha 1 ingrediente para misturar com o primeiro");
ingredientes2 = Console.ReadLine();

Console.WriteLine("escolha 1 ingrediente para por no final");
ingrediente3 = Console.ReadLine();

Console.WriteLine("qual o nome dessa poção que quer fazer?");
pocao = Console.ReadLine();

Console.WriteLine("---- Receita poção: " + pocao + "----");
Console.WriteLine("1. adicione" + ingredientes);
Console.WriteLine("2. misture um pouco de " + ingredientes2);
Console.WriteLine("3. finalize com uma pitada de " + ingrediente3);
Console.WriteLine("Sua poção " + pocao + " está pronta!!");




