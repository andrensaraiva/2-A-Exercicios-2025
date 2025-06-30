
int acertos = 0;
string resposta1;
string resposta2;
string resposta3;

Console.WriteLine("O que é, o que é? Feito para andar e não anda.");
resposta1 = Console.ReadLine();
if 
    (resposta1 == "rua")
    {acertos++;}

    Console.WriteLine("O que é, o que é? Dá muitas voltas e não sai do lugar.");
resposta2 = Console.ReadLine();
if
    (resposta2 == "relógio")
    { acertos++; }

Console.WriteLine("O que é, o que é? Tem cabeça e tem dente, não é bicho e nem é gente.");
resposta3 = Console.ReadLine();
if
    (resposta3 == "alho")
    { acertos++; }


if (acertos == 3)
{Console.WriteLine("Parabéns, você acertou 3 enigmas e a armadilha foi completamente desativada"); }
else if (acertos == 2)
{Console.WriteLine("Foi quase, você acertou 2 enigmas e a armadilha foi parcialmente desativada"); }
else if (acertos == 1)
{Console.WriteLine("Não foi dessa vez, você acertou 1 enigma e a armadilha não foi desativada"); }
else if (acertos == 0)
{ Console.WriteLine("Não foi dessa vez, você acertou 0 enigmas e a armadilha não foi desativada"); }