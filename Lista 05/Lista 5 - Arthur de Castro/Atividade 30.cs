string[] acoes = { "Ir para norte", "Olhar", "Pegar", "Iventario" };
bool chave = false;
bool porta = false;
int escolha;
bool ver;
Console.WriteLine("Você aparece em uma sala oque você faz");
for (int i = 0; i < 4; i++)
{
    Console.WriteLine((i+1) +" - " + acoes);
    escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Você vai para o norte e acha uma porta fechada");
            if (chave = true)
            {
                Console.WriteLine("Você abriu a porta e sai da sala");
                porta = true;
                
            }
            else
            {
                Console.WriteLine("Precisa de uma chave");
            }
            break;
        case 2:
            Console.WriteLine("Você ve uma chave no chão");
            ver = true;
           break;
        case 3:
            if (ver = false)
            {
                Console.WriteLine("Você não ve nada para pegar");
            }
            else
            {
                Console.WriteLine("Você pega a chave no chão");
                chave = true;
            }
            break;
        case 4:
            if (chave = true)
            {
                Console.WriteLine("Você tem uma chave no inventario");
            }
            else
            {
                Console.WriteLine("Você não tem nada no inventario");
            }
            break;
    }
}
