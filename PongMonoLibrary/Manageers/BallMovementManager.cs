using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongMonoLibrary
{
    public class BallMovementManager
    {
        BallModel ball;        
        public BallMovementManager(BallModel ball)
        {
            this.ball = ball;
        }

        public void GenerateRandomStart(WhoScored whoScored)
        {
            Random random = new Random();
            if (whoScored == WhoScored.FirstPlayer)
                ball.LeftRightValue = LeftRight.Left;
            else if (whoScored == WhoScored.SecondPlayer)
                ball.LeftRightValue = LeftRight.Right;
            else
            {
                int left = random.Next(0, 2);
                if (left == 0)
                    ball.LeftRightValue = LeftRight.Left;
                else
                    ball.LeftRightValue = LeftRight.Right;
            }

            int up = random.Next(0,2);
            if (up == 0)
                ball.UpDownValue = UpDown.Up;
            else
                ball.UpDownValue = UpDown.Down;

            ball.SpeedVertical = random.Next(ball.SpeedVerticalMin, ball.SpeedVerticalMax + 1);
            ball.SpeedHorizontal = random.Next(ball.SpeedHorizontalMin, ball.SpeedHorizontalMax + 1);
        }

        public void MakeMove()
        {
            if (ball.LeftRightValue == LeftRight.Right)
                ball.X += ball.SpeedHorizontal;
            else if (ball.LeftRightValue == LeftRight.Left)
                ball.X -= ball.SpeedHorizontal;

            if (ball.UpDownValue == UpDown.Down)
                ball.Y += ball.SpeedVertical;
            else if (ball.UpDownValue == UpDown.Up)
                ball.Y -= ball.SpeedVertical;
        }
    }
}
