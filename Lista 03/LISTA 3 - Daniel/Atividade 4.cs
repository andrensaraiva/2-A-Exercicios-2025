// 4. O Nível do Desafio

int n;

Console.WriteLine(" Elara encontra a entrada da Caverna dos Sussurros, com uma placa: Apenas nível 5 ou mais.");

Console.WriteLine("Qual é o seu nível atual?(entrada numérica)");
n = int.Parse(Console.ReadLine());


if (n >= 5)
{

    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}

else

{
    Console.WriteLine("Volte quando estiver mais forte, Elara.");

}


