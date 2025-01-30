using Raylib_cs;

namespace RaylibGame;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(1280, 720, "Hello World");
        Raylib.SetTargetFPS(60);
        
        Player player = Player.GetInstance();

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            player.Update();

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}