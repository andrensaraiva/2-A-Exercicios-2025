float montante = 0.0f;
float capital = 0.0f;
float taxaJuros = 10.5f;
float tempo = 0.0f;

Console.WriteLine("Vamos calcular seu investimento.");
Console.WriteLine("Qual o seu capital?");

capital = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é a taxa de juros anualmente? (coloque apenas o número da porcentagem");

taxaJuros = float.Parse(Console.ReadLine());

Console.WriteLine("E qual o tempo (em anos)? ");

tempo = float.Parse(Console.ReadLine());

taxaJuros = taxaJuros / 100;

montante = capital * taxaJuros * tempo;

Console.WriteLine(" O valor do seu montante é:" + montante);