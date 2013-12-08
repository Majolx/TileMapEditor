using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor
{
    public class Layer
    {
        // Declare the layer array
        public int[,] layer;

        // Declare map and tile size
        int mapWidth, mapHeight, tileWidth, tileHeight;


        public Layer(int mapWidth, int mapHeight, int tileWidth, int tileHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            layer = new int[mapWidth, mapHeight];
        }


        public void SetTiles(int selectedTile)
        {
            Vector2 mouse;
            double mouseMapX;
            double mouseMapY;

            // Get the mouse position on left click
            MouseState currMouseState = Mouse.GetState();

            try
            {
                // Check for tile laying
                if (currMouseState.LeftButton == ButtonState.Pressed)
                {
                    mouse = new Vector2(currMouseState.X, currMouseState.Y);
                    mouseMapX = ((int)mouse.X / tileWidth) + Game1.drawOffset.X;
                    mouseMapY = ((int)mouse.Y / tileHeight) + Game1.drawOffset.Y;
                    if (mouseMapX < mapWidth && mouseMapY < mapHeight && mouseMapX >= 0 && mouseMapY >= 0)
                    {
                        layer[(int)mouseMapX, (int)mouseMapY] = selectedTile;
                    }
                }

                // Check for tile deleting
                if (currMouseState.RightButton == ButtonState.Pressed)
                {
                    mouse = new Vector2(currMouseState.X, currMouseState.Y);
                    mouseMapX = ((int)mouse.X / tileWidth) + Game1.drawOffset.X;
                    mouseMapY = ((int)mouse.Y / tileHeight) + Game1.drawOffset.Y;
                    if (mouseMapX < mapWidth && mouseMapY < mapHeight && mouseMapX >= 0 && mouseMapY >= 0)
                    {
                        layer[(int)mouseMapX, (int)mouseMapY] = 0;
                    }
                }
            }
            catch
            {
                ;// Empty
            }
        }


        public void SaveLayer(System.IO.StreamWriter objWriter)
        {
            try
            {
                // Write the Layer to the text file
                for (int i = 0; i < mapWidth; ++i)
                {
                    for (int j = 0; j < mapHeight; ++j)
                    {
                        objWriter.WriteLine(layer[i, j]);
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("There was an error saving the map.nError:" + e);
            }
        }


        public void LoadLayer(System.IO.StreamReader objReader)
        {
            try
            {
                // Populate the layer array
                for (int i = 0; i < mapWidth; ++i)
                {
                    for (int j = 0; j < mapHeight; ++j)
                    {
                        layer[i, j] = Convert.ToInt32(objReader.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("There was an error saving the map.nError:" + e);
            }
        }
    }
}
