using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace RaylibGame
{
    internal class CameraCenter
    {
        private Camera2D camera;
        public CameraCenter(Player player) 
        {
            camera.Target = player.getPosition();
            camera.Offset = Constants.cameraDefaultOffset;
            camera.Rotation = 0.0f;
            camera.Zoom = 1.0f;
        }

        public void Update(Player player)
        {
            camera.Offset = Constants.cameraDefaultOffset;
            camera.Target = player.getPosition();
        }

        public Camera2D getCamera()
        {
            return camera;
        }

    }
}
