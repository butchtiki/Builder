using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerBuilder newBuilder = new PlayerBuilder();
            Player fantasyPlayer = newBuilder.CreateFantasyPlayer("Valdor");
            Player realisticPlayer = newBuilder.CreateRealisticPlayer("Armel");
            fantasyPlayer.Move(15);
            realisticPlayer.Move(7);
        }
    }
}
