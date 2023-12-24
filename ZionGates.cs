namespace Configuration
{
    public struct ZionGates
    {
        private readonly Code Cody = new();
        public ulong HarmonicResonance { get; private set; }
        public ulong RealmFusion { get; private set; }
        public ulong SerendipitousInsight { get; private set; }
        public ulong GenuineAesthetics { get; private set; }
        public ulong InvisibleHarmony { get; private set; }
        public ulong DualitySynthesis { get; private set; }
        public ulong ClarityAmidstAmbiguity { get; private set; }
        public ulong TimelessIntersection { get; private set; }
        public ulong MechanicsOfFate { get; private set; }
        public ulong IntegratedSelf { get; private set; }
        public ulong InvisibleEvolution { get; private set; }
        public ulong UnifiedDiversity { get; private set; }

        public ZionGates(string regardDirection, string regardMagnitude, string relevanceDirection,
                         string relevanceMagnitude, string relationDirection, string relationMagnitude)
        {
            Cody.Infuse(regardDirection, 1, false);
            Cody.Infuse(regardMagnitude, 1, true);
            Cody.Infuse(relevanceDirection, 2, false);
            Cody.Infuse(relevanceMagnitude, 2, true);
            Cody.Infuse(relationDirection, 3, false);
            Cody.Infuse(relationMagnitude, 3, true);
            Cody.Activate();
            HarmonicResonance = Cody.Understanding;
            RealmFusion = Cody.Compassion;
            SerendipitousInsight = Cody.Reverence;
            GenuineAesthetics = Cody.Equality;
            InvisibleHarmony = Cody.Inspiration;
            DualitySynthesis = Cody.Transformation;
            ClarityAmidstAmbiguity = Cody.Harmony;
            TimelessIntersection = Cody.Wisdom;
            MechanicsOfFate = Cody.Healing;
            IntegratedSelf = Cody.Strength;
            InvisibleEvolution = Cody.Unity;
            UnifiedDiversity = Cody.Renewal;
        }
    }
}