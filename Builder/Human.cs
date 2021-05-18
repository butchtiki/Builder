using System;
namespace Builder
{
    
    public enum MovementStatus { TOOSHORT, NORMAL, TOOLONG }

    public class Human : Body
    {
        public MovementStatus movementStatus;

        public Human(string name): base(name)
        {
        }

        public override void Move(int meters)
        {
            if(meters > (int)MoveDistance.MAX)
            {
                movementStatus = MovementStatus.TOOLONG;
            }
            else if(meters < (int)MoveDistance.MIN)
            {
                movementStatus = MovementStatus.TOOSHORT;
            }
            else
            {
                movementStatus = MovementStatus.NORMAL;
            }
            Console.WriteLine("Human Moving");
        }
    }
}
