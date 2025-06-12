int cav = 8;
string ca1 = "rere";
string ca2 = "dfsxda";

Console.WriteLine("você entra em uma caverna com dois tuneis");
Console.WriteLine("você quer entrar em qual? 1=tunel umido/ 2=tunel brilhante");
cav = int.Parse(Console.ReadLine());

if (cav == 1)
{
    Console.WriteLine("você escolha um barulho alto de agua caindo, você olha oque é ou nao?");
    ca1 = Console.ReadLine();
    if (ca1 == "sim")
    {
        Console.WriteLine("você encontra uma terrivel correnteza e acaba sendo puzado para ela e morre");
    }
    else
    {
        Console.WriteLine("você sai da caverna com vida!");
    }
}
else if (cav == 2) {
    Console.WriteLine("a caverna é muito brilhante, você trouxe o seu oculos de sol para se proteger?(sim/nao)");
    ca2 = Console.ReadLine();
    if (ca2 == "sim")
    {
        Console.WriteLine("você colocou o seu oculos de sol! por pouco voce nao fica cego");

    }
    else {
        Console.WriteLine("você acaba ficando cego de tanto brilho");
    }
}