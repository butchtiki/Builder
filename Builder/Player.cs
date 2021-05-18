namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        Dictionary<string, Parts> parts;

        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
            parts = new Dictionary<string, Parts>();
        }

        public bool AddPart(string partName, Parts part)
        {
            if(partName == null || part == null)
            {
                return false;
            }
            parts.Add(partName, part);
            return true;
        }

        public void Move(int meters)
        {
            for(int i = 0; i < parts.Count; i++)
            {
                parts.ElementAt(i).Value.Move(meters);
            }
        }
    }
}