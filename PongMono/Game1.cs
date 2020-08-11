using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PongMonoLibrary;
using System.CodeDom;

namespace PongMono
{
    
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        const int playerWidth = 30;
        const int playerHeight = 150;
        const int playerStartingSpeed = 10;
        const int playerSpaceFromEdge = 20;

        const int ballWidth = 50;
        const int ballHeight = 50;
        const int ballHorizontalSpeedMin = 5;
        const int ballHorizontalSpeedMax = 9;
        const int ballVerticalSpeedMin = 8;
        const int ballVerticalSpeedMax = 15;
            

        Texture2D background_sprite;
        Texture2D firstPlayer_sprite;
        Texture2D secondPlayer_sprite;
        Texture2D ball_sprite;
        SpriteFont game_font;

        PlayerModel firstPlayer;
        PlayerModel secondPlayer;

        BallModel ball;

        BallMovementManager ballManager;
        ColisionManager colisionManager;
        PlayerManager playerManager;

        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1250;
            graphics.PreferredBackBufferHeight = 750;
            SetStartingValues();
            ballManager = new BallMovementManager(ball);
            colisionManager = new ColisionManager(firstPlayer, secondPlayer, ball, graphics);
            playerManager = new PlayerManager(firstPlayer, secondPlayer, graphics);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();            
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background_sprite = Content.Load<Texture2D>("background_sprite");
            firstPlayer_sprite = Content.Load<Texture2D>("firstplayer_sprite");
            secondPlayer_sprite = Content.Load<Texture2D>("secondplayer_sprite");
            game_font = Content.Load<SpriteFont>("game_font");
            ball_sprite = Content.Load<Texture2D>("ball_sprite");
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            colisionManager.CheckForCollision();

            playerManager.MovePlayer();

            ballManager.MakeMove();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            spriteBatch.Begin();

            spriteBatch.Draw(background_sprite, new Rectangle(0,0,graphics.PreferredBackBufferWidth,graphics.PreferredBackBufferHeight), Color.White);
            spriteBatch.Draw(firstPlayer_sprite, firstPlayer.ConvertToRectangle(),Color.White);
            spriteBatch.Draw(secondPlayer_sprite, secondPlayer.ConvertToRectangle(), Color.White);
            spriteBatch.Draw(ball_sprite, ball.ConvertToRectangle(), Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }

        private void SetStartingValues()
        {
            int windowWidth = graphics.PreferredBackBufferWidth;
            int windowHeight = graphics.PreferredBackBufferHeight;

            int playerStartingY = windowHeight / 2 - playerHeight / 2;
            int firstPlayerStartingX = playerSpaceFromEdge;
            int secondPlayerStartingX = windowWidth - playerSpaceFromEdge - playerWidth;

            firstPlayer = new PlayerModel
            {
                Speed = playerStartingSpeed,
                X = firstPlayerStartingX,
                Y = playerStartingY,
                Width = playerWidth,
                Height = playerHeight
            };

            secondPlayer = new PlayerModel
            {
                Speed = playerStartingSpeed,
                X = secondPlayerStartingX,
                Y = playerStartingY,
                Width = playerWidth,
                Height = playerHeight
            };

            ball = new BallModel
            {
                X = windowWidth / 2 - ballWidth /2,
                Y = windowHeight /2 - ballHeight /2,
                Width = ballWidth,
                Height = ballHeight,
                SpeedHorizontalMin = ballHorizontalSpeedMin,
                SpeedHorizontalMax = ballHorizontalSpeedMax,
                SpeedVerticalMin = ballVerticalSpeedMin,
                SpeedVerticalMax = ballVerticalSpeedMax
            };
        }

        

        
    }
}
