using Microsoft.Xna.Framework;
using PongMonoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongMono
{
    public static class DrawingHelper
    {
        public static Rectangle ConvertPlayerToRectangle(this IRectangleConvertable player)
        {
            Rectangle output = new Rectangle();
            output.X = player.X;
            output.Y = player.Y;
            output.Width = player.Width;
            output.Height = player.Height;
            return output;
        }
    }
}
