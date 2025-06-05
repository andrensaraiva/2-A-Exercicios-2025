string cebolaCaramelizada = "Batata Doce";

string cenouraRalada = "nao sei oq";

string jogosDigitais = "blablabla";

string sesi = "sesi";

Console.WriteLine("Qual será o primeiro ingrediente?");
cebolaCaramelizada = Console.ReadLine();

Console.WriteLine("Qual será o segundo ingrediente?");
cenouraRalada = Console.ReadLine();

Console.WriteLine("Qual será o terceiro ingrediente?");
jogosDigitais = Console.ReadLine();

Console.WriteLine("Qual será o nome da poção?");
sesi = Console.ReadLine();

Console.WriteLine("Receita da Poção: " + sesi);
Console.WriteLine("1. Adicione " + cebolaCaramelizada);
Console.WriteLine("2. Misture com " + cenouraRalada);
Console.WriteLine("3. Finalize com uma pitada de " + jogosDigitais);
Console.WriteLine("Sua poção " + sesi + " está pronta!");

