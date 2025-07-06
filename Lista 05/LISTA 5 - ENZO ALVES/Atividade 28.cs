 Console.WriteLine("=== Batalha de Cartas ===");
int[] cartasJogador = new int[3];
int[] cartasOponente = new int[3];
int pontosJogador = 0;
int pontosOponente = 0;
int escolha;
cartasJogador[0] = 5;
cartasJogador[1] = 7;
cartasJogador[2] = 9;
cartasOponente[0] = 6;
cartasOponente[1] = 4;
cartasOponente[2] = 8;


for (int i = 0; i < 3; i++)
        {
Console.WriteLine("Suas cartas:" +cartasJogador[0] + ","+cartasJogador[1] + "," +cartasJogador[2]);
Console.Write("Escolha uma carta (1-3): ");
    escolha = int.Parse(Console.ReadLine());
Console.WriteLine("Você jogou "+ cartasJogador[escolha-1] + " Oponente jogou " + cartasOponente[i]);

            if (cartasJogador[escolha-1] > cartasOponente[i])
            {
                Console.WriteLine("Você ganhou o turno!");
                pontosJogador++;
            }
            else if (cartasJogador[escolha-1] < cartasOponente[1])
            {
                Console.WriteLine("O oponente ganhou o turno!");
                pontosOponente++;
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }

        if (pontosJogador > pontosOponente)
        {
            Console.WriteLine("Você venceu a partida!");
        }
        else if (pontosJogador < pontosOponente)
        {
            Console.WriteLine("Você perdeu a partida!");
        }
        else
        {
            Console.WriteLine("Empate geral!");
        }
    
