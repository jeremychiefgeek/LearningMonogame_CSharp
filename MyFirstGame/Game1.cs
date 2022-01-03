using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyFirstGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        // Textures
        private Texture2D _background;
        private Texture2D _shuttle;
        private Texture2D _earth;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // use this.Content to load your game content here
            _background = Content.Load<Texture2D>("backgrounds/stars");
            _shuttle = Content.Load<Texture2D>("images/shuttle");
            _earth = Content.Load<Texture2D>("images/earth");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_background, new Rectangle(0,0,800, 480), Color.White);
            _spriteBatch.Draw(_earth, new Vector2(400, 240), Color.White);
            _spriteBatch.Draw(_shuttle, new Vector2(450, 240), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}