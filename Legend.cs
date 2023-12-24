namespace Configuration
{
    public class Legend
    {
        public char[] Energy { get; private set; } = new char[2];
        public char[] Mass { get; private set; } = new char[2];
        public char[] Matter { get; private set; } = new char[2];
        public char[] Time { get; private set; } = new char[2];
        public Epic Discovery { get; set; }
        public Epic Exploration { get; set; }
        public Legend()
        {
            Discovery = new();
            Exploration = new();
        }
        public void Narrate(string care, string magnificence)
        {
            Discovery = Discovery.Sing(care);
            Exploration = Exploration.Sing(magnificence);

            // CMD: Composing Dignity (Dimensionality) out of Care and Magnificence (Components and Magnitudes)
            Energy = [Discovery.Setting.ValueCharacter, Exploration.Setting.ValueCharacter];
            Mass = [Discovery.Setting.DivergenceCharacter, Exploration.Setting.DivergenceCharacter];
            Matter = [Discovery.Setting.HierarchyCharacter, Exploration.Setting.HierarchyCharacter];
            Time = [Discovery.Setting.LegendCharacter, Exploration.Setting.LegendCharacter];
        }
    }
}