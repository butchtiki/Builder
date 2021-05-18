namespace Builder
{
    public enum MoveDistance : int { MAX = 10, MIN = 1 }
    public abstract class Parts
    {
        public string Name { get; set; }

        public Parts(string name)
        {
            this.Name = name;
        }
        
        public abstract void Move(int meters);
    }
}