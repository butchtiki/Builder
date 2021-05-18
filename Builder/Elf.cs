namespace Builder
{
    using System;

    public class Elf : Body
    {
        IReact react;

        public Elf(string name, IReact react): base(name)
        {
            this.react = react;
        }

        public override void Move(int meters)
        {
            if (meters > (int)MoveDistance.MAX)
            {
                this.react.Jump();
            }

            else if (meters < (int)MoveDistance.MIN)
            {
                this.react.Eat();
            }
            else
            {
                this.react.CreateBlackhole();
            }
        }
    }
}
