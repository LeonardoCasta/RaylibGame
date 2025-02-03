using System.Numerics;
using Raylib_cs;

namespace RaylibGame;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(Constants.screenWidth, Constants.screenHeight, "Hello World");
        Raylib.SetTargetFPS(60);

        //textures 
        string imagePath = Path.Combine("resources", "pixelartStarfield.png");
        Texture2D background = Raylib.LoadTexture(imagePath);

        Player player = Player.GetInstance();

        CameraCenter camera = new(player);

        Vector2 VBack = new (0, 0);

        while (!Raylib.WindowShouldClose())
        {
            //delta time during frames
            float deltaTime = Raylib.GetFrameTime();

            //update
            player.Update(deltaTime);
            camera.Update(player);

            //draw
            Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.LightGray);

                Raylib.DrawTextureV(background, VBack, Color.White);

                //Raylib.BeginMode2D(camera.getCamera());
            
                player.Draw();

                //Raylib.EndMode2D();            
            Raylib.EndDrawing();
        }

        Raylib.UnloadTexture(background);

        Raylib.CloseWindow();
    }
}