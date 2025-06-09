float kg;
float altura;

Console.WriteLine("Me diga seu peso (em quilos) e sua altura (em metros)");
kg = float.Parse(Console.ReadLine());
altura = float.Parse(Console.ReadLine());

Console.WriteLine("Seu IMC é " + (kg / altura * altura));
