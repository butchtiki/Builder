using System;
namespace Builder
{
    public class Horse : Mount
    {
        public enum MoodStatus { NOFEELINGS, NORMAL, CRY}

        public MoodStatus moodStatus;
        
        public Horse(string name): base (name)
        {
            moodStatus = MoodStatus.NORMAL;
        }

        public override void Move(int meters)
        {
            if (meters > (int)MoveDistance.MAX)
            {
                moodStatus = MoodStatus.CRY;
            }
            else if (meters < (int)MoveDistance.MIN)
            {
                moodStatus = MoodStatus.NOFEELINGS;
            }
            else
            {
                moodStatus = MoodStatus.NORMAL;
            }
            Console.WriteLine("Horse Moving");
        }
    }
}