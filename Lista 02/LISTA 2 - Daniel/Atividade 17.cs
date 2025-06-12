// 17. Simulador de Investimento (Juros Simples)

float ci;
float tja;
float t;
float j;
float m;

Console.WriteLine("Simulador de Juros (Anual)");

Console.WriteLine(" ");

Console.WriteLine("Me diga o Capital Inicial, a taxa de juros anual e o tempo: ");
ci = float.Parse(Console.ReadLine());
tja = float.Parse(Console.ReadLine());
t = float.Parse(Console.ReadLine());

j = ci * (tja / 100) * t;
m = ci + j;

Console.WriteLine("Montante final: " + m);
Console.WriteLine("Total de Juros ganho: " + j);

