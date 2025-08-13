int DragaodeOuro;
float GemasdePrata;
Console.WriteLine("Conversor de Moedas Arcanas");
Console.WriteLine(" ");
Console.WriteLine("Quantos Dragoes de Ouro voce tem? (Cada um vale 15.5)");
DragaodeOuro = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
GemasdePrata = (DragaodeOuro * 15.5f);
Console.WriteLine("Voce tem: " + GemasdePrata + " Gemas de Prata.");
