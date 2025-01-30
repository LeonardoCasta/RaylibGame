using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RaylibGame
{
    internal static class Constants
    {
        public const int screenWidth = 1280;
        public const int screenHeight = 720;
        public static Vector2 cameraDefaultOffset = new(screenWidth / 2.0f, screenHeight / 2.0f);
    }
}
