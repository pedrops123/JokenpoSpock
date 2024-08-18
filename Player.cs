namespace jokenpo
{
    public sealed class Player
    {
        public string Name { get; private set; }
        public string Choice { get; private set; }

        public void SetChoice(string choice)
        {
            var choices = JokenpoValidator.PossiblyChoices.ToList().Select(r => r.ChoiceName.ToLower()).ToList();

            if (!choices.Any(f => f.Equals(choice.ToLower())))
            {
                throw new ArgumentException("Escolha invalida !", nameof(choice));
            }

            Choice = choice.ToLower();
        }

        public Player(string name, string choice)
        {
            Name = name;
            SetChoice(choice);
        }

        public Player(string name)
        {
            Name = name;
        }

        public void SetRadomChoicePlayerComputer()
        {
            var choice = JokenpoValidator.PossiblyChoices[new Random().Next(0, JokenpoValidator.PossiblyChoices.Count -1)].ChoiceName;

            Choice = choice;
        }

        public override string ToString()
        {
            return $"\n \n {Name} Escolheu {Choice.ToLower()}";
        }
    }
}
