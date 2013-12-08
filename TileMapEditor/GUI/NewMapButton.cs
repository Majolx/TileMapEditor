using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor.GUI
{
    class NewMapButton : Button
    {
        // Declare an instance variable
        public bool clicked = false;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="texture">The button texture</param>
        /// <param name="position">The button position</param>
        public NewMapButton(Texture2D texture, Vector2 position)
            :base(texture, position)
        {
        }


        /// <summary>
        /// Update clicked
        /// </summary>
        public override void Update()
        {
            clicked = base.clicked;
            base.Update();
        }


        /// <summary>
        /// Event for the button
        /// </summary>
        public override void Effect()
        {
            // Freeze the application
            Game1.gameState = GameState.FREEZE;

            // Create and display the form
            Forms.NewMapForm newMap = new Forms.NewMapForm();
            newMap.ShowDialog();

            // Set the variables from the form
            if (newMap.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Game1.mapHeight = newMap.mapHeight;
                Game1.mapWidth = newMap.mapWidth;
                Game1.tileHeight = newMap.tileHeight;
                Game1.tileWidth = newMap.tileWidth;
                Game1.mapName = newMap.mapName;

                // Reset values
                Game1.selectedTileNum = 0;
                Game1.drawOffset = Microsoft.Xna.Framework.Vector2.Zero;

                // Initialize the map
                Game1.map = new Map(Game1.mapWidth, Game1.mapHeight, Game1.tileWidth, Game1.tileHeight);

                if (Game1.tileSheet != null)
                    Game1.map.LoadTileSet(Game1.tileSheet);

                // Reset button clicks
                base.prevClicked = false;
            }
            else
            {
                // Reset button clicks
                base.prevClicked = false;
            }

            // Unfreeze the game
            Game1.gameState = GameState.PLAY;

            base.Effect();
        }
    }
}
