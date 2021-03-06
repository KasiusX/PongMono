﻿using Microsoft.Xna.Framework;
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
            {
                if(ball.X >= firstPlayer.X + firstPlayer.Width / 4)
                   ball.LeftRightValue = LeftRight.Right;            
                else
                {
                    if (ball.UpDownValue == UpDown.Down)
                        ball.UpDownValue = UpDown.Up;
                    else
                        ball.UpDownValue = UpDown.Down;
                }
            }
            if (Rectangle.Intersect(secondPlayer.ConvertToRectangle(), ball.ConvertToRectangle()) != new Rectangle())
            {
                if(ball.X + ball.Width <= secondPlayer.X + secondPlayer.Width /4 )
                    ball.LeftRightValue = LeftRight.Left;
                else
                {
                    if (ball.UpDownValue == UpDown.Down)
                        ball.UpDownValue = UpDown.Up;
                    else
                        ball.UpDownValue = UpDown.Down;
                }
            }
            if (ball.Y <= 0)
                ball.UpDownValue = UpDown.Down;
            if (ball.Y + ball.Height >= graphics.PreferredBackBufferHeight)
                ball.UpDownValue = UpDown.Up;
        }
    }
}
