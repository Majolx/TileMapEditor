using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor.GUI
{
    class SaveMapButton : Button
    {
        // Declare an instance variable
        public bool clicked = false;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="texture">The button texture</param>
        /// <param name="position">The button position</param>
        public SaveMapButton(Texture2D texture, Vector2 position)
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
            
            // Create and show the save map form
            Forms.SaveMapForm saveMap = new Forms.SaveMapForm();
            saveMap.ShowDialog();

            // Get the dialog result
            if (saveMap.DialogResult == System.Windows.Forms.DialogResult.OK)
                base.prevClicked = false;
            else
                base.prevClicked = false;


            base.Effect();
        }
    }
}
