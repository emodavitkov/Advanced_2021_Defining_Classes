using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count<Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(n => n.Name == name);
            if (player==null)
            {
                return false;
            }

            roster.Remove(player);
            return true;
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(n => n.Name == name);
            if (player.Rank=="Trial")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(n => n.Name == name);
            if (player.Rank == "Member")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] player = roster.Where(n => n.Class == @class).ToArray();

            foreach (var item in player)
            {
                roster.Remove(item);
            }

            return player;


        }
        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine($"{player}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}