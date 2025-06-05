int idade = 'a';

Console.WriteLine("Me diga sua idade, para calcular seus meses de vida:");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Seus meses de vida são: " + (idade * 12));