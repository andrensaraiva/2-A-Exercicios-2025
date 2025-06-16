using System.ComponentModel.Design;

int resposta;

Console.WriteLine("Qual é o seu nível atual?");
resposta = int.Parse(Console.ReadLine());

{if (resposta >= 5)
    { Console.WriteLine("Você é forte o bastante! A caverna se abre.");}
    else { Console.WriteLine("Volte quando estiver mais forte, Elara.");}

}


