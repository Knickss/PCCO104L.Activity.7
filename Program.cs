using System.Runtime.CompilerServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character ArthurMorgan = new Character(15000, "Arthur Morgan", "Double-Action Revolver");
            ArthurMorgan.Intro();

            Character JohnMarston = new Character(1000, "John Marston", "Cattleman Revolver");
            JohnMarston.Intro();

            Character DutchVanDerLinde = new Character(2000, "Dutch van der Linde", "Semi-automatic Pistol");
            DutchVanDerLinde.Intro();
        }
    }

    public class Character
    {
        private string Name { get; set; }

        private string Weapon { get; set; }

        private int Bounty { get; set; }

        public Character() { }

        public Character(int bounty)
        {
            Bounty = bounty;
        }

        public Character(int bounty, string name) : this(bounty)
        {
            Name = name;
        }

        public Character(int bounty, string name, string weapon) : this(bounty, name)
        {
            Weapon = weapon;
        }

        public void Intro()
        {
            Console.WriteLine($"{Name} - {Weapon} - Bounty: ${Bounty}");
        }
    }
}
