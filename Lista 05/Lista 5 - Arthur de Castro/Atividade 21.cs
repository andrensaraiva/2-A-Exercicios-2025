string[] perguntas = new string[3];
string[] respostas = new string[4];
int pontos = 0;

perguntas[0] = "Capital do Brazil";
perguntas[1] = "Coletivo de Lobos";
perguntas[2] = "De onde é a invenção do chuveiro elétrico?";
respostas[0] = "Brasília";
respostas[1] = "Alcateia";
respostas[2] = "Brasil";

Console.WriteLine("Quiz");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Responda " + perguntas[i]);
    
    if (respostas[4] == respostas[i])
    {
        Console.WriteLine("Correto!");
        pontos++;
    }
    else
    {
        Console.WriteLine("Errado!");
    }
}
Console.WriteLine($"Você acertou " + pontos + "de 3 perguntas.");