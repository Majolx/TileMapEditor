using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using TileMapEditor.GUI;

namespace TileMapEditor
{
    // Declare a state enum
    public enum GameState
    {
        PLAY,
        FREEZE
    }

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        // Declare the state of the application
        public static GameState gameState = GameState.PLAY;

        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;

        // Declare the client bounds
        public static Vector2 clientBounds;

        // Declare globals
        public static bool quit = false;
        public static Vector2 drawOffset = Vector2.Zero;

        // Declare file names
        public static String mapName;
        public static String fileName;
        public static String loadFileName;
        public static String tileSheetFileName;

        // Declare a var to hold the drawable layer
        public static int drawableLayer = 0;

        // Declare a map
        public static Map map;

        // Declare map and tile dimensions
        public static int mapHeight = 15;
        public static int mapWidth = 20;
        public static int tileHeight = 32;
        public static int tileWidth = 32;

        // Declare the selected tile
        public static int selectedTileNum = 0;

        // Declare textures
        public static Texture2D tileSheet;
        public static Texture2D solid;
        Texture2D pixel;

        // Declare the input states
        MouseState curState;
        KeyboardState prevState;
        int prevMouseWheel = 0;
        int curMouseWheel = 0;

        // Declare a font
        SpriteFont basic;

        // Declare the GUI
        HUD hud;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Initialize the map
            map = new Map(mapWidth, mapHeight, tileWidth, tileHeight);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Set window dimensions
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 800;
            graphics.ApplyChanges();

            // Make the mouse visible
            this.IsMouseVisible = true;

            // Initialize the client bounds
            clientBounds = new Vector2(Window.ClientBounds.Width, Window.ClientBounds.Height);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load textures
            pixel = Content.Load<Texture2D>("spr/pixel");
            solid = Content.Load<Texture2D>("spr/solid");

            // Load the sprite font
            basic = Content.Load<SpriteFont>("Basic");

            // Initialize the HUD
            hud = new HUD(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (gameState == GameState.PLAY)
            {

                // Allows the game to exit
                if (quit)
                    this.Exit();

                // Update the map title
                this.Window.Title = "Map Editor - " + mapName;

                // Update the selected tile
                KeyboardState keyState = Keyboard.GetState();
                if (selectedTileNum < map.tileSet.Count - 1)
                {
                    if (curMouseWheel > prevMouseWheel || keyState.IsKeyDown(Keys.Up) && !prevState.IsKeyDown(Keys.Up))
                        selectedTileNum++;
                }
                if (selectedTileNum > 0)
                {
                    if (curMouseWheel < prevMouseWheel || keyState.IsKeyDown(Keys.Down) && !prevState.IsKeyDown(Keys.Down))
                        selectedTileNum--;
                }

                // Get mouse input
                if (tileSheet != null)
                {
                    if (drawableLayer == 0)
                        map.TileLayer1.SetTiles(selectedTileNum + 1);
                    else if (drawableLayer == 1)
                        map.TileLayer2.SetTiles(selectedTileNum + 1);
                    else if (drawableLayer == 2)
                        map.SolidLayer.SetTiles(1);
                }

                // Update the mouse state
                curState = Mouse.GetState();

                // Update the previous keyboard state
                prevState = keyState;

                // Update mouse wheel values
                prevMouseWheel = curMouseWheel;
                curMouseWheel = curState.ScrollWheelValue;

                // Update scroll values
                map.UpdateUserInput();

                // Update the hud
                hud.Update();

                base.Update(gameTime);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            // Draw map bounds
            spriteBatch.Draw(pixel, new Rectangle(
                -(int)drawOffset.X * map.tileWidth, -(int)drawOffset.Y * map.tileHeight,
                map.mapWidth * map.tileWidth,
                map.mapHeight * map.tileHeight), Color.White);

            // Draw the map
            map.DrawMap();

            // Draw the HUD
            hud.Draw();

            // Draw the selected tile overlay
            if (tileSheet != null && drawableLayer != 2)
                spriteBatch.Draw(tileSheet, new Vector2(curState.X - tileWidth / 2, curState.Y - tileHeight / 2),
                    map.tileSet[selectedTileNum], Color.White);

            // Show the user which layer they are drawing on
            string layerText = "";

            if (drawableLayer == 0)
                layerText = "Layer 1";
            else if (drawableLayer == 1)
                layerText = "Layer 2";
            else if (drawableLayer == 2)
                layerText = "Collision Layer";

            spriteBatch.DrawString(basic, layerText, new Vector2(5, 5), Color.White);
            
            base.Draw(gameTime);

            spriteBatch.End();
        }
    }
}
