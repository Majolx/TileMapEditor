using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TileMapEditor.Forms
{
    public partial class LoadMapForm : Form
    {
        // Declare the load file name
        string loadFileName;

        public LoadMapForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Set the initial directory
            openFileDialog.InitialDirectory = "C:\\";

            // Set the title for the dialog box
            openFileDialog.Title = "Select a Map File";
            openFileDialog.FileName = "";

            // Set the filter for text files only
            openFileDialog.Filter = "Text Files (*.txt) | *.txt";
            openFileDialog.FilterIndex = 1;

            // Load the map
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                loadFileName = openFileDialog.FileName;
                fileNameBox.Text = loadFileName;
            }
            else
            {
                loadFileName = "";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Return the cancel dialog result
            this.DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Check that a tile sheet has been loaded before the map file is
            if (Game1.tileSheetFileName != null)
            {
                Game1.map.LoadMap(loadFileName);
            }
            else
            {
                MessageBox.Show("Please load a tile set before loading a map.");
            }

            // Update the map size and tile dimensions
            Game1.mapHeight = Game1.map.mapHeight;
            Game1.mapWidth = Game1.map.mapWidth;
            Game1.tileHeight = Game1.map.tileHeight;
            Game1.tileWidth = Game1.map.tileWidth;

            // Update the map size and tile dimensions
            Game1.map = new Map(Game1.mapWidth, Game1.mapHeight, Game1.tileWidth, Game1.tileHeight);

            // Load the map
            Game1.map.LoadMap(loadFileName);

            // Re-load the tile set
            Game1.map.LoadTileSet(Game1.tileSheet);

            // Return the OK dialog result
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
