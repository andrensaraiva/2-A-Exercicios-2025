// 14. Planejador de Viagem – Consumo de Combustível


float d, valor, km_l;

Console.WriteLine("Para calcular os litros de gasolina necessários e o custo total da viajem, me informe a distância, custo médio e o preço da gasolina: ");
d = float.Parse(Console.ReadLine());
km_l = float.Parse(Console.ReadLine());
valor = float.Parse(Console.ReadLine());

Console.WriteLine("O litros de gasolina necessários para a viajem inteira serão: " + (d / km_l) + " Seu custo total será de: " + (d / km_l * valor));
