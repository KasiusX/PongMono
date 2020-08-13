using Microsoft.Xna.Framework;
using PongMono;
using System.Resources;

namespace PongMonoLibrary
{
    public class EndManager
    {
        PlayerModel firstPlayer;
        PlayerModel secondPlayer;
        BallModel ball;
        GraphicsDeviceManager graphics;
        IPlayerScoredRequestor requestor;
        public EndManager(PlayerModel firstPlayer,PlayerModel secondPlayer, BallModel ball, GraphicsDeviceManager graphics, IPlayerScoredRequestor requestor)
        {
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
            this.ball = ball;
            this.graphics = graphics;
            this.requestor = requestor;
        }

        public void CheckIfMissed()
        {
            if (ball.X <= 0)
            {
                requestor.Stop(WhoScored.SecondPlayer);
            }
            if (ball.X + ball.Width >= graphics.PreferredBackBufferWidth)
            {
                requestor.Stop(WhoScored.FirstPlayer);
            }
        }
    }
}
