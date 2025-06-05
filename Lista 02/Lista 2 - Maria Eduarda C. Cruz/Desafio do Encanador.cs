// Desafio do Encanador

float cdocano = 0.0f;
float distanciacobrir = 0.0f;
float canosinteiros = 0.0f;
float resto = 0.0f;
cdocano = float.Parse(Console.ReadLine());
distanciacobrir = float.Parse(Console.ReadLine());
canosinteiros = distanciacobrir / cdocano;
resto = cdocano % distanciacobrir;
Console.WriteLine(canosinteiros);
Console.WriteLine(resto);
