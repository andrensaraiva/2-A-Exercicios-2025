int chaveNumerica1 = 2;
int chaveNumerica2 = 7;
int chaveNumerica3 = 8;
string mensagem1 = "T";
string mensagem2 = "H";
string mensagem3 = "P";
string Código = "C";
string Código2 = "c";
string Código3 = "CC";
string Codificado = "ISSO"; 

Console.WriteLine("Digite uma chave numérica de três números. Qual o primeiro número?");

chaveNumerica1 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o segundo número:");

chaveNumerica2 = int.Parse(Console.ReadLine());

Console.WriteLine("E o terceiro número?");

chaveNumerica3 = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite três mensagens de uma letra. Qual a primeira letra?");

mensagem1 = Console.ReadLine();

Console.WriteLine("Qual a segunda letra?");

mensagem2 = Console.ReadLine();

Console.WriteLine("E a terceira letra?");

mensagem3 = Console.ReadLine();



Código = chaveNumerica1 + mensagem1;
Código2 = chaveNumerica2 + mensagem2;
Código3 = chaveNumerica3 + mensagem3;

Codificado = Código + Código2 + Código3;

Console.WriteLine("O seu código é" + Codificado); 










