string[] resposta = new string[3];
int escolha;

resposta[0] = "Falar com Ferreiro";
resposta[1] = "Comprar Pão";
resposta[2] = "Investigar Poço";

Console.WriteLine("Você tem tarefas a fazer escolha uma: [1]Falar com Ferreiro, [2] Comprar Pão, [3]Investigar Poço");
escolha = int.Parse(Console.ReadLine());
switch (escolha)
{
    case 1:
        resposta[0] = "";
     break;
    case 2:
        resposta[1] = "";
        break;
    case 3:
        resposta[2] = "";
        break;
}
Console.WriteLine(" Suas Tarefas pendentes são:" +  resposta[0] + "," + resposta[1] + "," + resposta[2] + ".");