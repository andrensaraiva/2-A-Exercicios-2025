string caminho1 = "ok";
string decisão= "ok";
string barganha = "ok";
int ouro = 0;

Console.WriteLine("Você esta perdido em uma caverna, para escapar você precisa decidir entre dois caminhos, o caminho da esquerda é escuro e sombrio, já o caminho da direita é brilhoso e parece inofencivo");
Console.WriteLine("Por qual caminho deseja seguir? (Esquerda/Direita)");
caminho1 = Console.ReadLine();

if (caminho1 == "Esquerda" || caminho1 == "esquerda")
{
    Console.WriteLine("Você segue o caminho da esquerda e se depara com mostros super raros");
    Console.WriteLine("Você quer lutar com eles ou prefere fugir para a saida? (Lutar/Fugir)");
    decisão = Console.ReadLine();
    if (decisão == "Lutar" || decisão == "lutar")
    {
        Console.WriteLine("Você derrota todos os montros raros, mas acaba se machucando um pouco e escapa da caverna (+500 gold e -20 hp)");
    }
    else if (decisão == "Fugir" || decisão == "fugir")
    {
        Console.WriteLine("Você consegue escapar da caverna com segurança");
    }
}

else if (caminho1 == "Direita" || caminho1 == "direita")
{
    Console.WriteLine("Você segue o caminho da direita e se depara com um dragão gigante");
    Console.WriteLine("Você deseja lutar com o dragão ou barganhar com ele para fugir da caverna (Lutar/Barganhar)");
    barganha = Console.ReadLine();
    if (barganha == "Lutar" || barganha == "lutar")
    {
        Console.WriteLine("Você não consegue derrotar o dragão, mas ele tem piedade e te deixa sair (-80 hp)");
    }

    else if (barganha == "Barganhar" || barganha == "barganhar")
    {
        Console.WriteLine("Quanto ouro você tem?");
        ouro = int.Parse(Console.ReadLine());
        if (ouro >= 70)
        {
            Console.WriteLine("o Dragão te deixar passar");
        }
        else if (ouro < 70)
        {
            Console.WriteLine("Você não possui ouro o suficiente, então o dragão te mata" + " GAME OVER");
        }

    }
}

