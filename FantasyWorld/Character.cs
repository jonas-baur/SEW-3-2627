namespace FantasyWorld
{
    abstract class Character : IMoveable, IShowable
    {

        public ConsoleColor Color { get; set; }
        
        public IntegerPosition Position { get; set; }
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
            Position = new IntegerPosition(World.random.Next(0, World.WIDTH), World.random.Next(0, World.HEIGHT));
        }

        public abstract void Move();
        public abstract void Show();

        // Gibt true zurück, wenn Zielposition innerhalb der Welt liegt, 
        // sonst false
        public bool TargetInWorld(int x, int y)
        {
            if (x >= 0 && y >= 0 
                && x < World.WIDTH && y < World.HEIGHT) return true;
            return false;
        }
    }
}
