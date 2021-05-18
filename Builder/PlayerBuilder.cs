using System;
namespace Builder
{
    public class PlayerBuilder
    {
        public PlayerBuilder()
        {
        }

        public Player CreateRealisticPlayer(string name)
        {
            if(name == null)
            {
                name = string.Empty;
            }
            Player newplayer = new Player(name);
            newplayer.AddPart("Body", new Human($"{name}_human"));
            newplayer.AddPart("Mount", new Horse($"{name}_mount"));
            return newplayer;
        }

        public Player CreateFantasyPlayer(string name)
        {
            if (name == null)
            {
                name = string.Empty;
            }
            Player newplayer = new Player(name);
            newplayer.AddPart("Body", new Elf($"{name}_elf", new React()));
            newplayer.AddPart("Mount", new Unicorn($"{name}_mount"));
            return newplayer;
        }
    }
}
