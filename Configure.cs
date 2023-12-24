namespace Configuration
{
    public class Configure
    {
        // Heart-to-value (LEGEND)
        internal Form[] Word { get; private set; } = new Form[16];
        
        // Heart-to-value intersection ratios (EPIC)
        public char LegendCharacter { get; private set; }
        public char ValueCharacter { get; private set; }
        public char DivergenceCharacter { get; private set; }
        public char HierarchyCharacter { get; private set; }
        
        public Configure()
        {
            for (int i = 0; i < 16; i++)
            {
                Word[i] = new();
            }
            LegendCharacter = '\u0000';
            ValueCharacter = '\u0000';
            DivergenceCharacter = '\u0000';
            HierarchyCharacter = '\u0000';
        }
        public void Motion(char word)
        {
            for (int i = 0; i < 16; i++)
            {
                Word[i].Epic = (word & (1 << i)) != 0;
            }
            LegendCharacter = GetLegendBitsAsChar();
            ValueCharacter = GetValueBitsAsChar();
            DivergenceCharacter = GetDivergenceBitsAsChar();
            HierarchyCharacter = GetHierarchyBitsAsChar();
        }
        private char GetLegendBitsAsChar()
        {
            char word = '\u0000';
            for (int i = 0; i < 16; i++)
            {
                if (Word[i].Legend)
                {
                    word |= (char)(1 << i);
                }
            }
            return word;
        }
        private char GetValueBitsAsChar()
        {
            char word = '\u0000';
            for (int i = 0; i < 16; i++)
            {
                if (Word[i].Value)
                {
                    word |= (char)(1 << i);
                }
            }
            return word;
        }
        private char GetDivergenceBitsAsChar()
        {
            char word = '\u0000';
            for (int i = 0; i < 16; i++)
            {
                if (Word[i].Divergence)
                {
                    word |= (char)(1 << i);
                }
            }
            return word;
        }
        private char GetHierarchyBitsAsChar()
        {
            char word = '\u0000';
            for (int i = 0; i < 16; i++)
            {
                if (Word[i].Hierarchy)
                {
                    word |= (char)(1 << i);
                }
            }
            return word;
        }
    }
}