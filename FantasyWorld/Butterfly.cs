namespace FantasyWorld
{
    class Butterfly : Bonus, IMoveable
    {
        public Butterfly() : base()
        {
            Value = 3;
        }

        public void Move()
        {
            int randomJump = World.random.Next(0, 4);
            int dx = 0;
            int dy = 0;
            switch(randomJump)
            {
                case 0: dx = 2; dy = -2; break;
                case 1: dx = -2; dy = -2; break;
                case 2: dx = -2; dy = 2; break;
                case 3: dx = 2; dy = 2; break;
            }
            Position.X += dx;
            if (Position.X >= World.WIDTH) Position.X -= World.WIDTH;
            if (Position.X < 0) Position.X += World.WIDTH;
            
            Position.Y += dy;
            if (Position.Y >= World.HEIGHT) Position.Y -= World.HEIGHT;
            if (Position.Y < 0) Position.Y += World.HEIGHT;
        }
    }
}
