namespace jokenpo.Models
{
    public sealed class Choice
    {
        public string ChoiceName { get; private set; }

        public IEnumerable<string> WinsFor { get; private set; } = new List<string>();

        public IEnumerable<string> LosesFor { get; private set; } = new List<string>();

        public Choice(string choiceName, IEnumerable<string> winsFor, IEnumerable<string> losesFor)
        {
            ChoiceName = choiceName;
            WinsFor = winsFor;
            LosesFor = losesFor;
        }
    }
}