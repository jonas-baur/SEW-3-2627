namespace FantasyWorld
{
    abstract class Bonus : IShowable
    {
        public IntegerPosition Position { get; set; }
        public int Value { get; set; }

        public Bonus()
        {
            Position = new IntegerPosition(World.random.Next(0, World.WIDTH), World.random.Next(0, World.HEIGHT));
            Value = 1;
        }

        public virtual void Show()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("B");
        }
    }
}
