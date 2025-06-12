int nivel = 1;

Console.WriteLine("você encontrar a caverna maneira, só que é só pra quem é nivel 10 ou +");
Console.WriteLine("but, qual o seu nivel?");
nivel = int.Parse(Console.ReadLine());

if (nivel >= 10)
{
    Console.WriteLine("boa mano tu é no minimo nivel 10, quer um parabens? a pode entrar na caverna");
}
else {
    Console.WriteLine("tu nao é nem nivel 10 but? XD sai daqui seu bucha");
}
