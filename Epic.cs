namespace Configuration
{
    public class Epic
    {
        public Configure Setting { get; set; }
        public string Heart { get; private set; } = "";
        public Epic()
        {
            Setting = new();
        }
        public Epic Sing(string consideration)
        {
            Heart = consideration;
            foreach (char c in Heart)
            {
                // Heart-to-value intersection
                Setting.Motion(c);
                // Do stuff with the characters in heart-to-value intersection ratio here.
            }
            return this;
        }
    }
}