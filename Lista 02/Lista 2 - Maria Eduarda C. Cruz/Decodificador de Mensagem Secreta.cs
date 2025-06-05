// Decodificador de Mensagem Secreta

int chave = 0;
string mensagem1 = "";
string mensagem2 = "";
string mensagem3 = "";
float m1 = 0.0f;
float m2 = 0.0f;
float m3 = 0.0f;
chave = int.Parse(Console.ReadLine());
mensagem1 = Console.ReadLine();
mensagem2 = Console.ReadLine();
mensagem3 = Console.ReadLine();
Console.WriteLine("Quanto vale cada letra?");
m1 = float.Parse(Console.ReadLine());
m2 = float.Parse(Console.ReadLine());
m3 = float.Parse(Console.ReadLine());
m1 += chave;
m2 += chave;
m3 += chave;
Console.WriteLine(m1);
Console.WriteLine(m2);
Console.WriteLine(m3);