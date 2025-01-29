using Raylib_cs;

namespace RaylibGame;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(1280, 720, "Hello World");
        Raylib.SetTargetFPS(60);
        
        Rectangle rect = new Rectangle(500, 500, 100, 100);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Red);

            Raylib.DrawRectangleRec(rect, Color.White);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}