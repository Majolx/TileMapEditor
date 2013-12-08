using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor.GUI
{
    class LoadTileButton : Button
    {
        // Declare an instance variable
        public bool clicked = false;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="texture">The button texture</param>
        /// <param name="position">The button position</param>
        public LoadTileButton(Texture2D texture, Vector2 position)
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
            // Freeze the game
            Game1.gameState = GameState.FREEZE;

            // Create an instance of the new tilesheet form
            Forms.NewTileSheetForm frmTileSheet = new Forms.NewTileSheetForm();
            frmTileSheet.ShowDialog();

            // Get the tileset if the ok button has been clicked
            if (frmTileSheet.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Game1.tileHeight = frmTileSheet.tileHeight;
                Game1.tileWidth = frmTileSheet.tileWidth;
                Game1.tileSheetFileName = frmTileSheet.sheetFileName;
                base.prevClicked = false;

                // Import the tile sheet as a texture
                try
                {
                    // Load the texture
                    using (System.IO.Stream stream = System.IO.File.OpenRead(Game1.tileSheetFileName))
                    {
                        Game1.tileSheet = Texture2D.FromStream(Game1.graphics.GraphicsDevice, stream);
                    }

                    Game1.map.LoadTileSet(Game1.tileSheet);
                }
                catch (Exception e)
                {
                    // The texture file name may be empty or not exist
                    System.Windows.Forms.MessageBox.Show("There was an error loading the texture.\nError: " + e);
                }
            }
            else
            {
                // Reset the button click property
                base.prevClicked = false;
            }
            base.Effect();
        }
    }
}
