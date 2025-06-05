// Simulador de Investimento (Juros Simples)

float capitalI = 0.0f;
float jurosA = 0.0f;
float anos = 0.0f;
float jurosAtotal = 0.0f;
float montante = 0.0f; 
capitalI = float.Parse(Console.ReadLine());
jurosA = float.Parse(Console.ReadLine());
anos = float.Parse(Console.ReadLine());
montante = capitalI + (capitalI * jurosA * anos);
jurosAtotal = jurosA * anos;
Console.WriteLine("O montante final e " + montante + " e o total de juros ganhos e " + jurosAtotal);
