namespace Configuration
{
    // How can I encapsulate the logic for creating and updating Function instances?
    public class Function
    {
        public int Balance { get; private set; }

        public Function(char weight)
        {
            SetBalance(weight);
        }

        public void SetBalance(char weight)
        {
            Balance = weight; // A design choice to be aware of.
        }

        public long Eloquence(char vector)
        {
            return vector * vector * Balance;
        }
    }
}