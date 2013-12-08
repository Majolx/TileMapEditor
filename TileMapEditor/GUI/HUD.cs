using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor.GUI
{
    public class HUD
    {
        // Declare textures
        Texture2D panel;
        Texture2D newMap;
        Texture2D saveMap;
        Texture2D loadMap;
        Texture2D loadTiles;
        Texture2D backLayer;
        Texture2D frontLayer;
        Texture2D collisionLayer;

        // Declare position
        Vector2 position;

        // Declare a list of buttons
        List<Button> buttons = new List<Button>();


        public HUD(ContentManager content)
        {
            // Load button textures
            panel = content.Load<Texture2D>("spr/panel");
            newMap = content.Load<Texture2D>("spr/newMap");
            saveMap = content.Load<Texture2D>("spr/saveMap");
            loadMap = content.Load<Texture2D>("spr/loadMap");
            loadTiles = content.Load<Texture2D>("spr/loadTiles");
            backLayer = content.Load<Texture2D>("spr/backLayer");
            frontLayer = content.Load<Texture2D>("spr/frontLayer");
            collisionLayer = content.Load<Texture2D>("spr/collisionLayer");

            // Initialize the position
            position = new Vector2(0, (int)Game1.clientBounds.Y - panel.Height);

            // Add the buttons to the button list
            buttons.Add(new NewMapButton         (newMap,         new Vector2(position.X + 25,  position.Y + 25)));
            buttons.Add(new SaveMapButton        (saveMap,        new Vector2(position.X + 150, position.Y + 25)));
            buttons.Add(new LoadMapButton        (loadMap,        new Vector2(position.X + 275, position.Y + 25)));
            buttons.Add(new LoadTileButton       (loadTiles,      new Vector2(position.X + 400, position.Y + 25)));
            buttons.Add(new BackLayerButton      (backLayer,      new Vector2(position.X + 525, position.Y + 25)));
            buttons.Add(new FrontLayerButton     (frontLayer,     new Vector2(position.X + 600, position.Y + 25)));
            buttons.Add(new CollisionLayerButton (collisionLayer, new Vector2(position.X + 675, position.Y + 25)));
        }


        public void Update()
        {
            // Loop through the button list
            foreach (Button button in buttons)
            {
                // Update the button
                button.Update();

                // Check if clicked
                if (button.clicked) button.Effect();
            }
        }


        public void Draw()
        {
            // Draw the panel
            Game1.spriteBatch.Draw(panel, position, Color.White);

            // Draw the buttons
            foreach (Button button in buttons)
            {
                button.Draw();
            }
        }


    }
}
