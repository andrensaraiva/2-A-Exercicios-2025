float kg;
float at;

Console.WriteLine("Para medir seu IMC, Me diga seu peso e sua altura.");
kg = float.Parse(Console.ReadLine());
at = float.Parse(Console.ReadLine());

Console.WriteLine("Seu IMC é: " + (kg / at * at));
