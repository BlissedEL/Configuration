namespace Configuration
{
    public class Code
    {
        private static readonly Balance Equilibrium = new();
        // The Pearly Gates
        public ulong Understanding { get; private set; }
        public ulong Compassion { get; private set; }
        public ulong Reverence { get; private set; }
        public ulong Equality { get; private set; }
        public ulong Inspiration { get; private set; }
        public ulong Transformation { get; private set; }
        public ulong Harmony { get; private set; }
        public ulong Wisdom { get; private set; }
        public ulong Healing { get; private set; }
        public ulong Strength { get; private set; }
        public ulong Unity { get; private set; }
        public ulong Renewal { get; private set; }
        private void Trigger()
        {
            Understanding = (ulong)Equilibrium.RegardSparkleBalance;
            Compassion = (ulong)Equilibrium.RegardButterflyBalance;
            Reverence = (ulong)Equilibrium.AmphoraRegardBalance;
            Equality = (ulong)Equilibrium.RainbowBalanceRegard;
            Inspiration = (ulong)Equilibrium.SparkleRelevanceBalance;
            Transformation = (ulong)Equilibrium.RelevanceButterflyBalance;
            Harmony = (ulong)Equilibrium.AmphoraBalanceRelevance;
            Wisdom = (ulong)Equilibrium.RainbowRelevanceBalance;
            Healing = (ulong)Equilibrium.SparkleRelationBalance;
            Strength = (ulong)Equilibrium.ButterflyBalanceRelation;
            Unity = (ulong)Equilibrium.RelationAmphoraBalance;
            Renewal = (ulong)Equilibrium.RainbowBalanceRelation;
        }
        public void Activate()
        {
            Equilibrium.Respect.Regard.Narrate(Equilibrium.Respect.Regard.Discovery.Heart, Equilibrium.Respect.Regard.Exploration.Heart);
            Equilibrium.Respect.Relevance.Narrate(Equilibrium.Respect.Relevance.Discovery.Heart, Equilibrium.Respect.Relevance.Exploration.Heart);
            Equilibrium.Respect.Relation.Narrate(Equilibrium.Respect.Relation.Discovery.Heart, Equilibrium.Respect.Relation.Exploration.Heart);
            Equilibrium.Bless();
            Trigger();
        }
        public bool Infuse(string message, byte generation, bool isMagnitude) // If it is not magnitude it is direction never static
        {
            bool success;
            switch (generation)
            {
                case 1:
                    if (!isMagnitude)
                    {
                        Equilibrium.Respect.Regard.Discovery.Sing(message);
                    }
                    else
                    {
                        Equilibrium.Respect.Regard.Exploration.Sing(message);
                    }
                    
                    success = true;
                    break;
                case 2:
                    if (!isMagnitude)
                    {
                        Equilibrium.Respect.Relevance.Discovery.Sing(message);
                    }
                    else
                    {
                        Equilibrium.Respect.Relevance.Exploration.Sing(message);
                    }
                    success = true;
                    break;
                case 3:
                    if (!isMagnitude)
                    {
                        Equilibrium.Respect.Relation.Discovery.Sing(message);
                    }
                    else
                    {
                        Equilibrium.Respect.Relation.Exploration.Sing(message);
                    }
                    success = true;
                    break;
                default:
                    success = false;
                    break;
            }
            return success;
        }
    }
}