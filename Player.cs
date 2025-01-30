using Raylib_cs;

namespace RaylibGame
{
    public sealed class Player
    {
        private static int Width { get; set; } = 100;
        private static int Height { get; set; } = 100;
        private static int PosX { get; set; } = 100;
        private static int PosY { get; set; } = 100;

        private static Rectangle player = new (PosX, PosY, Width, Height);

        private static Player? Instance;
        
        private Player() 
        {
        }

        public void Update ()
        {
            
            Raylib.DrawRectangleRec(player, Color.White);
        }

        public static Player GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Player();
            }
            return Instance;
        }


    }
}
