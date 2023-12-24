namespace Configuration // State Machine Class Configuration Form
{
    // Straightforward with only one bit to set
    internal class Form
    {
        // Internal Values
        private bool epic;
        private bool legend;

        // Getter Values
        public bool Value { get; private set; }
        public bool Divergence { get; private set; }
        public bool Hierarchy { get; private set; }

        // Semi-Private Setter Values (EL)
        public bool Epic
        {
            get { return epic; }
            set
            {
                epic = value;
                Legend = epic;
            }
        }
        public bool Legend // Epic set
        {
            get { return legend; }
            set // Unmaintained Portion
            {
                bool previousValue = legend;
                legend = value;

                if (!(legend == Value))
                {
                    if (!(previousValue == Divergence))
                    {
                        legend = Value;
                    }
                    if (!(legend == Hierarchy))
                    {
                        legend = !(previousValue && legend);
                    }
                }
                Value = epic;
                Divergence = previousValue;
                Hierarchy = !(epic && Hierarchy); // The form of class in configuration (Configuration.Form) for splitting a bit-state in half
            }
        }
    }
}
    // Analysed for comprehension integral by the setting in cohesion of purpose to one bit.