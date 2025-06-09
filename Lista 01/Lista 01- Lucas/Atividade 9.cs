string pocao = "nome da poção";
string in1 = "1";
string in2 = "2";
string in3 = "3";

Console.WriteLine("Qual o nome da sua pocao?:");
pocao = Console.ReadLine();

Console.WriteLine("Primeiro adicione um ingrediente:");
in1 = Console.ReadLine();

Console.WriteLine("Misture com:");
in2 = Console.ReadLine();

Console.WriteLine("Finalize com uma pitada de:");
in3 = Console.ReadLine();

Console.WriteLine("Sua poção de " + pocao + " está pronta!");