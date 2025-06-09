// See https://aka.ms/new-console-template for more information
string caminho = "oloko";
string bagulho = "aa";
string asas = "asas";
int gold = 0;

Console.WriteLine("Você esta perdido em uma caverna, para escapar você precisa decidir entre dois caminhos, o caminho da esquerda é escuro e sombrio já o caminho da direita é brilhoso e parece inofencivo");
Console.WriteLine("Por qual caminho deseja seguir? (Esquerda/Direita)");
caminho = Console.ReadLine();

if (caminho == "Esquerda" || caminho == "esquerda")
{
    Console.WriteLine("Você segue o caminho da esquerda e se depara com mostros super raros");
    Console.WriteLine("Você quer lutar com eles ou prefere fugir para a saida? (Lutar/Fugir)");
    bagulho = Console.ReadLine();
    if (bagulho == "Lutar" || bagulho == "lutar")
    {
        Console.WriteLine("Você derrota todos os montros raros, mas acaba se machucando um pouco e escapa da caverna (+500 gold e -20 hp)");
    }
    else if (bagulho == "Fugir" || bagulho == "fugir")
    {
        Console.WriteLine("Você consegue escapar da caverna com segurança");
    }
}

else if (caminho == "Direita" || caminho == "direita")
{
    Console.WriteLine("Você segue o caminho da direita e se depara com um dragão gigante e inteligente");
    Console.WriteLine("Você deseja lutar com o dragão ou barganhar com ele para fugir da caverna (Lutar/Barganhar)");
    asas = Console.ReadLine();
    if (asas == "Lutar" || asas == "lutar")
    {
        Console.WriteLine("Você não consegue derrotar o dragão, mas ele tem piedade e te deixa sair (-80 hp)");
    }

    else if (asas == "Barganhar" || asas == "barganhar")
    {
        Console.WriteLine("Quanto Gold você tem?");
        gold = int.Parse(Console.ReadLine());
        if (gold >= 70)
        {
            Console.WriteLine("o Dragão te deixar passar");
        }
        else if (gold < 70)
        {
            Console.WriteLine("Você não possui gold o suficiente então o dragão te mata");
        }
        
        }
    }
