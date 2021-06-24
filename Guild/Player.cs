using System.Text;

namespace Guild
{
    public class Player
    {
        public Player()
        {
            Rank = "Trial";
            Description = "n/a";
        }

        public Player(string name, string @class)
        :this()
        {
            Name = name;
            Class = @class;
           
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"Player {Name}: {Class}");
            result.AppendLine($"Rank: {Rank}");
            result.Append($"Description: {Description}");

            return result.ToString();
        }
    }
}