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
        LeftRight leftRight;
        UpDown upDown;
        public BallMovementManager(BallModel ball)
        {
            this.ball = ball;
            GenerateRandomStart();
        }

        public void GenerateRandomStart()
        {
            Random random = new Random();
            int left = random.Next(0,2);
            if (left == 0)
                leftRight = LeftRight.Left;
            else
                leftRight = LeftRight.Right;
            int up = random.Next(0,2);
            if (up == 0)
                upDown = UpDown.Up;
            else
                upDown = UpDown.Down;

            ball.SpeedVertical = random.Next(ball.SpeedVerticalMin, ball.SpeedVerticalMax + 1);
            ball.SpeedHorizontal = random.Next(ball.SpeedHorizontalMin, ball.SpeedHorizontalMax + 1);
        }

        public void MakeMove()
        {
            if (leftRight == LeftRight.Right)
                ball.X += ball.SpeedHorizontal;
            else if (leftRight == LeftRight.Left)
                ball.X -= ball.SpeedHorizontal;

            if (upDown == UpDown.Down)
                ball.Y += ball.SpeedVertical;
            else if (upDown == UpDown.Up)
                ball.Y -= ball.SpeedVertical;
        }
    }
}
