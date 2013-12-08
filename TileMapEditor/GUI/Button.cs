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
    public class Button
    {

        public bool clicked = false;
        public bool prevClicked = false;
        bool hover = false;
        Texture2D texture;
        public Vector2 position;
        Rectangle collisionRect;


        public Button(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }


        public virtual void Update()
        {
            // Get the collision rectangle for the button
            collisionRect = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            // Get the mouse position
            MouseState mouse = Mouse.GetState();
            Rectangle mousePos = new Rectangle(mouse.X, mouse.Y, 1, 1);

            // Check if the user is hovering over the button
            if (mousePos.Intersects(collisionRect))
                hover = true;
            else
                hover = false;

            // Check if the button has been clicked
            if (mousePos.Intersects(collisionRect) && mouse.LeftButton == ButtonState.Pressed && !prevClicked)
                clicked = true;
            else
                clicked = false;

            // Update prevClicked
            prevClicked = prevClicked || clicked;
        }


        public virtual void Effect()
        {
            // Empty function for override
        }


        public void Draw()
        {
            // Draw the button
            if (hover)
            {
                Game1.spriteBatch.Draw(texture, position, Color.White);
                Game1.spriteBatch.Draw(texture, position, new Color(255, 0, 0, 180));
            }
            else
            {
                Game1.spriteBatch.Draw(texture, position, Color.White);
            }
        }
    }
}
