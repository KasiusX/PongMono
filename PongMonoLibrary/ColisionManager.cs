using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using PongMono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongMonoLibrary
{
    public class ColisionManager
    {
        PlayerModel firstPlayer;
        PlayerModel secondPlayer;
        BallModel ball;
        GraphicsDeviceManager graphics;

        public ColisionManager(PlayerModel firstPlayer,PlayerModel secondPlayer, BallModel ball, GraphicsDeviceManager graphics)
        {
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
            this.ball = ball;
            this.graphics = graphics;
        }

        public void CheckForCollision()
        {            
            if (Rectangle.Intersect(firstPlayer.ConvertToRectangle(), ball.ConvertToRectangle()) != new Rectangle())
                ball.LeftRightValue = LeftRight.Right;
            if (Rectangle.Intersect(secondPlayer.ConvertToRectangle(), ball.ConvertToRectangle()) != new Rectangle())
                ball.LeftRightValue = LeftRight.Left;
            if (ball.Y <= 0)
                ball.UpDownValue = UpDown.Down;
            if (ball.Y + ball.Height >= graphics.PreferredBackBufferHeight)
                ball.UpDownValue = UpDown.Up;
        }
    }
}
