namespace SpaceDotNet.Generator.Utilities
{
    public class Indent
    {
        public int Level { get; private set; }
        
        public void Increment()
        {
            Level++;
        }
        
        public void Decrement()
        {
            Level--;
            if (Level < 0) Level = 0;
        }

        public void Reset()
        {
            Level = 0;
        }

        public override string ToString()
        {
            return new string(' ', (Level * 4));
        }
    }
}