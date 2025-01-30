using Raylib_cs;
using System.Numerics;

namespace RaylibGame
{
    internal sealed class Player
    {
        private static int Width { get; set; } = 100;
        private static int Height { get; set; } = 100;
        private static int PosX { get; set; } = 100;
        private static int PosY { get; set; } = 100;
        private static float Speed { get; set; } = 100;
        private static float Acceleration { get; set; } = 1;

        private static Rectangle player = new (PosX, PosY, Width, Height);

        private static Player? Instance;
        
        private Player() 
        {
        }

        public void Update (float deltaTime) 
        {
            Speed *= Acceleration;
            //up down
            if (Raylib.IsKeyDown(KeyboardKey.W))
            {
                player.X -= deltaTime * Speed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.S))
            {
                player.X += deltaTime * Speed;
            }

            //right left
            if (Raylib.IsKeyDown(KeyboardKey.A))
            {
                player.Y -= deltaTime * Speed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.D))
            {
                player.Y += deltaTime * Speed;
            }
        }

        public void Draw()
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

        public float getX()
        {
            return player.X;
        }

        public float getY()
        {
            return player.Y;
        }

        public Vector2 getPosition()
        {
            return player.Position;
        }
    }
}
