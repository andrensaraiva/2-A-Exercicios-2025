// 13.Calculadora de IMC

double peso, altura, imc;
Console.WriteLine("Peso (kg):");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Altura (m):");
altura = double.Parse(Console.ReadLine());
imc = peso / (altura * altura);
Console.WriteLine("IMC: " + imc);

// 14.Planejador de Viagem

double distancia, consumo, precoLitro, litros, custo;
Console.WriteLine("Distância (km):");
distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Consumo (km/l):");
consumo = double.Parse(Console.ReadLine());
Console.WriteLine("Preço do litro:");
precoLitro = double.Parse(Console.ReadLine());
litros = distancia / consumo;
custo = litros * precoLitro;
Console.WriteLine("Litros: " + litros);
Console.WriteLine("Custo: R$ " + custo);

// 15.Gerador de Status de Jogo

string nome;
int forca, agilidade, inteligencia;
double hp, danoFisico, poderMagico;

Console.WriteLine("Nome do personagem:");
nome = Console.ReadLine();
Console.WriteLine("Força:");
forca = int.Parse(Console.ReadLine());
Console.WriteLine("Agilidade:");
agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Inteligência:");
inteligencia = int.Parse(Console.ReadLine());

hp = forca * 5;
danoFisico = forca + (agilidade / 2.0);
poderMagico = inteligencia * 3;

Console.WriteLine("Personagem: " + nome);
Console.WriteLine("HP: " + hp);
Console.WriteLine("Dano Físico: " + danoFisico);
Console.WriteLine("Poder Mágico: " + poderMagico);

// 16.Máquina de Doces Simulada

int qtdChoc, qtdBala, qtdChic;
double precoChoc = 2.5, precoBala = 1.0, precoChic = 0.5;
double total;

Console.WriteLine("Quantos chocolates?");
qtdChoc = int.Parse(Console.ReadLine());
Console.WriteLine("Quantas balas?");
qtdBala = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos chicletes?");
qtdChic = int.Parse(Console.ReadLine());

total = (qtdChoc * precoChoc) + (qtdBala * precoBala) + (qtdChic * precoChic);
Console.WriteLine("Total da compra: R$ " + total);

// 17.Simulador de Investimento

double capital, taxa, montante;
int tempo;

Console.WriteLine("Capital inicial:");
capital = double.Parse(Console.ReadLine());
Console.WriteLine("Taxa de juros anual (%):");
taxa = double.Parse(Console.ReadLine()) / 100;
Console.WriteLine("Tempo (anos):");
tempo = int.Parse(Console.ReadLine());

montante = capital + (capital * taxa * tempo);
Console.WriteLine("Montante: R$ " + montante);
Console.WriteLine("Juros ganhos: R$ " + (montante - capital));

// 18.Desafio do Encanador

double comprimento, usado;
int canos;

Console.WriteLine("Comprimento do cano (m):");
comprimento = double.Parse(Console.ReadLine());
Console.WriteLine("Distância a cobrir (m):");
distancia = double.Parse(Console.ReadLine());

canos = (int)(distancia / comprimento);
usado = distancia % comprimento;

if (usado > 0) canos++;

Console.WriteLine("Canos necessários: " + canos);
Console.WriteLine("Último cano será usado em: " + (usado > 0 ? usado : comprimento) + "m");

// 19.Decodificador de Mensagem Secreta

int chave, c1, c2, c3;
char l1, l2, l3;

Console.WriteLine("Digite a chave:");
chave = int.Parse(Console.ReadLine());
Console.WriteLine("Letra 1:");
l1 = char.Parse(Console.ReadLine().ToUpper());
Console.WriteLine("Letra 2:");
l2 = char.Parse(Console.ReadLine().ToUpper());
Console.WriteLine("Letra 3:");
l3 = char.Parse(Console.ReadLine().ToUpper());

c1 = (l1 - 'A' + 1) + chave;
c2 = (l2 - 'A' + 1) + chave;
c3 = (l3 - 'A' + 1) + chave;

Console.WriteLine("Códigos: " + c1 + ", " + c2 + ", " + c3);

// 20.Construtor de Avatar

int final = 20, potencia, habilidade, raciocinio;

Console.WriteLine("Pontos em força:");
forca = int.Parse(Console.ReadLine());
total = forca;

Console.WriteLine("Pontos em agilidade (restam " + total + "):");
agilidade = int.Parse(Console.ReadLine());
total = agilidade;

Console.WriteLine("Pontos em inteligência (restam " + total + "):");
inteligencia = int.Parse(Console.ReadLine());
total = inteligencia;

Console.WriteLine("Distribuição:");
Console.WriteLine("Força: " + forca);
Console.WriteLine("Agilidade: " + agilidade);
Console.WriteLine("Inteligência: " + inteligencia);
Console.WriteLine("Pontos restantes: " + total);