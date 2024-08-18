using jokenpo;
using jokenpo.Models;


JokenpoValidator.PopulatePossiblyChoices();

topConsole:;

Console.WriteLine("---------- Jokenpo - Pedra , Papel ,Tesoura ,Lagarto e Spock ------------------");

var player1 = new Player("Úsuario");

Console.WriteLine();

Console.WriteLine("Faça sua escolha : ");

foreach (Choice choices in JokenpoValidator.PossiblyChoices)
{
    Console.WriteLine($"* {choices.ChoiceName}");
}

Console.WriteLine("Digite sua escolha : ");

try
{
    player1.SetChoice(Console.ReadLine());
}
catch (Exception e)
{
    Console.Clear();

    Console.WriteLine(e.Message);

    goto topConsole;
}

Console.WriteLine(player1.ToString());

var player2 = new Player("Computador");

player2.SetRadomChoicePlayerComputer();

Console.WriteLine(player2.ToString());

var winner = JokenpoValidator.ValidateWinner(player1, player2);

if (winner != null)
{
    Console.WriteLine($"\n {winner.Name} Ganhou !");
}
else
{
    Console.WriteLine("\n Empate ! Ninguem ganhou !");
}

Console.WriteLine("\n Jogar novamente ? S/N");

responseConsole:

string responseConsole = "";

try
{
    responseConsole = Console.ReadLine();

}
catch (Exception e)
{
    Console.WriteLine("Escolha invalida  ! Somente : S - Sim | N - Não");
    goto responseConsole;
}

if (responseConsole.Trim().ToLower() == "s")
{
    Console.Clear();

    goto topConsole;
}
else
{
    Environment.Exit(-1);
}





