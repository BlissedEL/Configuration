namespace Configuration
{
    public class Bless
    {
        public Legend Regard { get; set; }
        public Legend Relevance { get; set; }
        public Legend Relation { get; set; }
        public Bless()
        {
            Regard = new();
            Relevance = new();
            Relation = new();
        }
    }
}