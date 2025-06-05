String Verbo = "Verbo de ação";
String Substântivo = "Substântivo Epíco";
String Inimigo = "Inimigo Principal";

Console.WriteLine("Me diga um verbo de ação para seu grito de guerra!");
Verbo = Console.ReadLine();

Console.WriteLine("Um substântivo epíco!");
Substântivo = Console.ReadLine();

Console.WriteLine("Qual inimigo vai derrotar?");
Inimigo = Console.ReadLine();

Console.WriteLine("Pela " + Substântivo + "! Vamos " + Verbo + " e derrotar " + Inimigo + "!");
