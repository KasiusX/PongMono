using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PongMonoLibrary
{
    public class PlayerManager
    {
        PlayerModel firstPlayer;
        PlayerModel secondPlayer;
        GraphicsDeviceManager graphics;
        public PlayerManager(PlayerModel firstPlayer, PlayerModel secondPlayer, GraphicsDeviceManager graphics)
        {
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
            this.graphics = graphics;
        }

        public void MovePlayer()
        {
            KeyboardState kState = Keyboard.GetState();
            if (kState.IsKeyDown(Keys.W) && firstPlayer.Y > 0)
            {
                firstPlayer.Y -= firstPlayer.Speed;
            }
            if (kState.IsKeyDown(Keys.S) && firstPlayer.Y + firstPlayer.Height < graphics.PreferredBackBufferHeight)
            {
                firstPlayer.Y += firstPlayer.Speed;
            }
            if (kState.IsKeyDown(Keys.Up) && secondPlayer.Y > 0)
            {
                secondPlayer.Y -= secondPlayer.Speed;
            }
            if (kState.IsKeyDown(Keys.Down) && secondPlayer.Y + secondPlayer.Height < graphics.PreferredBackBufferHeight)
            {
                secondPlayer.Y += secondPlayer.Speed;
            }
        }
    }
}
