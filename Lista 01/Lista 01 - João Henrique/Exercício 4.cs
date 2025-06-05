using System.Runtime.ConstrainedExecution;

string a = "b";
string c = "d";
Console.WriteLine("qual sua cor favorita?");
a = Console.ReadLine();

Console.WriteLine("qual seu animal favorito?");
c = Console.ReadLine();

Console.WriteLine("Seu apelido de aventureiro poderia ser: O(A) " + c + a);
    