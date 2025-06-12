
 //---------------(Simples if)--------------------------------------------------------------------------------------
// Simula o HP atual do jogador
int hpJogador = 0; // Tente mudar este valor para 50, 0, -10

Console.WriteLine($"HP Atual do Jogador: {hpJogador}");

// --- Início da Lógica Condicional ---
 // Verifica se o HP do jogador é menor ou igual a zero.
// Se esta condição for VERDADEIRA, o código dentro das chaves {} será executado.
if (hpJogador <= 0)
{
    // Bloco de código do IF: Executado apenas se hpJogador <= 0
    Console.WriteLine("--------------------------");
    Console.WriteLine("       GAME OVER!         ");
    Console.WriteLine("Você foi derrotado, nobre herói.");
    Console.WriteLine("Mais sorte na próxima vez!");
    Console.WriteLine("--------------------------");
}
// --- Fim da Lógica Condicional ---

// Esta linha executa SEMPRE, independentemente do resultado do if.
Console.WriteLine("A aventura continua... ou recomeça!");

//-------------------(if-else)----------------------------------------------------------------------------------

// Simula se o jogador possui a chave necessária
bool jogadorPossuiChaveAzul = false; // Tente mudar para true

Console.WriteLine("Você se aproxima de uma porta azul misteriosa.");

// --- Início da Lógica Condicional ---
// Verifica se o jogador possui a Chave Azul.
// (jogadorPossuiChaveAzul == true) é o mesmo que (jogadorPossuiChaveAzul) para booleanos.
if (jogadorPossuiChaveAzul)
{
    // Bloco de código do IF: Executado se jogadorPossuiChaveAzul for VERDADEIRO.
    Console.WriteLine("Você usa a Chave Azul na fechadura.");
    Console.WriteLine("A porta se abre com um rangido, revelando um corredor iluminado!");
    Console.WriteLine("Você pode prosseguir!");
}
else // SENÃO (ou seja, se a condição do if for FALSA)
{
     // Bloco de código do ELSE: Executado se jogadorPossuiChaveAzul for FALSO.
    Console.WriteLine("A porta está trancada firmemente.");
    Console.WriteLine("Uma inscrição diz: 'Apenas a Chave Azul pode abrir este caminho.'");
    Console.WriteLine("Você precisa encontrar a chave!");
}
// --- Fim da Lógica Condicional ---

Console.WriteLine("Você decide o que fazer a seguir.");

//------------------ (if-else if-else)-----------------------------------------------------------------------------------

 // Simula a pontuação do jogador
Console.Write("Digite a pontuação do jogador: ");
int pontuacao = int.Parse(Console.ReadLine()); // Lê a pontuação do usuário

string classificacao; // Variável para guardar a classificação

// --- Início da Lógica Condicional Encadeada ---
// Verifica a primeira condição: pontuação é 10000 ou mais?
if (pontuacao >= 10000)
{
    // Bloco do primeiro IF: Executado se pontuacao >= 10000
    classificacao = "Lenda Suprema do Reino!";
}
        // SENÃO SE (a primeira condição foi FALSA), verifica esta segunda condição:
else if (pontuacao >= 5000)
{
    // Bloco do ELSE IF: Executado se pontuacao >= 5000 E pontuacao < 10000
    classificacao = "Herói Veterano Condecorado!";
}
// SENÃO SE (as duas primeiras condições foram FALSAS), verifica esta terceira condição:
else if (pontuacao >= 1000)
{
    // Bloco do ELSE IF: Executado se pontuacao >= 1000 E pontuacao < 5000
    classificacao = "Aventureiro Promissor!";
}
// SENÃO (se NENHUMA das condições anteriores foi VERDADEIRA)
else
{
    // Bloco do ELSE final: Executado se pontuacao < 1000
    classificacao = "Recruta Corajoso, continue treinando!";
}
// --- Fim da Lógica Condicional Encadeada ---

Console.WriteLine($"Com {pontuacao} pontos, sua classificação é: {classificacao}");

//------------------(Operador Lógico && - E)-----------------------------------------------------------------------------------

// Simula os recursos do jogador
int manaAtual = 60;        // Tente mudar para 40
bool barraEspecialCheia = true; // Tente mudar para false

Console.WriteLine($"Mana: {manaAtual} | Barra de Especial Cheia: {barraEspecialCheia}");

// --- Início da Lógica Condicional com Operador E ---
// Verifica se o jogador tem mana suficiente E se a barra de especial está cheia.
// AMBAS as condições precisam ser VERDADEIRAS para o bloco if executar.
if (manaAtual >= 50 && barraEspecialCheia)
{
    // Bloco IF: Executado se manaAtual >= 50 E barraEspecialCheia for true
    Console.WriteLine("CONDICAO ATENDIDA! Você reúne suas forças...");
    Console.WriteLine("ATAQUE ESPECIAL: 'FÚRIA DO DRAGÃO' LANÇADO!!! DANO MASSIVO!");
    manaAtual -= 50; // Simula o gasto de mana
    barraEspecialCheia = false; // Simula o uso da barra
}
else // SENÃO (se pelo menos uma das condições do if for FALSA)
{
    // Bloco ELSE: Executado se a condição do if for falsa
    Console.WriteLine("Você tenta usar a habilidade especial, mas algo está faltando...");
    if (manaAtual < 50)
    {
        Console.WriteLine("- Mana insuficiente! Você precisa de pelo menos 50 de mana.");
    }
    if (!barraEspecialCheia) // Usando o operador NÃO (!)
    {
        Console.WriteLine("- Sua barra de especial ainda não está carregada!");
    }
}
// --- Fim da Lógica Condicional ---

Console.WriteLine($"Status pós-tentativa: Mana: {manaAtual} | Barra de Especial Cheia: {barraEspecialCheia}");

//----------------------- (Operador Lógico || - OU)------------------------------------------------------------------------------

 // Simula as condições para abrir a passagem
bool possuiChaveAntiga = false;   // Tente mudar para true
bool conhecePalavraSecreta = true; // Tente mudar para false

Console.WriteLine($"Possui Chave Antiga: {possuiChaveAntiga} | Conhece Palavra Secreta: {conhecePalavraSecreta}");

// --- Início da Lógica Condicional com Operador OU ---
// Verifica se o jogador possui a chave OU se conhece a palavra secreta.
// PELO MENOS UMA das condições precisa ser VERDADEIRA para o bloco if executar.
if (possuiChaveAntiga || conhecePalavraSecreta)
{
    // Bloco IF: Executado se possuiChaveAntiga for true OU conhecePalavraSecreta for true (ou ambos)
    Console.WriteLine("Um mecanismo antigo é ativado!");
    Console.WriteLine("Uma passagem secreta na parede se abre rangendo!");
}
else // SENÃO (se AMBAS as condições do if forem FALSAS)
{
    // Bloco ELSE: Executado se a condição do if for falsa
    Console.WriteLine("Você examina a parede, mas não encontra nada fora do comum.");
    Console.WriteLine("Parece que falta algo para revelar seus segredos...");
}
// --- Fim da Lógica Condicional ---
