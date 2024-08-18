using jokenpo.Models;

namespace jokenpo
{
    public static class JokenpoValidator
    {
        public static List<Choice> PossiblyChoices = new List<Choice>();

        public static Player? ValidateWinner(Player player1, Player player2)
        {
            Player winner;

            if (player1.Choice.Trim().ToLower() == player2.Choice.Trim().ToLower())
            {
                return null;
            }
            else
            {
                var verifyChoice = PossiblyChoices.Where(r => r.ChoiceName.ToLower() == player1.Choice.ToLower()).First();

                var validationWin = verifyChoice.WinsFor.Where(r => r.ToLower() == player2.Choice.ToLower()).FirstOrDefault();

                if (validationWin == null)
                {
                    return player2;
                }
                else
                {
                    return player1;
                }
            }
        }

        public static void PopulatePossiblyChoices()
        {
            Choice pedra = new Choice("Pedra", new List<string>() { "Tesoura" , "Lagarto" }, new List<string>() { "Papel" , "Spock" });

            Choice Papel = new Choice("Papel", new List<string>() { "Pedra", "Spock" }, new List<string>() { "Tesoura" , "Lagarto" });

            Choice Tesoura = new Choice("Tesoura", new List<string>() { "Papel", "Lagarto" }, new List<string>() { "Pedra", "Spock" });

            Choice Spock = new Choice("Spock", new List<string>() { "Tesoura", "Pedra" }, new List<string>() { "Papel", "Lagarto" });

            Choice Lagarto = new Choice("Lagarto", new List<string>() { "Papel", "Spock" }, new List<string>() { "Pedra", "Tesoura" });


            PossiblyChoices.Add(pedra);
            PossiblyChoices.Add(Papel);
            PossiblyChoices.Add(Tesoura);
            PossiblyChoices.Add(Spock);
            PossiblyChoices.Add(Lagarto);
        }
    }
}
