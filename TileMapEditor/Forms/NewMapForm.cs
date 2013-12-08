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
    public partial class NewMapForm : Form
    {
        // Declare map and tile dimensions
        public int mapHeight;
        public int mapWidth;
        public int tileHeight;
        public int tileWidth;

        // Declare the map name
        public String mapName;

        public NewMapForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Get input from the form
            mapName = mapNameTextBox.Text;
            mapHeight = Convert.ToInt32(mapHeightBox.Value);
            mapWidth = Convert.ToInt32(mapWidthBox.Value);
            tileHeight = Convert.ToInt32(tileHeightBox.Value);
            tileWidth = Convert.ToInt32(tileWidthBox.Value);

            // Set the dialog result to ok
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Cancel the input
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
