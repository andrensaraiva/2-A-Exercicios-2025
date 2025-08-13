string nome, classe;
int nivel;

Console.WriteLine("Escolha um nome:");
nome = Console.ReadLine();
Console.WriteLine("Escolha uma classe:");
classe = Console.ReadLine();
Console.WriteLine("Qual seu nivel?");
nivel = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
string TituloCompleto = "Sir " + nome + ", o " + classe + " de nivel " +  nivel;
Console.WriteLine(TituloCompleto);