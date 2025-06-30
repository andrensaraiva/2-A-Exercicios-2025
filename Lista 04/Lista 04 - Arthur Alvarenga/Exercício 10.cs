
int a;
Console.WriteLine("Você esta andando, e em certa hora da noite estrelas começam a cair sobre a sua cabeça.");
Console.WriteLine(" ");
Console.WriteLine("Você tem duas opções: Se defender e esperar a chuva passar ou fugir da chuva e continuar seu caminho. (1 ou 2)");
a = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
if (a == 1)
{
    Console.WriteLine("Você aguarda até o fim da chuva de estrela, porém ao final dela você vê algo brilhando, quando vai averiguar recebe um cristal das estrelas!");
}
else if (a == 2)
{
    Console.WriteLine("Você consegue fugir da chuva de estrelas ileso, e consegue seguir seu caminho");
}