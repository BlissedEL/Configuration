namespace Configuration
{
    public class Balance
    {
        public Bless Respect { get; set; } = new(); // Respect the balance.
        public Function RegardSparkles { get; set; } // Energy scalar
        public Function ButterflyRegard { get; set; } // Mass scalar
        public Function AmphoraRegard { get; set; } // Matter scalar
        public Function RainbowRegard { get; set; } // Time scalar
        public Function SparklesRelevance { get; set; }
        public Function RelevanceButterfly { get; set; }
        public Function RelevanceAmphora { get; set; }
        public Function RainbowRelevance { get; set; }
        public Function RelationSparkles { get; set; }
        public Function ButterflyRelation { get; set; }
        public Function RelationAmphora { get; set; }
        public Function RainbowRelation { get; set; }
        // Perpendicular in Respect
        public long RegardSparkleBalance { get; private set; }
        public long RegardButterflyBalance { get; private set; }
        public long AmphoraRegardBalance { get; private set; }
        public long RainbowBalanceRegard { get; private set; }
        public long SparkleRelationBalance { get; private set; }
        public long ButterflyBalanceRelation { get; private set; }
        public long RelationAmphoraBalance { get; private set; }
        public long RainbowBalanceRelation { get; private set; }
        public long SparkleRelevanceBalance { get; private set; }
        public long RelevanceButterflyBalance { get; private set; }
        public long AmphoraBalanceRelevance { get; private set; }
        public long RainbowRelevanceBalance { get; private set; }
        public Balance()
        {
            Respect = new();
            RegardSparkles = new(Respect.Regard.Energy[1]);
            ButterflyRegard = new(Respect.Regard.Mass[1]);
            AmphoraRegard = new(Respect.Regard.Matter[1]);
            RainbowRegard = new(Respect.Regard.Time[1]);
            SparklesRelevance = new(Respect.Relevance.Energy[1]);
            RelevanceButterfly = new(Respect.Relevance.Mass[1]);
            RelevanceAmphora = new(Respect.Relevance.Matter[1]);
            RainbowRelevance = new(Respect.Relevance.Time[1]);
            RelationSparkles = new(Respect.Relation.Energy[1]);
            ButterflyRelation = new(Respect.Relation.Mass[1]);
            RelationAmphora = new(Respect.Relation.Matter[1]);
            RainbowRelation = new(Respect.Relation.Time[1]);
    }
        public void Bless()
        {
            RegardSparkles = new(Respect.Regard.Energy[1]);
            ButterflyRegard = new(Respect.Regard.Mass[1]);
            AmphoraRegard = new(Respect.Regard.Matter[1]);
            RainbowRegard = new(Respect.Regard.Time[1]);
            SparklesRelevance = new(Respect.Relevance.Energy[1]);
            RelevanceButterfly = new(Respect.Relevance.Mass[1]);
            RelevanceAmphora = new(Respect.Relevance.Matter[1]);
            RainbowRelevance = new(Respect.Relevance.Time[1]);
            RelationSparkles = new(Respect.Relation.Energy[1]);
            ButterflyRelation = new(Respect.Relation.Mass[1]);
            RelationAmphora = new(Respect.Relation.Matter[1]);
            RainbowRelation = new(Respect.Relation.Time[1]);

            // Implicit modality (extrinsic to the explicit position)
            RegardSparkleBalance = RegardSparkles.Eloquence(Respect.Regard.Energy[0]); // Energy vector
            RegardButterflyBalance = ButterflyRegard.Eloquence(Respect.Regard.Mass[0]); // Mass vector
            AmphoraRegardBalance = AmphoraRegard.Eloquence(Respect.Regard.Matter[0]); // Matter vector
            RainbowBalanceRegard = RainbowRegard.Eloquence(Respect.Regard.Time[0]); // Time vector
            SparkleRelationBalance = RelationSparkles.Eloquence(Respect.Relation.Energy[0]);
            ButterflyBalanceRelation = ButterflyRelation.Eloquence(Respect.Relation.Mass[0]);
            RelationAmphoraBalance = RelationAmphora.Eloquence(Respect.Relation.Matter[0]);
            RainbowBalanceRelation = RainbowRelation.Eloquence(Respect.Relation.Time[0]);
            SparkleRelevanceBalance = SparklesRelevance.Eloquence(Respect.Relevance.Energy[0]);
            RelevanceButterflyBalance = RelevanceButterfly.Eloquence(Respect.Relevance.Mass[0]);
            AmphoraBalanceRelevance = RelevanceAmphora.Eloquence(Respect.Relevance.Matter[0]);
            RainbowRelevanceBalance = RainbowRelevance.Eloquence(Respect.Relevance.Time[0]);
        }
    }
}