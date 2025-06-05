string ingred1 = "";
String ingred2 = "";
string ingred3 = "";
string nome = "";
Console.WriteLine("para ajudar na sua jornada, vou preparar uma poção para você... pode escolher três ingredientes, por conta da casa! qual vai ser o primeiro?");
ingred1 = Console.ReadLine();
Console.WriteLine("eu também escolheria esse... qual o segundo ingrediente?");
ingred2 = Console.ReadLine();
Console.WriteLine("ok, qual vai ser o ultimo?");
ingred3 = Console.ReadLine();
Console.WriteLine("qual será o nome dessa poção?");
nome = Console.ReadLine();

Console.WriteLine("vamos fazer uma poção " + nome + "...");
Console.WriteLine("para a sua poção, eu usei " + ingred1 + "...");
Console.WriteLine("um pouco de " + ingred2 + "...");
Console.WriteLine("e para finalizar, uma pitada de " + ingred3 + "...");
Console.WriteLine("pronto! a sua poção " + nome + " está pronta...");
