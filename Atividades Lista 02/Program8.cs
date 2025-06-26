int forçaH = 100;
int defesaI = 75;
int resultado = 25;

Console.WriteLine("Vamos atacar o inimigo?");
Console.WriteLine("Escolha uma força de ataque");

forçaH = int.Parse(Console.ReadLine());

Console.WriteLine("O inimigo defende! Qual o nível da defesa dele?");

defesaI = int.Parse(Console.ReadLine());

resultado = forçaH - defesaI;

Console.WriteLine("O resultado do seu estrago foi" + resultado); 
